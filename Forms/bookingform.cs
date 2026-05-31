using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace ticketbookingsystem
{
    public partial class bookingform : Form
    {
        string currentUser;
        public bookingform(string username)//get username from login page
        {
            InitializeComponent();
            currentUser = username;

        }
        List<string> selectedSeats = new List<string>();
        private void CalculateTotal()
        {
            int price = 0;

            // Category price
            if (cmbcategory.Text == "V.I.P(800)")
                price = 800;
            else if (cmbcategory.Text == "Gold(600)")
                price = 600;
            else if (cmbcategory.Text == "Silver(400)")
                price = 400;
            // Count seats
            int seatCount = (int)nmdticket.Value;


            // Calculate total
            int total = seatCount * price;

            lbltotal.Text = total + " PKR";
        }
        private void bookingform_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT MovieName FROM Movies";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            cmbmovie.Items.Clear();

            while (reader.Read())
            {
                cmbmovie.Items.Add(reader["MovieName"].ToString());
            }

            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bookingform_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }





        private void Seat_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            seatselection d = new seatselection();
            d.ShowDialog();//not close this tab open on the current tab 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)//send values to seatselecrttion
        {
            seatselection d = new seatselection();

            d.maxSeats = (int)nmdticket.Value;

            
            d.selectedMovie = cmbmovie.Text;

             
            d.selectedTime = cmbtime.Text;

            d.ShowDialog();

            lblseats.Text = d.selectedSeatsText;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Please Enter your Name");
                return;

            }
            if (cmbmovie.Text == "" || cmbmovie.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a movie!");
                return;
            }
            // Check if seats are selected
            if (lblseats.Text == "" || lblseats.Text.Contains("None"))
            {
                MessageBox.Show("Please select seat(s) first!");
                return;
            }

            // Check tickets
            if (nmdticket.Value == 0)
            {
                MessageBox.Show("Please select number of tickets!");
                return;
            }

            // Check category
            if (cmbcategory.Text == "" || cmbcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select category!");
                return;
            }
            else
            {
                payment c = new payment();//send values to payement form
                c.username = currentUser;
                c.name = txtname.Text;
                c.movie = cmbmovie.Text;
                c.time = cmbtime.Text;
                c.seats = lblseats.Text;
                c.category = cmbcategory.Text;
                c.total = lbltotal.Text;
                c.Show();
                this.Close();
            }

        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)//show time in time box for each movie
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT ShowTime FROM Movies WHERE MovieName = @m";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", cmbmovie.Text.Trim());

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cmbtime.Text = reader["ShowTime"].ToString();
            }
            else
            {
                MessageBox.Show("No time found!");
            }

            con.Close();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//calculate price automatically when tickets number go up down
        {
            CalculateTotal();

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cmbtime_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click_3(object sender, EventArgs e)//logout
        {
            Form3 d = new Form3(currentUser);
            d.Show();
            this.Close();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
