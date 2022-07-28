namespace CollegeManagementSystem
{
    partial class Loading_Form
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
            this.components = new System.ComponentModel.Container();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_dots = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(83, 19);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(329, 29);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "College Management System";
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.White;
            this.lbl_version.Location = new System.Drawing.Point(323, 48);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(89, 20);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "Version 1.0";
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.progressbar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressbar.ForeColor = System.Drawing.Color.GhostWhite;
            this.progressbar.Location = new System.Drawing.Point(0, 210);
            this.progressbar.Margin = new System.Windows.Forms.Padding(0);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(500, 12);
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar.TabIndex = 2;
            this.progressbar.UseWaitCursor = true;
            // 
            // lbl_loading
            // 
            this.lbl_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.White;
            this.lbl_loading.Location = new System.Drawing.Point(188, 168);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(78, 24);
            this.lbl_loading.TabIndex = 3;
            this.lbl_loading.Text = "Loading";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_dots
            // 
            this.lbl_dots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dots.AutoSize = true;
            this.lbl_dots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dots.ForeColor = System.Drawing.Color.White;
            this.lbl_dots.Location = new System.Drawing.Point(263, 168);
            this.lbl_dots.Name = "lbl_dots";
            this.lbl_dots.Size = new System.Drawing.Size(0, 24);
            this.lbl_dots.TabIndex = 4;
            this.lbl_dots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Loading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.Controls.Add(this.lbl_dots);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_heading);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_dots;
    }
}

