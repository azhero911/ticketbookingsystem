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
            label2 = new Label();
            label3 = new Label();
            cmbMovie = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txttime = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 89);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(264, 86);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(182, 33);
            cmbMovie.TabIndex = 3;
            cmbMovie.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(146, 240);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Load Seats";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(612, 384);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(453, 240);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Clear seats";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txttime
            // 
            txttime.AutoSize = true;
            txttime.Location = new Point(276, 150);
            txttime.Name = "txttime";
            txttime.Size = new Size(59, 25);
            txttime.TabIndex = 8;
            txttime.Text = "label4";
            // 
            // Seatmanage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttime);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbMovie);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Seatmanage";
            Text = "Seatmanage";
            Load += Seatmanage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMovie;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label txttime;
    }
}