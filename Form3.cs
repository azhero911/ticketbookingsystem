using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace ticketbookingsystem
{
    public partial class Form3 : Form
    {
        string currentUser;
        public Form3(string username)
        {
            InitializeComponent();
            currentUser = username;
        }
        private void Form3_Load(object sender, EventArgs e)

        {

            lbl1.Text = "Welcome " + currentUser;
            ;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void MakeCircularButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }
        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingform s = new bookingform(currentUser);
            s.Show();
            this.Close();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            // you can leave it empty for now
        }

        private void viewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBooking v = new viewBooking(currentUser);
            v.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bookingform s = new bookingform(currentUser);
            s.Show();
            this.Close();
        }
    }
    }




