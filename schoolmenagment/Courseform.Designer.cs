namespace schoolmenagment
{
    partial class Courseform
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
            lblCourse = new Label();
            txtcourse = new TextBox();
            btnadd = new Button();
            dgvcourse = new DataGridView();
            btnedit = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcourse).BeginInit();
            SuspendLayout();
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(125, 102);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(79, 15);
            lblCourse.TabIndex = 0;
            lblCourse.Text = "Course Name";
            // 
            // txtcourse
            // 
            txtcourse.Location = new Point(256, 102);
            txtcourse.Name = "txtcourse";
            txtcourse.Size = new Size(233, 23);
            txtcourse.TabIndex = 1;
            txtcourse.TextChanged += txtcourse_TextChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(109, 182);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 2;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dgvcourse
            // 
            dgvcourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcourse.Location = new Point(221, 225);
            dgvcourse.Name = "dgvcourse";
            dgvcourse.Size = new Size(131, 161);
            dgvcourse.TabIndex = 5;
            dgvcourse.CellContentClick += dgvcourse_CellContentClick;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(256, 182);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 6;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(451, 182);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 7;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Courseform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(dgvcourse);
            Controls.Add(btnadd);
            Controls.Add(txtcourse);
            Controls.Add(lblCourse);
            Name = "Courseform";
            Text = "Courseform";
            Load += Courseform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourse;
        private TextBox txtcourse;
        private Button btnadd;
        private DataGridView dgvcourse;
        private Button btnedit;
        private Button btndelete;
    }
}