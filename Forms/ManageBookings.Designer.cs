namespace ticketbookingsystem
{
    partial class ManageBookings
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
            label1 = new Label();
            btnedit = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            btndelete = new Button();
            txtname = new TextBox();
            label3 = new Label();
            Searchbtn = new Button();
            searchtxt = new TextBox();
            resetbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1800, 187);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(791, 405);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(255, 255, 128);
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(1169, 454);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(112, 49);
            btnedit.TabIndex = 2;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(55, 86);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 4;
            label2.Text = "BOOKED CUSTOMERS  DATA";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1471, 690);
            button2.Name = "button2";
            button2.Size = new Size(176, 62);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(834, 688);
            button3.Name = "button3";
            button3.Size = new Size(172, 62);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(212, 688);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(154, 62);
            btndelete.TabIndex = 7;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(791, 465);
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 31);
            txtname.TabIndex = 8;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1185, 39);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 9;
            label3.Text = "Search By Movie";
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(1600, 36);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(112, 34);
            Searchbtn.TabIndex = 10;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(1370, 36);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(204, 31);
            searchtxt.TabIndex = 11;
            // 
            // resetbtn
            // 
            resetbtn.Location = new Point(1462, 87);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(112, 34);
            resetbtn.TabIndex = 12;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // ManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(resetbtn);
            Controls.Add(searchtxt);
            Controls.Add(Searchbtn);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(btndelete);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(btnedit);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ManageBookings";
            Text = "ManageBookings";
            Load += ManageBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnedit;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button btndelete;
        private TextBox txtname;
        private Label label3;
        private Button Searchbtn;
        private TextBox searchtxt;
        private Button resetbtn;
    }
}