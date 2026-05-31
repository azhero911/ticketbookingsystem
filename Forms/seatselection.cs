using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ticketbookingsystem
{

    public partial class seatselection : Form
    {
        public string selectedMovie;
        public string selectedTime;
        public bool isAdmin = false;
        public seatselection()
        {
            InitializeComponent();
        }
        public int maxSeats = 0;
        public string selectedSeatsText = "";
        List<string> selectedSeats = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            // No seat selected
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat!");
                return;
            }

            // Less seats than required
            if (selectedSeats.Count < maxSeats)
            {
                MessageBox.Show("Please select " + maxSeats + " seats!");
                return;
            }

            //  All good
            selectedSeatsText = string.Join(", ", selectedSeats);
            this.Close();
        }

        private void Seat_Click(object sender, EventArgs e)//color the seats on selection


        {
            Button btn = (Button)sender;

            //  check admin
            if (isAdmin)
                return;

            // Ignore booked seats
            if (btn.BackColor == Color.Red)
                return;

            // If already selected then remove
            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.LightGray;
                selectedSeats.Remove(btn.Text);
            }
            else
            {
                if (selectedSeats.Count >= maxSeats)
                {
                    MessageBox.Show("You can only select " + maxSeats + " seats");
                    return;
                }
                btn.BackColor = Color.Green;
                selectedSeats.Add(btn.Text);
            }

            // Update label
            if (selectedSeats.Count == 0)
                lblseats.Text = "Selected Seats: None";
            else

                lblseats.Text = "Selected Seats: " + string.Join(", ", selectedSeats);
        }

        void MarkSeat(Control parent, string seat)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button && c.Text.Trim() == seat.Trim())
                {
                    Button btn = (Button)c;
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }

                if (c.HasChildren)
                {
                    MarkSeat(c, seat);
                }
            }
        }
        void SetDefaultSeatColor(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;

                    // skip non-seat buttons if needed
                    if (btn.Text.Length <= 3) // A1, B2 etc.
                    {
                        btn.BackColor = Color.LightGray;
                        btn.Enabled = true;
                    }
                }

                if (c.HasChildren)
                {
                    SetDefaultSeatColor(c);
                }
            }
        }
        private void seatselection_Load(object sender, EventArgs e)
        {
          
            SetDefaultSeatColor(this);

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT seats FROM Bookings WHERE Moviename=@m AND showTime=@t";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", selectedMovie.Trim());
            cmd.Parameters.AddWithValue("@t", selectedTime.Trim());

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //  STEP 2: Load booked seats
            while (reader.Read())
            {
                string[] bookedSeats = reader["seats"].ToString().Replace(" ", "").Split(',');

                foreach (string seat in bookedSeats)
                {
                    MarkSeat(this, seat); // mark red
                }
            }

            con.Close();

        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {
       
        }
    }
}

