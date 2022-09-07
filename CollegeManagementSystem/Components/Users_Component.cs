using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CollegeManagementSystem.Components
{
    public partial class Users_Component : Form
    {
        public Users_Component()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id.Text == "" || txt_name.Text == "" || txt_password.Text == "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("insert into Login values", Conn.cn);
                }
            }
            catch
            {

            }
        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_logout_Click(object sender, EventArgs e)
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
