namespace CollegeManagementSystem.Components
{
    partial class Department_Component
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
            this.label7 = new System.Windows.Forms.Label();
            this.arrow_back = new System.Windows.Forms.PictureBox();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_delete = new System.Windows.Forms.Label();
            this.lbl_edit = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_edit = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_delete = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_back = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(480, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 92;
            this.label7.Text = "Department List";
            // 
            // arrow_back
            // 
            this.arrow_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.arrow_back.Image = global::CollegeManagementSystem.Properties.Resources.arrow_left;
            this.arrow_back.InitialImage = global::CollegeManagementSystem.Properties.Resources.arrow_left;
            this.arrow_back.Location = new System.Drawing.Point(113, 432);
            this.arrow_back.Name = "arrow_back";
            this.arrow_back.Size = new System.Drawing.Size(19, 19);
            this.arrow_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow_back.TabIndex = 91;
            this.arrow_back.TabStop = false;
            this.arrow_back.Click += new System.EventHandler(this.arrow_back_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.White;
            this.lbl_back.Location = new System.Drawing.Point(130, 432);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(48, 19);
            this.lbl_back.TabIndex = 85;
            this.lbl_back.Text = " Back";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // lbl_delete
            // 
            this.lbl_delete.AutoSize = true;
            this.lbl_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.ForeColor = System.Drawing.Color.White;
            this.lbl_delete.Location = new System.Drawing.Point(214, 403);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(54, 19);
            this.lbl_delete.TabIndex = 84;
            this.lbl_delete.Text = "Delete";
            this.lbl_delete.Click += new System.EventHandler(this.lbl_delete_Click);
            // 
            // lbl_edit
            // 
            this.lbl_edit.AutoSize = true;
            this.lbl_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit.ForeColor = System.Drawing.Color.White;
            this.lbl_edit.Location = new System.Drawing.Point(129, 403);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(36, 19);
            this.lbl_edit.TabIndex = 83;
            this.lbl_edit.Text = "Edit";
            this.lbl_edit.Click += new System.EventHandler(this.lbl_edit_Click);
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.ForeColor = System.Drawing.Color.White;
            this.lbl_add.Location = new System.Drawing.Point(33, 403);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(36, 19);
            this.lbl_add.TabIndex = 81;
            this.lbl_add.Text = "Add";
            this.lbl_add.Click += new System.EventHandler(this.lbl_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 298);
            this.dataGridView1.TabIndex = 90;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(253, 21);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(348, 31);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "College Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_heading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 104);
            this.panel1.TabIndex = 71;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_add.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(7, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(89, 23);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_edit.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.Location = new System.Drawing.Point(99, 401);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(89, 23);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.Location = new System.Drawing.Point(195, 401);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 23);
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_back.BorderColor = System.Drawing.Color.Transparent;
            this.btn_back.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.Location = new System.Drawing.Point(7, 430);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(281, 23);
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btn_back,
            this.btn_delete,
            this.btn_edit,
            this.btn_add});
            this.shapeContainer1.Size = new System.Drawing.Size(864, 467);
            this.shapeContainer1.TabIndex = 93;
            this.shapeContainer1.TabStop = false;
            // 
            // txt_dept
            // 
            this.txt_dept.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_dept.Location = new System.Drawing.Point(127, 268);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(162, 22);
            this.txt_dept.TabIndex = 96;
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.ForeColor = System.Drawing.Color.Black;
            this.lbl_dept.Location = new System.Drawing.Point(9, 270);
            this.lbl_dept.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(60, 18);
            this.lbl_dept.TabIndex = 99;
            this.lbl_dept.Text = "Dept :";
            this.lbl_dept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.Control;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_description.Location = new System.Drawing.Point(127, 229);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(162, 22);
            this.txt_description.TabIndex = 95;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Black;
            this.lbl_description.Location = new System.Drawing.Point(9, 231);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(115, 18);
            this.lbl_description.TabIndex = 98;
            this.lbl_description.Text = "Description :";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(127, 194);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 20);
            this.txt_name.TabIndex = 94;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(9, 196);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 18);
            this.lbl_name.TabIndex = 97;
            this.lbl_name.Text = "Name :";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.txt_dept);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrow_back);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_delete);
            this.Controls.Add(this.lbl_edit);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department_Component";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments_Component";
            ((System.ComponentModel.ISupportInitialize)(this.arrow_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox arrow_back;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_delete;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_add;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_edit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_delete;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_back;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
    }
}