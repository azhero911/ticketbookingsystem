using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ticketbookingsystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageMovies f = new ManageMovies();
            f.Show();
            this.Close();
        }

        private void manageBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBookings f = new ManageBookings();
            f.Show(); this.Close();
        }

        private void seatsManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seatmanage s = new Seatmanage();
            s.Show(); this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
            this.Close();
        }
    }
}
