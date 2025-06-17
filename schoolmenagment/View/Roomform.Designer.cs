namespace schoolmenagment.View
{
    partial class Roomform
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
            lblroom = new Label();
            txtroomname = new TextBox();
            lblroomtype = new Label();
            txtroomtype = new TextBox();
            dgvroom = new DataGridView();
            btnadd = new Button();
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvroom).BeginInit();
            SuspendLayout();
            // 
            // lblroom
            // 
            lblroom.AutoSize = true;
            lblroom.Location = new Point(180, 29);
            lblroom.Name = "lblroom";
            lblroom.Size = new Size(74, 15);
            lblroom.TabIndex = 0;
            lblroom.Text = "Room Name";
            // 
            // txtroomname
            // 
            txtroomname.Location = new Point(283, 21);
            txtroomname.Name = "txtroomname";
            txtroomname.Size = new Size(175, 23);
            txtroomname.TabIndex = 1;
            // 
            // lblroomtype
            // 
            lblroomtype.AutoSize = true;
            lblroomtype.Location = new Point(187, 76);
            lblroomtype.Name = "lblroomtype";
            lblroomtype.Size = new Size(67, 15);
            lblroomtype.TabIndex = 2;
            lblroomtype.Text = "Room Type";
            // 
            // txtroomtype
            // 
            txtroomtype.Location = new Point(283, 68);
            txtroomtype.Name = "txtroomtype";
            txtroomtype.Size = new Size(175, 23);
            txtroomtype.TabIndex = 3;
            // 
            // dgvroom
            // 
            dgvroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvroom.Location = new Point(149, 184);
            dgvroom.Name = "dgvroom";
            dgvroom.Size = new Size(381, 150);
            dgvroom.TabIndex = 4;
            dgvroom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(149, 145);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 5;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(260, 145);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 6;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(383, 145);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 7;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Roomform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(dgvroom);
            Controls.Add(txtroomtype);
            Controls.Add(lblroomtype);
            Controls.Add(txtroomname);
            Controls.Add(lblroom);
            Name = "Roomform";
            Text = "Roomform";
            ((System.ComponentModel.ISupportInitialize)dgvroom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblroom;
        private TextBox txtroomname;
        private Label lblroomtype;
        private TextBox txtroomtype;
        private DataGridView dgvroom;
        private Button btnadd;
        private Button btnedit;
        private Button btndelete;
    }
}