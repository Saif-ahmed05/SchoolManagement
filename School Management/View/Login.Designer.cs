namespace schoolmenagment
{
    partial class Login
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
            label2 = new Label();
            txtname = new TextBox();
            txtpassword = new TextBox();
            btblogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(146, 150);
            lblname.Name = "lblname";
            lblname.Size = new Size(60, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 209);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Pasword";
            // 
            // txtname
            // 
            txtname.Location = new Point(248, 150);
            txtname.Name = "txtname";
            txtname.Size = new Size(263, 23);
            txtname.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(248, 201);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(259, 23);
            txtpassword.TabIndex = 3;
            // 
            // btblogin
            // 
            btblogin.Location = new Point(326, 298);
            btblogin.Name = "btblogin";
            btblogin.Size = new Size(75, 23);
            btblogin.TabIndex = 4;
            btblogin.Text = "Login";
            btblogin.UseVisualStyleBackColor = true;
            btblogin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 29);
            label1.Name = "label1";
            label1.Size = new Size(598, 25);
            label1.TabIndex = 5;
            label1.Text = "Welcome to UnicomTic School Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btblogin);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(lblname);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label label2;
        private TextBox txtname;
        private TextBox txtpassword;
        private Button btblogin;
        private Label label1;
    }
}