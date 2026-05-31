namespace ticketbookingsystem
{
    partial class Seatmanage
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
            label1 = new Label();
            label3 = new Label();
            cmbMovie = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txttime = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(855, 88);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Seat Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(746, 219);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 2;
            label3.Text = "Select Movie";
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(746, 274);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(410, 33);
            cmbMovie.TabIndex = 3;
            cmbMovie.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(627, 463);
            button1.Name = "button1";
            button1.Size = new Size(112, 59);
            button1.TabIndex = 5;
            button1.Text = "Load Seats";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(1563, 814);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(1163, 463);
            button3.Name = "button3";
            button3.Size = new Size(112, 59);
            button3.TabIndex = 7;
            button3.Text = "Clear seats";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txttime
            // 
            txttime.AutoSize = true;
            txttime.Location = new Point(958, 339);
            txttime.Name = "txttime";
            txttime.Size = new Size(56, 25);
            txttime.TabIndex = 8;
            txttime.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(746, 335);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 9;
            label2.Text = "Show Time";
            // 
            // Seatmanage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1898, 1024);
            Controls.Add(label2);
            Controls.Add(txttime);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbMovie);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Seatmanage";
            Text = "Seatmanage";
            Load += Seatmanage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox cmbMovie;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label txttime;
        private Label label2;
    }
}