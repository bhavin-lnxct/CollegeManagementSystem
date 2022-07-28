namespace CollegeManagementSystem
{
    partial class Home_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_departments = new System.Windows.Forms.Label();
            this.lbl_fees = new System.Windows.Forms.Label();
            this.lbl_users = new System.Windows.Forms.Label();
            this.lbl_teachers = new System.Windows.Forms.Label();
            this.lbl_students = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btn_dashboard = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_logout = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_fees = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btn_users = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btn_students = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btn_teachers = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btn_departments = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbl_heading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 80);
            this.panel1.TabIndex = 0;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(156, 25);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(348, 31);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "College Management System";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.kimberly_farmer_lUaaKCUANVI_unsplash;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_dashboard);
            this.panel2.Controls.Add(this.lbl_logout);
            this.panel2.Controls.Add(this.lbl_departments);
            this.panel2.Controls.Add(this.lbl_fees);
            this.panel2.Controls.Add(this.lbl_users);
            this.panel2.Controls.Add(this.lbl_teachers);
            this.panel2.Controls.Add(this.lbl_students);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 381);
            this.panel2.TabIndex = 1;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_dashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(390, 349);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(85, 19);
            this.lbl_dashboard.TabIndex = 6;
            this.lbl_dashboard.Text = "DashBoard";
            this.lbl_dashboard.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.White;
            this.lbl_logout.Location = new System.Drawing.Point(221, 348);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(56, 19);
            this.lbl_logout.TabIndex = 5;
            this.lbl_logout.Text = "Logout";
            this.lbl_logout.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_departments
            // 
            this.lbl_departments.AutoSize = true;
            this.lbl_departments.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_departments.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departments.ForeColor = System.Drawing.Color.White;
            this.lbl_departments.Location = new System.Drawing.Point(77, 271);
            this.lbl_departments.Name = "lbl_departments";
            this.lbl_departments.Size = new System.Drawing.Size(117, 24);
            this.lbl_departments.TabIndex = 4;
            this.lbl_departments.Text = "Department";
            // 
            // lbl_fees
            // 
            this.lbl_fees.AutoSize = true;
            this.lbl_fees.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_fees.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fees.ForeColor = System.Drawing.Color.White;
            this.lbl_fees.Location = new System.Drawing.Point(515, 253);
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.Size = new System.Drawing.Size(52, 24);
            this.lbl_fees.TabIndex = 3;
            this.lbl_fees.Text = "Fees";
            // 
            // lbl_users
            // 
            this.lbl_users.AutoSize = true;
            this.lbl_users.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_users.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users.ForeColor = System.Drawing.Color.White;
            this.lbl_users.Location = new System.Drawing.Point(508, 78);
            this.lbl_users.Name = "lbl_users";
            this.lbl_users.Size = new System.Drawing.Size(59, 24);
            this.lbl_users.TabIndex = 2;
            this.lbl_users.Text = "Users";
            // 
            // lbl_teachers
            // 
            this.lbl_teachers.AutoSize = true;
            this.lbl_teachers.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_teachers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teachers.ForeColor = System.Drawing.Color.White;
            this.lbl_teachers.Location = new System.Drawing.Point(297, 162);
            this.lbl_teachers.Name = "lbl_teachers";
            this.lbl_teachers.Size = new System.Drawing.Size(89, 24);
            this.lbl_teachers.TabIndex = 2;
            this.lbl_teachers.Text = "Teachers";
            // 
            // lbl_students
            // 
            this.lbl_students.AutoSize = true;
            this.lbl_students.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_students.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_students.ForeColor = System.Drawing.Color.White;
            this.lbl_students.Location = new System.Drawing.Point(95, 79);
            this.lbl_students.Name = "lbl_students";
            this.lbl_students.Size = new System.Drawing.Size(87, 24);
            this.lbl_students.TabIndex = 1;
            this.lbl_students.Text = "Students";
            this.lbl_students.Click += new System.EventHandler(this.label2_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btn_dashboard,
            this.btn_logout,
            this.btn_fees,
            this.btn_users,
            this.btn_students,
            this.btn_teachers,
            this.btn_departments});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 381);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_dashboard.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_dashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_dashboard.Location = new System.Drawing.Point(382, 347);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(100, 23);
            this.btn_dashboard.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_logout.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_logout.BorderColor = System.Drawing.Color.Transparent;
            this.btn_logout.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_logout.Location = new System.Drawing.Point(205, 346);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(89, 23);
            this.btn_logout.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // btn_fees
            // 
            this.btn_fees.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_fees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fees.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_fees.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_fees.Location = new System.Drawing.Point(479, 203);
            this.btn_fees.Name = "btn_fees";
            this.btn_fees.Size = new System.Drawing.Size(122, 122);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_users.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_users.Location = new System.Drawing.Point(476, 29);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(122, 122);
            // 
            // btn_students
            // 
            this.btn_students.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_students.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_students.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_students.Location = new System.Drawing.Point(76, 29);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(122, 122);
            this.btn_students.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // btn_teachers
            // 
            this.btn_teachers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teachers.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_teachers.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_teachers.Location = new System.Drawing.Point(281, 113);
            this.btn_teachers.Name = "btn_teachers";
            this.btn_teachers.Size = new System.Drawing.Size(122, 122);
            // 
            // btn_departments
            // 
            this.btn_departments.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_departments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_departments.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_departments.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_departments.Location = new System.Drawing.Point(74, 221);
            this.btn_departments.Name = "btn_departments";
            this.btn_departments.Size = new System.Drawing.Size(122, 122);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Home";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbl_students;
        private Microsoft.VisualBasic.PowerPacks.OvalShape btn_departments;
        private System.Windows.Forms.Label lbl_fees;
        private System.Windows.Forms.Label lbl_users;
        private System.Windows.Forms.Label lbl_teachers;
        private System.Windows.Forms.Label lbl_departments;
        private Microsoft.VisualBasic.PowerPacks.OvalShape btn_fees;
        private Microsoft.VisualBasic.PowerPacks.OvalShape btn_users;
        private Microsoft.VisualBasic.PowerPacks.OvalShape btn_students;
        private Microsoft.VisualBasic.PowerPacks.OvalShape btn_teachers;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_logout;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_dashboard;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_dashboard;

    }
}