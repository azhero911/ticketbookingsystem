using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace ticketbookingsystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string currentUser;

        void SetRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 270, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentUser = txtuser.Text;

            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                lblMessage.Text = "Please enter username and password!";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFIM6U6R;Initial Catalog=ticketdb;Integrated Security=True");
            con.Open();

            // Case-sensitive username check
            string checkUser = "SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @u";
            SqlCommand cmdUser = new SqlCommand(checkUser, con);
            cmdUser.Parameters.AddWithValue("@u", txtuser.Text);

            int userExists = (int)cmdUser.ExecuteScalar();

            if (userExists == 0)
            {
                lblMessage.Text = "Username not found!";
                lblMessage.ForeColor = Color.Red;
                con.Close();
                return;
            }

            // ✅ Case-sensitive password check
            string checkPass = "SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @u AND Passwords COLLATE Latin1_General_CS_AS = @p";
            SqlCommand cmdPass = new SqlCommand(checkPass, con);
            cmdPass.Parameters.AddWithValue("@u", txtuser.Text);
            cmdPass.Parameters.AddWithValue("@p", txtpass.Text);

            int validLogin = (int)cmdPass.ExecuteScalar();

            if (validLogin == 1)
            {
                currentUser = txtuser.Text;

                lblMessage.Text = "Login Successful!";
                lblMessage.ForeColor = Color.Green;

                if (txtuser.Text == "admin" && txtpass.Text == "123123")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    Form3 menu = new Form3(currentUser);
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                lblMessage.Text = "Incorrect Password!";
                lblMessage.ForeColor = Color.Red;
            }

            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SetRoundedPanel(panel1, 20);
            txtpass.UseSystemPasswordChar = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            this.ActiveControl = label1;

            SetRoundedPanel(panel1, 20); // 20 = smooth corners
        }
        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            SetRoundedPanel(panel1, 20);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
