using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollegeManagementSystem.Components;

namespace CollegeManagementSystem
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Students_Component().Show();
        }

        private void lbl_students_Click(object sender, EventArgs e)
        {
            btn_students_Click(sender, e);
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teachers_Component().Show();
        }

        private void lbl_teachers_Click(object sender, EventArgs e)
        {
            btn_teachers_Click(sender, e);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Users_Component().Show();
        }

        private void lbl_users_Click(object sender, EventArgs e)
        {
            btn_users_Click(sender, e);
        }

        private void btn_departments_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Department_Component().Show();
        }

        private void lbl_departments_Click(object sender, EventArgs e)
        {
            btn_departments_Click(sender, e);
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Fees_Component().Show();
        }

        private void lbl_fees_Click(object sender, EventArgs e)
        {
            btn_fees_Click(sender, e);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            btn_logout_Click(sender, e);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            btn_dashboard_Click(sender, e);
        }
    }
}
