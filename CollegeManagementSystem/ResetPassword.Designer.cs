namespace CollegeManagementSystem
{
    partial class ResetPassword_Form
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
            this.btn_reset_password = new System.Windows.Forms.Button();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_reset_password = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reset_password
            // 
            this.btn_reset_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(53)))));
            this.btn_reset_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset_password.Location = new System.Drawing.Point(11, 203);
            this.btn_reset_password.Name = "btn_reset_password";
            this.btn_reset_password.Size = new System.Drawing.Size(242, 25);
            this.btn_reset_password.TabIndex = 27;
            this.btn_reset_password.Text = "Reset Password";
            this.btn_reset_password.UseVisualStyleBackColor = false;
            this.btn_reset_password.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_password.Location = new System.Drawing.Point(11, 158);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(242, 20);
            this.txtbox_password.TabIndex = 25;
            this.txtbox_password.Text = "new password";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(8, 137);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(126, 18);
            this.lbl_password.TabIndex = 31;
            this.lbl_password.Text = "New Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reset_password
            // 
            this.lbl_reset_password.AutoSize = true;
            this.lbl_reset_password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reset_password.ForeColor = System.Drawing.Color.White;
            this.lbl_reset_password.Location = new System.Drawing.Point(41, 18);
            this.lbl_reset_password.Name = "lbl_reset_password";
            this.lbl_reset_password.Size = new System.Drawing.Size(176, 25);
            this.lbl_reset_password.TabIndex = 1;
            this.lbl_reset_password.Text = "Reset Password";
            this.lbl_reset_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_email
            // 
            this.txtbox_email.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_email.Location = new System.Drawing.Point(11, 97);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(242, 20);
            this.txtbox_email.TabIndex = 24;
            this.txtbox_email.Text = "email";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(8, 76);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 18);
            this.lbl_email.TabIndex = 30;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.lbl_reset_password);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 60);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.Feb_Business_9;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(264, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 241);
            this.panel1.TabIndex = 28;
            // 
            // ResetPassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 241);
            this.Controls.Add(this.btn_reset_password);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset_password;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_reset_password;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

    }
}