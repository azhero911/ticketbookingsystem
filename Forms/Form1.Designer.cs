namespace ticketbookingsystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtpass = new TextBox();
            label1 = new Label();
            button2 = new Button();
            lblMessage = new Label();
            button1 = new Button();
            txtuser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BackgroundImage = Properties.Resources.ba070f85325b43b5a5aa7f0ac61ca53a2;
            resources.ApplyResources(panel1, "panel1");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(label3);
            panel1.Name = "panel1";
            panel1.AutoSizeChanged += panel1_SizeChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.lock1;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user1;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.Name = "txtpass";
            txtpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Control;
            label1.Image = Properties.Resources._1fe3e1af8302eaa73284484088a521e4;
            label1.Name = "label1";
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Cursor = Cursors.Hand;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblMessage
            // 
            resources.ApplyResources(lblMessage, "lblMessage");
            lblMessage.BackColor = SystemColors.ButtonHighlight;
            lblMessage.ForeColor = Color.DarkKhaki;
            lblMessage.Name = "lblMessage";
            lblMessage.Click += lblMessage_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.FloralWhite;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.ButtonFace;
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtuser, "txtuser");
            txtuser.Name = "txtuser";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.WhiteSmoke;
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.BackColor = Color.Orange;
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources._2bd5b250f957f8b29152ba0595adbf4c1;
            Controls.Add(label2);
            Controls.Add(panel1);
            Cursor = Cursors.IBeam;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            ShowInTaskbar = false;
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button2;
        private Label lblMessage;
        private Button button1;
        private TextBox txtuser;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtpass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
    }
}
