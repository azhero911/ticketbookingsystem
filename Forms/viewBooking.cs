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

    public partial class view : Form
    {
        string currentUser;
        public view(string username)
        {
            InitializeComponent();
            currentUser = username;
        }



        private void viewBooking_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//fill the grid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.bookings;

            dataGridView1.BackgroundColor = Color.FromArgb(18, 18, 18);//give colors to datagrid

            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;

            // Header Style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 9, 20);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            // Rows
            dataGridView1.RowsDefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 30);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(45, 45, 45);

            // Text
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;

            // Selection
            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.DarkRed;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.White;

            // Grid Lines
            dataGridView1.GridColor = Color.Gray;

            // Optional
            dataGridView1.RowTemplate.Height = 35;
        }


        private void button1_Click(object sender, EventArgs e)//load the bookings when button clicked from booking table
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT * FROM Bookings WHERE Username=@user";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@user", currentUser);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3(currentUser);
            d.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT * FROM Bookings WHERE Username=@user AND MovieName LIKE @movie";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@user", currentUser);
            da.SelectCommand.Parameters.AddWithValue("@movie", "%" + searchtxt.Text.Trim() + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No booking found!");
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        
           
        {
            button1_Click(sender, e); // reload all bookings
            searchtxt.Clear();
        
    }
    }
}
