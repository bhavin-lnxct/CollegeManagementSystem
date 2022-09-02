namespace CollegeManagementSystem.Components
{
    partial class Teachers_Component
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
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_fees = new System.Windows.Forms.Label();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_edit = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_delete = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_add = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(480, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Teachers List";
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
            this.arrow_back.TabIndex = 45;
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
            this.lbl_back.TabIndex = 39;
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
            this.lbl_delete.TabIndex = 38;
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
            this.lbl_edit.TabIndex = 37;
            this.lbl_edit.Text = "Edit";
            this.lbl_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.lbl_add.TabIndex = 35;
            this.lbl_add.Text = "Add";
            this.lbl_add.Click += new System.EventHandler(this.lbl_add_Click);
            // 
            // txt_fees
            // 
            this.txt_fees.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_fees.Location = new System.Drawing.Point(94, 331);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(195, 22);
            this.txt_fees.TabIndex = 33;
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
            // lbl_fees
            // 
            this.lbl_fees.AutoSize = true;
            this.lbl_fees.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fees.ForeColor = System.Drawing.Color.Black;
            this.lbl_fees.Location = new System.Drawing.Point(9, 333);
            this.lbl_fees.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.Size = new System.Drawing.Size(57, 18);
            this.lbl_fees.TabIndex = 43;
            this.lbl_fees.Text = "Fees :";
            this.lbl_fees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dept
            // 
            this.txt_dept.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_dept.Location = new System.Drawing.Point(94, 296);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(195, 22);
            this.txt_dept.TabIndex = 32;
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.ForeColor = System.Drawing.Color.Black;
            this.lbl_dept.Location = new System.Drawing.Point(9, 298);
            this.lbl_dept.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(82, 18);
            this.lbl_dept.TabIndex = 42;
            this.lbl_dept.Text = "Deptmt :";
            this.lbl_dept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Control;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_phone.Location = new System.Drawing.Point(94, 261);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(195, 22);
            this.txt_phone.TabIndex = 30;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_phone.Location = new System.Drawing.Point(9, 263);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(71, 18);
            this.lbl_phone.TabIndex = 41;
            this.lbl_phone.Text = "Phone :";
            this.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dob_picker
            // 
            this.dob_picker.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dob_picker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_picker.Location = new System.Drawing.Point(94, 226);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(195, 20);
            this.dob_picker.TabIndex = 29;
            this.dob_picker.Value = new System.DateTime(2022, 8, 24, 0, 0, 0, 0);
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.Black;
            this.lbl_dob.Location = new System.Drawing.Point(9, 227);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(55, 18);
            this.lbl_dob.TabIndex = 40;
            this.lbl_dob.Text = "DOB :";
            this.lbl_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teachers";
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_female.Location = new System.Drawing.Point(148, 191);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(65, 17);
            this.rd_female.TabIndex = 28;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_male.Location = new System.Drawing.Point(94, 191);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(52, 17);
            this.rd_male.TabIndex = 27;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_gender.Location = new System.Drawing.Point(9, 191);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(80, 18);
            this.lbl_gender.TabIndex = 36;
            this.lbl_gender.Text = "Gender :";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(94, 156);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(195, 22);
            this.txt_name.TabIndex = 26;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(9, 158);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 18);
            this.lbl_name.TabIndex = 34;
            this.lbl_name.Text = "Name :";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Control;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_id.Location = new System.Drawing.Point(94, 121);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(195, 20);
            this.txt_id.TabIndex = 24;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(9, 123);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(37, 18);
            this.lbl_id.TabIndex = 31;
            this.lbl_id.Text = "ID :";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.TabIndex = 25;
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
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_edit.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.Location = new System.Drawing.Point(103, 401);
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
            this.btn_delete.Location = new System.Drawing.Point(199, 401);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 23);
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btn_add,
            this.btn_delete,
            this.btn_edit,
            this.btn_back});
            this.shapeContainer1.Size = new System.Drawing.Size(864, 467);
            this.shapeContainer1.TabIndex = 47;
            this.shapeContainer1.TabStop = false;
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
            this.dataGridView1.TabIndex = 44;
            // 
            // Teachers_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrow_back);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_delete);
            this.Controls.Add(this.lbl_edit);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_fees);
            this.Controls.Add(this.lbl_fees);
            this.Controls.Add(this.txt_dept);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.dob_picker);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.rd_male);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers_Component";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers_Component";
            ((System.ComponentModel.ISupportInitialize)(this.arrow_back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_fees;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_back;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_edit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_delete;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_add;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}