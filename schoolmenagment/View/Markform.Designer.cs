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
            lblstudent = new Label();
            cmbstudent = new ComboBox();
            lblexam = new Label();
            cmbexam = new ComboBox();
            lblscore = new Label();
            txtscore = new TextBox();
            btnadd = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblstudent
            // 
            lblstudent.AutoSize = true;
            lblstudent.Location = new Point(202, 24);
            lblstudent.Name = "lblstudent";
            lblstudent.Size = new Size(48, 15);
            lblstudent.TabIndex = 0;
            lblstudent.Text = "Student";
            lblstudent.Click += label1_Click;
            // 
            // cmbstudent
            // 
            cmbstudent.FormattingEnabled = true;
            cmbstudent.Location = new Point(274, 16);
            cmbstudent.Name = "cmbstudent";
            cmbstudent.Size = new Size(121, 23);
            cmbstudent.TabIndex = 1;
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
            btnadd.Location = new Point(295, 143);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(151, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(365, 187);
            dataGridView1.TabIndex = 7;
            // 
            // Markform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnadd);
            Controls.Add(txtscore);
            Controls.Add(lblscore);
            Controls.Add(cmbexam);
            Controls.Add(lblexam);
            Controls.Add(cmbstudent);
            Controls.Add(lblstudent);
            Name = "Markform";
            Text = "Markform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudent;
        private ComboBox cmbstudent;
        private Label lblexam;
        private ComboBox cmbexam;
        private Label lblscore;
        private TextBox txtscore;
        private Button btnadd;
        private DataGridView dataGridView1;
    }
}