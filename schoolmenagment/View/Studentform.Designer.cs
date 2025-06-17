namespace schoolmenagment.View
{
    partial class Studentform
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
            lblStudentname = new Label();
            txtstudentname = new TextBox();
            lbladress = new Label();
            txtaddress = new TextBox();
            txtage = new TextBox();
            lblage = new Label();
            btnadd = new Button();
            btnedit = new Button();
            btndelete = new Button();
            dgvstudent = new DataGridView();
            lblgender = new Label();
            cmbgender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvstudent).BeginInit();
            SuspendLayout();
            // 
            // lblStudentname
            // 
            lblStudentname.AutoSize = true;
            lblStudentname.Location = new Point(156, 31);
            lblStudentname.Name = "lblStudentname";
            lblStudentname.Size = new Size(83, 15);
            lblStudentname.TabIndex = 0;
            lblStudentname.Text = "Student Name";
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(287, 28);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(169, 23);
            txtstudentname.TabIndex = 1;
            // 
            // lbladress
            // 
            lbladress.AutoSize = true;
            lbladress.Location = new Point(175, 79);
            lbladress.Name = "lbladress";
            lbladress.Size = new Size(49, 15);
            lbladress.TabIndex = 2;
            lbladress.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(287, 76);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(169, 23);
            txtaddress.TabIndex = 3;
            // 
            // txtage
            // 
            txtage.Location = new Point(287, 123);
            txtage.Name = "txtage";
            txtage.Size = new Size(169, 23);
            txtage.TabIndex = 4;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(186, 131);
            lblage.Name = "lblage";
            lblage.Size = new Size(28, 15);
            lblage.TabIndex = 5;
            lblage.Text = "Age";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(164, 213);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(301, 213);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 7;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(439, 213);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 8;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dgvstudent
            // 
            dgvstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstudent.Location = new Point(156, 255);
            dgvstudent.Name = "dgvstudent";
            dgvstudent.Size = new Size(423, 150);
            dgvstudent.TabIndex = 9;
            dgvstudent.CellContentClick += dgvstudent_CellContentClick;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(186, 175);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(45, 15);
            lblgender.TabIndex = 10;
            lblgender.Text = "Gender";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Location = new Point(287, 167);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(169, 23);
            cmbgender.TabIndex = 11;
            // 
            // Studentform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbgender);
            Controls.Add(lblgender);
            Controls.Add(dgvstudent);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(lblage);
            Controls.Add(txtage);
            Controls.Add(txtaddress);
            Controls.Add(lbladress);
            Controls.Add(txtstudentname);
            Controls.Add(lblStudentname);
            Name = "Studentform";
            Text = "Studentform";
            ((System.ComponentModel.ISupportInitialize)dgvstudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentname;
        private TextBox txtstudentname;
        private Label lbladress;
        private TextBox txtaddress;
        private TextBox txtage;
        private Label lblage;
        private Button btnadd;
        private Button btnedit;
        private Button btndelete;
        private DataGridView dgvstudent;
        private Label lblgender;
        private ComboBox cmbgender;
    }
}