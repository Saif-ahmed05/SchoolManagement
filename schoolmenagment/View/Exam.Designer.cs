namespace schoolmenagment.View
{
    partial class Exam
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
            lblexamname = new Label();
            txtexamname = new TextBox();
            lblcourse = new Label();
            cmbcourse = new ComboBox();
            btnadd = new Button();
            dataGridView1 = new DataGridView();
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblexamname
            // 
            lblexamname.AutoSize = true;
            lblexamname.Location = new Point(123, 25);
            lblexamname.Name = "lblexamname";
            lblexamname.Size = new Size(73, 15);
            lblexamname.TabIndex = 0;
            lblexamname.Text = "Exam Name ";
            // 
            // txtexamname
            // 
            txtexamname.Location = new Point(221, 21);
            txtexamname.Name = "txtexamname";
            txtexamname.Size = new Size(259, 23);
            txtexamname.TabIndex = 1;
            txtexamname.TextChanged += txtexamname_TextChanged;
            // 
            // lblcourse
            // 
            lblcourse.AutoSize = true;
            lblcourse.Location = new Point(137, 71);
            lblcourse.Name = "lblcourse";
            lblcourse.Size = new Size(44, 15);
            lblcourse.TabIndex = 2;
            lblcourse.Text = "Course";
            // 
            // cmbcourse
            // 
            cmbcourse.FormattingEnabled = true;
            cmbcourse.Location = new Point(221, 67);
            cmbcourse.Name = "cmbcourse";
            cmbcourse.Size = new Size(259, 23);
            cmbcourse.TabIndex = 3;
            cmbcourse.SelectedIndexChanged += cmbsubject_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(121, 134);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(462, 200);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(259, 134);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 6;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(405, 134);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 7;
            btndelete.Text = "delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(dataGridView1);
            Controls.Add(btnadd);
            Controls.Add(cmbcourse);
            Controls.Add(lblcourse);
            Controls.Add(txtexamname);
            Controls.Add(lblexamname);
            Name = "Exam";
            Text = "Exam";
            Load += Exam_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblexamname;
        private TextBox txtexamname;
        private Label lblsubject;
        private ComboBox cmbsubject;
        private Button btnadd;
        private DataGridView dataGridView1;
        private Button btnedit;
        private Button btndelete;
        private Label lblcourse;
        private ComboBox cmbcourse;
    }
}