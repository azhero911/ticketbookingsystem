namespace ticketbookingsystem
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newBookingToolStripMenuItem = new ToolStripMenuItem();
            viewBookingToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lbl1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Brown;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1898, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = Color.Gold;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBookingToolStripMenuItem, viewBookingToolStripMenuItem, logoutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newBookingToolStripMenuItem
            // 
            newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem";
            newBookingToolStripMenuItem.Size = new Size(222, 34);
            newBookingToolStripMenuItem.Text = "New Booking";
            newBookingToolStripMenuItem.Click += newBookingToolStripMenuItem_Click;
            // 
            // viewBookingToolStripMenuItem
            // 
            viewBookingToolStripMenuItem.Name = "viewBookingToolStripMenuItem";
            viewBookingToolStripMenuItem.Size = new Size(222, 34);
            viewBookingToolStripMenuItem.Text = "View Booking";
            viewBookingToolStripMenuItem.Click += viewBookingToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(222, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Gold;
            lbl1.ForeColor = Color.Firebrick;
            lbl1.Location = new Point(1498, 90);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(47, 25);
            lbl1.TabIndex = 2;
            lbl1.Text = "       ";
            lbl1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._795adddab1850e3e12aa194d3f53e6ed;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(18, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 357);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.a9a4a1fc9625103ddf3e2ac20110dd1e;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(300, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 357);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.aebedea565116005359ffa4b29344622;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(633, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 357);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(136, 66);
            label1.Name = "label1";
            label1.Size = new Size(142, 34);
            label1.TabIndex = 6;
            label1.Text = "Cinepax";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(485, 292);
            panel4.Name = "panel4";
            panel4.Size = new Size(898, 363);
            panel4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(867, 704);
            button1.Name = "button1";
            button1.Size = new Size(163, 44);
            button1.TabIndex = 8;
            button1.Text = "Book Now";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources._48a6db7abd70f80ae72b94f7b2845a8f;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = button1;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(menuStrip1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ImeMode = ImeMode.Off;
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menupage";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newBookingToolStripMenuItem;
        private ToolStripMenuItem viewBookingToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Label lbl1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button button1;
    }
}