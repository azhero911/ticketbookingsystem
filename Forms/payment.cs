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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        public string name;
        public string movie;
        public string time;
        public string seats;
        public string category;
        public string total;
        public string username;
        private void payement_Load(object sender, EventArgs e)//automatically label will given the values from booking form
        {
            lbltext.Text = name;
            lblmovie.Text = movie;
            lbltime.Text = time;
            lblseats.Text = seats;
            lblcat.Text = category;
            lbltotal.Text = total;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Select payment method");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

                string query = "INSERT INTO Bookings (Username, CustomerName, Moviename, showTime, Tickets, seats, Totalprice) VALUES (@user, @name, @movie, @time, @tickets, @seats, @price)";

                SqlCommand cmd = new SqlCommand(query, con);//insert values into booking table of databse only if user click ok 

                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@movie", movie);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@tickets", seats.Split(',').Length);
                cmd.Parameters.AddWithValue("@seats", seats);
                int price = int.Parse(total.Replace(" PKR", ""));
                cmd.Parameters.AddWithValue("@price", price);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booking Confirmed!");

                Form3 d = new Form3(username);
                d.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bookingform h = new bookingform(username);
            h.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

        
    }
}
