namespace CollegeManagementSystem
{
    partial class Registration_Form
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
            this.lbl_lbl = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_register = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lbl
            // 
            this.lbl_lbl.AutoSize = true;
            this.lbl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lbl.Location = new System.Drawing.Point(48, 268);
            this.lbl_lbl.Name = "lbl_lbl";
            this.lbl_lbl.Size = new System.Drawing.Size(146, 15);
            this.lbl_lbl.TabIndex = 21;
            this.lbl_lbl.Text = "Already have an account?";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_login.Location = new System.Drawing.Point(190, 268);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(38, 15);
            this.lbl_login.TabIndex = 20;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register.Location = new System.Drawing.Point(12, 301);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(259, 25);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_password.Location = new System.Drawing.Point(12, 165);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(259, 20);
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
            this.lbl_password.TabIndex = 17;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(9, 83);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 18);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.ForeColor = System.Drawing.Color.White;
            this.lbl_register.Location = new System.Drawing.Point(93, 16);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(99, 25);
            this.lbl_register.TabIndex = 1;
            this.lbl_register.Text = "Register";
            this.lbl_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lbl_register);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 60);
            this.panel2.TabIndex = 14;
            // 
            // txtbox_confirm_password
            // 
            this.txtbox_confirm_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_confirm_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_confirm_password.Location = new System.Drawing.Point(12, 230);
            this.txtbox_confirm_password.Name = "txtbox_confirm_password";
            this.txtbox_confirm_password.Size = new System.Drawing.Size(259, 20);
            this.txtbox_confirm_password.TabIndex = 3;
            this.txtbox_confirm_password.Text = "confirm password";
            this.txtbox_confirm_password.UseSystemPasswordChar = true;
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_confirm_password.Location = new System.Drawing.Point(9, 209);
            this.lbl_confirm_password.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(159, 18);
            this.lbl_confirm_password.TabIndex = 23;
            this.lbl_confirm_password.Text = "Confirm password";
            this.lbl_confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.Mobile_login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 339);
            this.panel1.TabIndex = 12;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 339);
            this.Controls.Add(this.txtbox_confirm_password);
            this.Controls.Add(this.lbl_confirm_password);
            this.Controls.Add(this.lbl_lbl);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lbl;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_confirm_password;
        private System.Windows.Forms.Label lbl_confirm_password;

    }
}