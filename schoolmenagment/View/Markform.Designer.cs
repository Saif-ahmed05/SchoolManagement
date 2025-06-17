namespace schoolmenagment.View
{
    partial class Markform
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
            lblstudentid = new Label();
            lblexam = new Label();
            cmbexam = new ComboBox();
            lblscore = new Label();
            txtscore = new TextBox();
            btnadd = new Button();
            dataGridView1 = new DataGridView();
            txtstudentid = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.Location = new Point(202, 24);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(61, 15);
            lblstudentid.TabIndex = 0;
            lblstudentid.Text = "Student Id";
            lblstudentid.Click += label1_Click;
            // 
            // lblexam
            // 
            lblexam.AutoSize = true;
            lblexam.Location = new Point(203, 62);
            lblexam.Name = "lblexam";
            lblexam.Size = new Size(35, 15);
            lblexam.TabIndex = 2;
            lblexam.Text = "Exam";
            // 
            // cmbexam
            // 
            cmbexam.FormattingEnabled = true;
            cmbexam.Location = new Point(274, 54);
            cmbexam.Name = "cmbexam";
            cmbexam.Size = new Size(121, 23);
            cmbexam.TabIndex = 3;
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.Location = new Point(202, 99);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(36, 15);
            lblscore.TabIndex = 4;
            lblscore.Text = "Score";
            // 
            // txtscore
            // 
            txtscore.Location = new Point(274, 91);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(121, 23);
            txtscore.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(163, 149);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(151, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(365, 187);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtstudentid
            // 
            txtstudentid.Location = new Point(274, 21);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(121, 23);
            txtstudentid.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnedit
            // 
            btnedit.Location = new Point(285, 152);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 10;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(399, 152);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 11;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Markform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(txtstudentid);
            Controls.Add(dataGridView1);
            Controls.Add(btnadd);
            Controls.Add(txtscore);
            Controls.Add(lblscore);
            Controls.Add(cmbexam);
            Controls.Add(lblexam);
            Controls.Add(lblstudentid);
            Name = "Markform";
            Text = "Markform";
            Load += Markform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentid;
        private Label lblexam;
        private ComboBox cmbexam;
        private Label lblscore;
        private TextBox txtscore;
        private Button btnadd;
        private DataGridView dataGridView1;
        private TextBox txtstudentid;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnedit;
        private Button btndelete;
    }
}