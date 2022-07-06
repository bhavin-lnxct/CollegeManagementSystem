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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Hide();
                new Form2().Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sas = new SqlDataAdapter("select * from login where email='" + textBox1.Text + "'", Conn.cn);
            DataTable dts = new DataTable();
            int a = sas.Fill(dts);
            if (a > 0)
            {
                SqlDataAdapter sau = new SqlDataAdapter("update login set password='" + textBox2.Text + "' where email='" + textBox1.Text + "'", Conn.cn);
                DataTable dtu = new DataTable();
                int b = sau.Fill(dtu);
                if (b == 0)
                {
                    MessageBox.Show("Successfully reset your password.", "Information", MessageBoxButtons.OK);
                    this.Hide();
                    new Form2().Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show("Email doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
