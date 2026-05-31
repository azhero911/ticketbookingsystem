namespace ticketbookingsystem
{
    partial class view
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            searchtxt = new TextBox();
            Searchbtn = new Button();
            resetbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1897, 271);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(843, 536);
            button1.Name = "button1";
            button1.Size = new Size(216, 65);
            button1.TabIndex = 0;
            button1.Text = "Load my Bookings";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(123, 836);
            button2.Name = "button2";
            button2.Size = new Size(216, 42);
            button2.TabIndex = 1;
            button2.Text = "go to menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 64);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 2;
            label1.Text = "Check Your Bookings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(1367, 26);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 3;
            label2.Text = "Search By Movie";
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(1367, 70);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(269, 31);
            searchtxt.TabIndex = 4;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(1659, 70);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(80, 34);
            Searchbtn.TabIndex = 5;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.Location = new Point(1444, 140);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(112, 34);
            resetbtn.TabIndex = 6;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // view
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1898, 1024);
            Controls.Add(resetbtn);
            Controls.Add(Searchbtn);
            Controls.Add(searchtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "view";
            Text = "viewBooking";
            Load += viewBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox searchtxt;
        private Button Searchbtn;
        private Button resetbtn;
    }
}