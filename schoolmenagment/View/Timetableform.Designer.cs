namespace schoolmenagment.View
{
    partial class Timetableform
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
            lblsubject = new Label();
            cmbsubject = new ComboBox();
            lbltimeslot = new Label();
            txttimeslot = new TextBox();
            lblroom = new Label();
            txtroom = new ComboBox();
            btnadd = new Button();
            dgvtimetable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvtimetable).BeginInit();
            SuspendLayout();
            // 
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(55, 9);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(46, 15);
            lblsubject.TabIndex = 0;
            lblsubject.Text = "Subject";
            // 
            // cmbsubject
            // 
            cmbsubject.FormattingEnabled = true;
            cmbsubject.Location = new Point(136, 6);
            cmbsubject.Name = "cmbsubject";
            cmbsubject.Size = new Size(121, 23);
            cmbsubject.TabIndex = 1;
            // 
            // lbltimeslot
            // 
            lbltimeslot.AutoSize = true;
            lbltimeslot.Location = new Point(55, 41);
            lbltimeslot.Name = "lbltimeslot";
            lbltimeslot.Size = new Size(57, 15);
            lbltimeslot.TabIndex = 2;
            lbltimeslot.Text = "Time Slot";
            // 
            // txttimeslot
            // 
            txttimeslot.Location = new Point(136, 35);
            txttimeslot.Name = "txttimeslot";
            txttimeslot.Size = new Size(121, 23);
            txttimeslot.TabIndex = 3;
            // 
            // lblroom
            // 
            lblroom.AutoSize = true;
            lblroom.Location = new Point(63, 73);
            lblroom.Name = "lblroom";
            lblroom.Size = new Size(39, 15);
            lblroom.TabIndex = 4;
            lblroom.Text = "Room";
            // 
            // txtroom
            // 
            txtroom.FormattingEnabled = true;
            txtroom.Location = new Point(136, 65);
            txtroom.Name = "txtroom";
            txtroom.Size = new Size(121, 23);
            txtroom.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(136, 113);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // dgvtimetable
            // 
            dgvtimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtimetable.Location = new Point(63, 172);
            dgvtimetable.Name = "dgvtimetable";
            dgvtimetable.Size = new Size(307, 191);
            dgvtimetable.TabIndex = 7;
            // 
            // Timetableform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvtimetable);
            Controls.Add(btnadd);
            Controls.Add(txtroom);
            Controls.Add(lblroom);
            Controls.Add(txttimeslot);
            Controls.Add(lbltimeslot);
            Controls.Add(cmbsubject);
            Controls.Add(lblsubject);
            Name = "Timetableform";
            Text = "Timetableform";
            ((System.ComponentModel.ISupportInitialize)dgvtimetable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsubject;
        private ComboBox cmbsubject;
        private Label lbltimeslot;
        private TextBox txttimeslot;
        private Label lblroom;
        private ComboBox txtroom;
        private Button btnadd;
        private DataGridView dgvtimetable;
    }
}