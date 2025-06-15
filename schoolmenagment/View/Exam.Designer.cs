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
            lblsubject = new Label();
            cmbsubject = new ComboBox();
            btnadd = new Button();
            dataGridView1 = new DataGridView();
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
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(137, 71);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(46, 15);
            lblsubject.TabIndex = 2;
            lblsubject.Text = "Subject";
            // 
            // cmbsubject
            // 
            cmbsubject.FormattingEnabled = true;
            cmbsubject.Location = new Point(221, 67);
            cmbsubject.Name = "cmbsubject";
            cmbsubject.Size = new Size(259, 23);
            cmbsubject.TabIndex = 3;
            cmbsubject.SelectedIndexChanged += cmbsubject_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(290, 129);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(462, 200);
            dataGridView1.TabIndex = 5;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnadd);
            Controls.Add(cmbsubject);
            Controls.Add(lblsubject);
            Controls.Add(txtexamname);
            Controls.Add(lblexamname);
            Name = "Exam";
            Text = "Exam";
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
    }
}