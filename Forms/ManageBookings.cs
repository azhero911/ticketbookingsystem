using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ticketbookingsystem
{
    public partial class ManageBookings : Form
    {
        string conStr = "Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True";
        public ManageBookings()
        {
            InitializeComponent();
        }
        void LoadBookings()
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM Bookings";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtname.Text = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Booking_ID"].Value);

            SqlConnection con = new SqlConnection(conStr);

            string query = "UPDATE Bookings SET CustomerName=@name WHERE Booking_ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated!");

            LoadBookings();

        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadBookings();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a booking first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this booking?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Booking_ID"].Value);

            SqlConnection con = new SqlConnection(conStr);

            string query = "DELETE FROM Bookings WHERE Booking_ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Booking deleted!");

            LoadBookings(); // refresh grid

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM Bookings WHERE MovieName LIKE @movie";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
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
            searchtxt.Clear();

            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM Bookings";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }

}
