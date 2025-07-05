    namespace schoolmenagment
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblwelcom = new Label();
            panel1 = new Panel();
            btnlecture = new Button();
            btnroom = new Button();
            btnlogout = new Button();
            btntimetable = new Button();
            btnmarks = new Button();
            btnexams = new Button();
            btnstudents = new Button();
            btncoures = new Button();
            btnuser = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblwelcom
            // 
            lblwelcom.AutoSize = true;
            lblwelcom.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcom.Location = new Point(344, 12);
            lblwelcom.Name = "lblwelcom";
            lblwelcom.Size = new Size(316, 86);
            lblwelcom.TabIndex = 0;
            lblwelcom.Text = "Welcome";
            lblwelcom.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnuser);
            panel1.Controls.Add(btnlecture);
            panel1.Controls.Add(btnroom);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btntimetable);
            panel1.Controls.Add(btnmarks);
            panel1.Controls.Add(btnexams);
            panel1.Controls.Add(btnstudents);
            panel1.Controls.Add(btncoures);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 445);
            panel1.TabIndex = 1;
            // 
            // btnlecture
            // 
            btnlecture.Location = new Point(45, 314);
            btnlecture.Name = "btnlecture";
            btnlecture.Size = new Size(75, 23);
            btnlecture.TabIndex = 7;
            btnlecture.Text = "Lecture";
            btnlecture.UseVisualStyleBackColor = true;
            btnlecture.Click += btnlecture_Click;
            // 
            // btnroom
            // 
            btnroom.Location = new Point(45, 262);
            btnroom.Name = "btnroom";
            btnroom.Size = new Size(75, 23);
            btnroom.TabIndex = 6;
            btnroom.Text = "Room";
            btnroom.UseVisualStyleBackColor = true;
            btnroom.Click += btnroom_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(109, 419);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(75, 23);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btntimetable
            // 
            btntimetable.Location = new Point(45, 212);
            btntimetable.Name = "btntimetable";
            btntimetable.Size = new Size(75, 23);
            btntimetable.TabIndex = 4;
            btntimetable.Text = "Time Table";
            btntimetable.UseVisualStyleBackColor = true;
            btntimetable.Click += btntimetable_Click;
            // 
            // btnmarks
            // 
            btnmarks.Location = new Point(45, 152);
            btnmarks.Name = "btnmarks";
            btnmarks.Size = new Size(75, 23);
            btnmarks.TabIndex = 3;
            btnmarks.Text = "Marks";
            btnmarks.UseVisualStyleBackColor = true;
            btnmarks.Click += btnmarks_Click;
            // 
            // btnexams
            // 
            btnexams.Location = new Point(45, 100);
            btnexams.Name = "btnexams";
            btnexams.Size = new Size(75, 23);
            btnexams.TabIndex = 2;
            btnexams.Text = "Exams";
            btnexams.UseVisualStyleBackColor = true;
            btnexams.Click += btnexams_Click;
            // 
            // btnstudents
            // 
            btnstudents.Location = new Point(45, 51);
            btnstudents.Name = "btnstudents";
            btnstudents.Size = new Size(75, 23);
            btnstudents.TabIndex = 1;
            btnstudents.Text = "Students";
            btnstudents.UseVisualStyleBackColor = true;
            btnstudents.Click += btnstudents_Click;
            // 
            // btncoures
            // 
            btncoures.Location = new Point(45, 10);
            btncoures.Name = "btncoures";
            btncoures.Size = new Size(75, 23);
            btncoures.TabIndex = 0;
            btncoures.Text = "Course";
            btncoures.UseVisualStyleBackColor = true;
            btncoures.Click += button1_Click;
            // 
            // btnuser
            // 
            btnuser.Location = new Point(45, 370);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(75, 23);
            btnuser.TabIndex = 8;
            btnuser.Text = "user";
            btnuser.UseVisualStyleBackColor = true;
            btnuser.Click += btnuser_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblwelcom);
            Name = "Mainform";
            Text = "Form1";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcom;
        private Panel panel1;
        private Button btncoures;
        private Button btnmarks;
        private Button btnexams;
        private Button btnstudents;
        private Button btnlogout;
        private Button btntimetable;
        private Button btnlecture;
        private Button btnroom;
        private Button btnuser;
    }
}
