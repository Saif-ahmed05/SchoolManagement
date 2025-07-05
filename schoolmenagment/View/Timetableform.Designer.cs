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
            lblcourse = new Label();
            cmbcourse = new ComboBox();
            lbltimeslot = new Label();
            txttimeslot = new TextBox();
            lblroom = new Label();
            cmbroom = new ComboBox();
            btnadd = new Button();
            dgvtimetable = new DataGridView();
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvtimetable).BeginInit();
            SuspendLayout();
            // 
            // lblcourse
            // 
            lblcourse.AutoSize = true;
            lblcourse.Location = new Point(223, 20);
            lblcourse.Name = "lblcourse";
            lblcourse.Size = new Size(44, 15);
            lblcourse.TabIndex = 0;
            lblcourse.Text = "Course";
            // 
            // cmbcourse
            // 
            cmbcourse.FormattingEnabled = true;
            cmbcourse.Location = new Point(289, 12);
            cmbcourse.Name = "cmbcourse";
            cmbcourse.Size = new Size(121, 23);
            cmbcourse.TabIndex = 1;
            // 
            // lbltimeslot
            // 
            lbltimeslot.AutoSize = true;
            lbltimeslot.Location = new Point(210, 58);
            lbltimeslot.Name = "lbltimeslot";
            lbltimeslot.Size = new Size(57, 15);
            lbltimeslot.TabIndex = 2;
            lbltimeslot.Text = "Time Slot";
            // 
            // txttimeslot
            // 
            txttimeslot.Location = new Point(289, 55);
            txttimeslot.Name = "txttimeslot";
            txttimeslot.Size = new Size(121, 23);
            txttimeslot.TabIndex = 3;
            // 
            // lblroom
            // 
            lblroom.AutoSize = true;
            lblroom.Location = new Point(228, 104);
            lblroom.Name = "lblroom";
            lblroom.Size = new Size(39, 15);
            lblroom.TabIndex = 4;
            lblroom.Text = "Room";
            // 
            // cmbroom
            // 
            cmbroom.FormattingEnabled = true;
            cmbroom.Location = new Point(289, 96);
            cmbroom.Name = "cmbroom";
            cmbroom.Size = new Size(121, 23);
            cmbroom.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(210, 155);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dgvtimetable
            // 
            dgvtimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtimetable.Location = new Point(212, 194);
            dgvtimetable.Name = "dgvtimetable";
            dgvtimetable.Size = new Size(307, 191);
            dgvtimetable.TabIndex = 7;
            dgvtimetable.CellContentClick += dgvtimetable_CellContentClick;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(315, 155);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 8;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(420, 155);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 9;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Timetableform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(dgvtimetable);
            Controls.Add(btnadd);
            Controls.Add(cmbroom);
            Controls.Add(lblroom);
            Controls.Add(txttimeslot);
            Controls.Add(lbltimeslot);
            Controls.Add(cmbcourse);
            Controls.Add(lblcourse);
            Name = "Timetableform";
            Text = "Timetableform";
            Load += Timetableform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvtimetable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcourse;
        private ComboBox cmbcourse;
        private Label lbltimeslot;
        private TextBox txttimeslot;
        private Label lblroom;
        private ComboBox cmbroom;
        private Button btnadd;
        private DataGridView dgvtimetable;
        private Button btnedit;
        private Button btndelete;
    }
}