namespace CollegeManagementSystem
{
    partial class Login_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_forgot_password = new System.Windows.Forms.Label();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_lbl = new System.Windows.Forms.Label();
            this.show_hide_password = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_hide_password)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lbl_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 60);
            this.panel2.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(103, 16);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(75, 25);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(9, 83);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 18);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_email
            // 
            this.txtbox_email.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_email.Location = new System.Drawing.Point(12, 104);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(259, 20);
            this.txtbox_email.TabIndex = 1;
            this.txtbox_email.Text = "email";
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_password.Location = new System.Drawing.Point(12, 165);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(259, 22);
            this.txtbox_password.TabIndex = 2;
            this.txtbox_password.Text = "password";
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(9, 144);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(85, 18);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(12, 255);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(259, 25);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_forgot_password
            // 
            this.lbl_forgot_password.AutoSize = true;
            this.lbl_forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgot_password.ForeColor = System.Drawing.Color.Blue;
            this.lbl_forgot_password.Location = new System.Drawing.Point(180, 188);
            this.lbl_forgot_password.Name = "lbl_forgot_password";
            this.lbl_forgot_password.Size = new System.Drawing.Size(91, 13);
            this.lbl_forgot_password.TabIndex = 7;
            this.lbl_forgot_password.Text = "Forgot password?";
            this.lbl_forgot_password.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.ForeColor = System.Drawing.Color.Blue;
            this.lbl_register.Location = new System.Drawing.Point(180, 222);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(53, 15);
            this.lbl_register.TabIndex = 10;
            this.lbl_register.Text = "Register";
            this.lbl_register.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_lbl
            // 
            this.lbl_lbl.AutoSize = true;
            this.lbl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lbl.Location = new System.Drawing.Point(49, 222);
            this.lbl_lbl.Name = "lbl_lbl";
            this.lbl_lbl.Size = new System.Drawing.Size(135, 15);
            this.lbl_lbl.TabIndex = 11;
            this.lbl_lbl.Text = "Don\'t have an account?";
            // 
            // show_hide_password
            // 
            this.show_hide_password.Image = global::CollegeManagementSystem.Properties.Resources.visibility;
            this.show_hide_password.Location = new System.Drawing.Point(250, 166);
            this.show_hide_password.Name = "show_hide_password";
            this.show_hide_password.Size = new System.Drawing.Size(20, 20);
            this.show_hide_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_hide_password.TabIndex = 12;
            this.show_hide_password.TabStop = false;
            this.show_hide_password.Click += new System.EventHandler(this.show_hide_password_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CollegeManagementSystem.Properties.Resources._4957136;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(286, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 292);
            this.panel1.TabIndex = 0;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 292);
            this.Controls.Add(this.show_hide_password);
            this.Controls.Add(this.lbl_lbl);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.lbl_forgot_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_hide_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_forgot_password;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_lbl;
        private System.Windows.Forms.PictureBox show_hide_password;


    }
}