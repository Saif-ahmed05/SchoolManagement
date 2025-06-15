namespace schoolmenagment
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
            lblstudent = new Label();
            txtname = new TextBox();
            lblcoures = new Label();
            cmbcoures = new ComboBox();
            btnaddstudent = new Button();
            btneditstudent = new Button();
            btndeletestudent = new Button();
            dgvstudents = new DataGridView();
            lbladdress = new Label();
            txtaddress = new TextBox();
            lblage = new Label();
            txtage = new TextBox();
            lblgennder = new Label();
            cmbgender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvstudents).BeginInit();
            SuspendLayout();
            // 
            // lblstudent
            // 
            lblstudent.AutoSize = true;
            lblstudent.Location = new Point(69, 38);
            lblstudent.Name = "lblstudent";
            lblstudent.Size = new Size(83, 15);
            lblstudent.TabIndex = 0;
            lblstudent.Text = "Student Name";
            // 
            // txtname
            // 
            txtname.Location = new Point(195, 35);
            txtname.Name = "txtname";
            txtname.Size = new Size(316, 23);
            txtname.TabIndex = 1;
            // 
            // lblcoures
            // 
            lblcoures.AutoSize = true;
            lblcoures.Location = new Point(85, 164);
            lblcoures.Name = "lblcoures";
            lblcoures.Size = new Size(44, 15);
            lblcoures.TabIndex = 2;
            lblcoures.Text = "Coures";
            // 
            // cmbcoures
            // 
            cmbcoures.FormattingEnabled = true;
            cmbcoures.Location = new Point(195, 164);
            cmbcoures.Name = "cmbcoures";
            cmbcoures.Size = new Size(121, 23);
            cmbcoures.TabIndex = 3;
            cmbcoures.SelectedIndexChanged += cmbcoures_SelectedIndexChanged;
            // 
            // btnaddstudent
            // 
            btnaddstudent.Location = new Point(710, 225);
            btnaddstudent.Name = "btnaddstudent";
            btnaddstudent.Size = new Size(75, 23);
            btnaddstudent.TabIndex = 4;
            btnaddstudent.Text = "Add";
            btnaddstudent.UseVisualStyleBackColor = true;
            btnaddstudent.Click += btnaddstudent_Click;
            // 
            // btneditstudent
            // 
            btneditstudent.Location = new Point(713, 309);
            btneditstudent.Name = "btneditstudent";
            btneditstudent.Size = new Size(75, 23);
            btneditstudent.TabIndex = 5;
            btneditstudent.Text = "Edit";
            btneditstudent.UseVisualStyleBackColor = true;
            btneditstudent.Click += btneditstudent_Click;
            // 
            // btndeletestudent
            // 
            btndeletestudent.Location = new Point(713, 388);
            btndeletestudent.Name = "btndeletestudent";
            btndeletestudent.Size = new Size(75, 23);
            btndeletestudent.TabIndex = 6;
            btndeletestudent.Text = "Delete";
            btndeletestudent.UseVisualStyleBackColor = true;
            btndeletestudent.Click += btndeletestudent_Click;
            // 
            // dgvstudents
            // 
            dgvstudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstudents.Location = new Point(328, 225);
            dgvstudents.Name = "dgvstudents";
            dgvstudents.Size = new Size(376, 204);
            dgvstudents.TabIndex = 7;
            dgvstudents.CellContentClick += dgvstudents_CellContentClick;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new Point(80, 79);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(49, 15);
            lbladdress.TabIndex = 8;
            lbladdress.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(195, 76);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(316, 23);
            txtaddress.TabIndex = 9;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(91, 116);
            lblage.Name = "lblage";
            lblage.Size = new Size(28, 15);
            lblage.TabIndex = 10;
            lblage.Text = "Age";
            // 
            // txtage
            // 
            txtage.Location = new Point(195, 116);
            txtage.Name = "txtage";
            txtage.Size = new Size(326, 23);
            txtage.TabIndex = 11;
            // 
            // lblgennder
            // 
            lblgennder.AutoSize = true;
            lblgennder.Location = new Point(91, 206);
            lblgennder.Name = "lblgennder";
            lblgennder.Size = new Size(45, 15);
            lblgennder.TabIndex = 12;
            lblgennder.Text = "Gender";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Location = new Point(195, 206);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(121, 23);
            cmbgender.TabIndex = 13;
            // 
            // Studentform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbgender);
            Controls.Add(lblgennder);
            Controls.Add(txtage);
            Controls.Add(lblage);
            Controls.Add(txtaddress);
            Controls.Add(lbladdress);
            Controls.Add(dgvstudents);
            Controls.Add(btndeletestudent);
            Controls.Add(btneditstudent);
            Controls.Add(btnaddstudent);
            Controls.Add(cmbcoures);
            Controls.Add(lblcoures);
            Controls.Add(txtname);
            Controls.Add(lblstudent);
            Name = "Studentform";
            Text = "Studentform";
            Load += Studentform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvstudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudent;
        private TextBox txtname;
        private Label lblcoures;
        private ComboBox cmbcoures;
        private Button btnaddstudent;
        private Button btneditstudent;
        private Button btndeletestudent;
        private DataGridView dgvstudents;
        private Label lbladdress;
        private TextBox txtaddress;
        private Label lblage;
        private TextBox txtage;
        private Label lblgennder;
        private ComboBox cmbgender;
    }
}