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
        
        private void Form5_Load(object sender, EventArgs e)
        {
            getData();
        }
        
        public void getData()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select email from Login", Conn.cn);
            DataTable dtTbl = new DataTable();
            adapt.Fill(dtTbl);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id.Text != "" || txt_email.Text != "" || txt_password.Text != "")
                {
                    SqlDataAdapter das = new SqlDataAdapter("select email from Login where email='" + txt_email.Text + "'", Conn.cn);
                    DataTable dts = new DataTable();
                    int a = das.Fill(dts);
                    if(a > 0)
                        MessageBox.Show("User already exist");
                    else
                    {
                        SqlDataAdapter dai = new SqlDataAdapter("insert into Login values('" + txt_id.Text + "', '" + txt_email.Text + "', '" + txt_password.Text + "')", Conn.cn);
                        DataTable dti = new DataTable();
                        int b = dai.Fill(dti);
                        if (b == 0)
                        {
                            MessageBox.Show("User added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong");
                        }
                      }
                }
                else
                {
                    MessageBox.Show("Please fill up the data");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
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
            try
            {
                if(txt_email.Text != "")
                {
                    SqlDataAdapter das = new SqlDataAdapter("delete from Login where email='" + txt_email.Text + "'", Conn.cn);
                    DataTable dts = new DataTable();
                    // int a = das.Fill(dts);
                    // if(a > 0)
                    //     MessageBox.Show("User deleted successfully");
                    // else
                    // {
                    //     MessageBox.Show("User cannot be deleted");
                    // }
                }
                else
                {
                    MessageBox.Show("Please fill up the data");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
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
        
        // cell_ClickO()
        // {
        //   txt_id = gridView1.SeletedRow[0].Cell[0].Value.ToString();
        //   txt_email = gridView1.SeletedRow[0].Cell[1].Value.ToString();
        //   txt_password = gridView1.SeletedRow[0].Cell[2].Value.ToString();
        // }
    }
}
