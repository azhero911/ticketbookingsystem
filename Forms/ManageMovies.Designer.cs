namespace ticketbookingsystem
{
    partial class ManageMovies
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
            txtmovie = new TextBox();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            txtshowtime = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 500);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1787, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(722, 136);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 1;
            label1.Text = "Movie Name";
            // 
            // txtmovie
            // 
            txtmovie.Location = new Point(908, 133);
            txtmovie.Name = "txtmovie";
            txtmovie.Size = new Size(262, 31);
            txtmovie.TabIndex = 2;
            txtmovie.TextChanged += txtmovie_TextChanged;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Yellow;
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnadd.Location = new Point(200, 344);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(156, 72);
            btnadd.TabIndex = 3;
            btnadd.Text = "Add Movie";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Lime;
            btnupdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnupdate.Location = new Point(902, 338);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(160, 78);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update Movie";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndelete.Location = new Point(1548, 338);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(149, 78);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete Movie";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // txtshowtime
            // 
            txtshowtime.Location = new Point(908, 212);
            txtshowtime.Name = "txtshowtime";
            txtshowtime.Size = new Size(262, 31);
            txtshowtime.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(722, 212);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 7;
            label2.Text = "Show Time";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1672, 914);
            button1.Name = "button1";
            button1.Size = new Size(156, 68);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ManageMovies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtshowtime);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtmovie);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ManageMovies";
            Text = "ManageMovies";
            Load += ManageMovies_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtmovie;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private TextBox txtshowtime;
        private Label label2;
        private Button button1;
    }
}