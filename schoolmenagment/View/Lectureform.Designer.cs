namespace schoolmenagment.View
{
    partial class Lectureform
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
            lblname = new Label();
            txtname = new TextBox();
            lblage = new Label();
            lbladress = new Label();
            txtadress = new TextBox();
            txtage = new TextBox();
            btnadd = new Button();
            btnedit = new Button();
            btndelete = new Button();
            dgvlecture = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvlecture).BeginInit();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(137, 37);
            lblname.Name = "lblname";
            lblname.Size = new Size(84, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Lectrue Name ";
            // 
            // txtname
            // 
            txtname.Location = new Point(279, 29);
            txtname.Name = "txtname";
            txtname.Size = new Size(193, 23);
            txtname.TabIndex = 1;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(193, 135);
            lblage.Name = "lblage";
            lblage.Size = new Size(28, 15);
            lblage.TabIndex = 2;
            lblage.Text = "Age";
            // 
            // lbladress
            // 
            lbladress.AutoSize = true;
            lbladress.Location = new Point(179, 87);
            lbladress.Name = "lbladress";
            lbladress.Size = new Size(42, 15);
            lbladress.TabIndex = 3;
            lbladress.Text = "Adress";
            // 
            // txtadress
            // 
            txtadress.Location = new Point(279, 84);
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(193, 23);
            txtadress.TabIndex = 4;
            // 
            // txtage
            // 
            txtage.Location = new Point(279, 135);
            txtage.Name = "txtage";
            txtage.Size = new Size(193, 23);
            txtage.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(179, 201);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(302, 201);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 7;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(442, 201);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 8;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dgvlecture
            // 
            dgvlecture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlecture.Location = new Point(179, 253);
            dgvlecture.Name = "dgvlecture";
            dgvlecture.Size = new Size(338, 150);
            dgvlecture.TabIndex = 9;
            dgvlecture.CellContentClick += dgvlecture_CellContentClick;
            // 
            // Lectureform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvlecture);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(txtage);
            Controls.Add(txtadress);
            Controls.Add(lbladress);
            Controls.Add(lblage);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Name = "Lectureform";
            Text = "Lectureform";
            ((System.ComponentModel.ISupportInitialize)dgvlecture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private Label lblage;
        private Label lbladress;
        private TextBox txtadress;
        private TextBox txtage;
        private Button btnadd;
        private Button btnedit;
        private Button btndelete;
        private DataGridView dgvlecture;
    }
}