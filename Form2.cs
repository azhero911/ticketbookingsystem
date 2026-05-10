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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // 2. Check password match
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "INSERT INTO Users (Username, Passwords) VALUES (@u, @p)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Signup Successful!");
            Form1 login = new Form1();
            login.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
