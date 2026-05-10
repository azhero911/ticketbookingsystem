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
    public partial class ManageMovies : Form
    {
        public ManageMovies()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void txtmovie_TextChanged(object sender, EventArgs e)
        {

        }
        void LoadMovies()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "SELECT * FROM Movies";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtmovie.Text == "" || txtshowtime.Text == "")
            {
                MessageBox.Show("Enter movie and time");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "INSERT INTO Movies (MovieName, ShowTime) VALUES (@m, @t)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", txtmovie.Text);
            cmd.Parameters.AddWithValue("@t", txtshowtime.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Movie Added!");
            LoadMovies();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtmovie.Text = dataGridView1.CurrentRow.Cells["MovieName"].Value.ToString();
            txtshowtime.Text = dataGridView1.CurrentRow.Cells["ShowTime"].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Movie_ID"].Value);

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "UPDATE Movies SET MovieName=@m, ShowTime=@t WHERE Movie_ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@m", txtmovie.Text);
            cmd.Parameters.AddWithValue("@t", txtshowtime.Text);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Movie Updated!");
            LoadMovies();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Movie_ID"].Value);

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");

            string query = "DELETE FROM Movies WHERE Movie_ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Movie Deleted!");
            LoadMovies();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin n=new Admin();  
            n.Show();
            this.Close  ();

        }
    }
}
