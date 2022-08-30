using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeManagementSystem.Components
{
    public partial class Students_Component : Form
    {
        public Students_Component()
        {
            InitializeComponent();
        }

        private void Students_Component_Load(object sender, EventArgs e)
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

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_edit_Click(object sender, EventArgs e)
        {
            btn_edit_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void lbl_delete_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Form().Show();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            btn_back_Click(sender, e);
        }

        private void arrow_back_Click(object sender, EventArgs e)
        {
            btn_back_Click(sender, e);
        }
    }
}
