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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-11, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(962, 187);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 262);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // btnedit
            // 
            btnedit.Location = new Point(451, 301);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(112, 34);
            btnedit.TabIndex = 2;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(695, 446);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(375, 446);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(55, 446);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 34);
            btndelete.TabIndex = 7;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(252, 304);
            txtname.Name = "txtname";
            txtname.Size = new Size(150, 31);
            txtname.TabIndex = 8;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // ManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 528);
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
    }
}