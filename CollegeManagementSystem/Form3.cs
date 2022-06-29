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

namespace CollegeManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                SqlDataAdapter das = new SqlDataAdapter("select email from Login where email='" + textBox1.Text + "'", Conn.cn);
                DataTable dts = new DataTable();
                int a = das.Fill(dts);
                if(a > 0)
                    MessageBox.Show("User already exist");
                else
                {
                    SqlDataAdapter dai = new SqlDataAdapter("insert into login (email, password) values ('" + textBox1.Text + "','" + textBox2.Text + "')", Conn.cn);
                    DataTable dti = new DataTable();
                    int b = dai.Fill(dti);
                    if (b == 0)
                    {
                        MessageBox.Show("Successfully registerd");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password are not same","Alert",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
    }
}
