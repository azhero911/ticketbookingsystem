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
            dataGridView1.Location = new Point(-11, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(811, 152);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 1;
            label1.Text = "Movie Name";
            // 
            // txtmovie
            // 
            txtmovie.Location = new Point(311, 33);
            txtmovie.Name = "txtmovie";
            txtmovie.Size = new Size(150, 31);
            txtmovie.TabIndex = 2;
            txtmovie.TextChanged += txtmovie_TextChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(61, 181);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(130, 34);
            btnadd.TabIndex = 3;
            btnadd.Text = "Add Movie";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(324, 181);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(156, 34);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update Movie";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(593, 181);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(149, 34);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete Movie";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // txtshowtime
            // 
            txtshowtime.Location = new Point(311, 92);
            txtshowtime.Name = "txtshowtime";
            txtshowtime.Size = new Size(150, 31);
            txtshowtime.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 7;
            label2.Text = "Show Time";
            // 
            // button1
            // 
            button1.Location = new Point(632, 404);
            button1.Name = "button1";
            button1.Size = new Size(156, 34);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManageMovies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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