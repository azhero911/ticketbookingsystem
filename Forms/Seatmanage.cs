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
    public partial class Seatmanage : Form
    {
        public Seatmanage()
        {
            InitializeComponent();
        }

        private void Seatmanage_Load(object sender, EventArgs e)
        {
            if (cmbMovie == null || txttime == null)
            {
                MessageBox.Show("Movie or Time not set!");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT MovieName FROM Movies";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            cmbMovie.Items.Clear();

            while (reader.Read())
            {
                cmbMovie.Items.Add(reader["MovieName"].ToString());
            }

            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Admin s = new Admin();
            s.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMovie.Text == "")
            {
                MessageBox.Show("Select movie!");
                return;
            }

            if (txttime.Text == "")
            {
                MessageBox.Show("Select time!");
                return;
            }

            seatselection d = new seatselection();


            d.selectedMovie = cmbMovie.Text;
            d.selectedTime = txttime.Text;
            d.isAdmin = true;
            d.maxSeats = 0; // optional

            d.ShowDialog();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT ShowTime FROM Movies WHERE MovieName=@m";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", cmbMovie.Text.Trim());

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txttime.Text = reader["ShowTime"].ToString();
            }
            else
            {
                txttime.Text = "";
            }

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (cmbMovie.Text == "")
            {
                MessageBox.Show("Select movie!");
                return;
            }

            if (txttime.Text == "")
            {
                MessageBox.Show("Select time!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all seats?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
                return;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "DELETE FROM Bookings WHERE Moviename=@m AND showTime=@t";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", cmbMovie.Text);
            cmd.Parameters.AddWithValue("@t", txttime.Text);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Seats cleared! (" + rows + " bookings removed)");

        
    }
    }
}
