namespace schoolmenagment.View
{
    partial class Userform
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
            lblusername = new Label();
            txtusername = new TextBox();
            lblpassword = new Label();
            txtpassword = new TextBox();
            lblrole = new Label();
            cmbrole = new ComboBox();
            btnadduser = new Button();
            btnupdateuser = new Button();
            btndeleteuser = new Button();
            dataGridView1 = new DataGridView();
            lblmassage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(127, 20);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(60, 15);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(244, 17);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(220, 23);
            txtusername.TabIndex = 1;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(130, 61);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(57, 15);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(244, 53);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(220, 23);
            txtpassword.TabIndex = 3;
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Location = new Point(144, 105);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(30, 15);
            lblrole.TabIndex = 4;
            lblrole.Text = "Role";
            // 
            // cmbrole
            // 
            cmbrole.FormattingEnabled = true;
            cmbrole.Location = new Point(244, 102);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(220, 23);
            cmbrole.TabIndex = 5;
            // 
            // btnadduser
            // 
            btnadduser.Location = new Point(99, 167);
            btnadduser.Name = "btnadduser";
            btnadduser.Size = new Size(75, 23);
            btnadduser.TabIndex = 6;
            btnadduser.Text = "Add";
            btnadduser.UseVisualStyleBackColor = true;
            // 
            // btnupdateuser
            // 
            btnupdateuser.Location = new Point(244, 167);
            btnupdateuser.Name = "btnupdateuser";
            btnupdateuser.Size = new Size(75, 23);
            btnupdateuser.TabIndex = 7;
            btnupdateuser.Text = "Update";
            btnupdateuser.UseVisualStyleBackColor = true;
            // 
            // btndeleteuser
            // 
            btndeleteuser.Location = new Point(404, 167);
            btndeleteuser.Name = "btndeleteuser";
            btndeleteuser.Size = new Size(75, 23);
            btndeleteuser.TabIndex = 8;
            btndeleteuser.Text = "Delete";
            btndeleteuser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(403, 187);
            dataGridView1.TabIndex = 9;
            // 
            // lblmassage
            // 
            lblmassage.AutoSize = true;
            lblmassage.Location = new Point(645, 346);
            lblmassage.Name = "lblmassage";
            lblmassage.Size = new Size(38, 15);
            lblmassage.TabIndex = 10;
            lblmassage.Text = "label1";
            // 
            // Userform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmassage);
            Controls.Add(dataGridView1);
            Controls.Add(btndeleteuser);
            Controls.Add(btnupdateuser);
            Controls.Add(btnadduser);
            Controls.Add(cmbrole);
            Controls.Add(lblrole);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(txtusername);
            Controls.Add(lblusername);
            Name = "Userform";
            Text = "Userform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private TextBox txtusername;
        private Label lblpassword;
        private TextBox txtpassword;
        private Label lblrole;
        private ComboBox cmbrole;
        private Button btnadduser;
        private Button btnupdateuser;
        private Button btndeleteuser;
        private DataGridView dataGridView1;
        private Label lblmassage;
    }
}