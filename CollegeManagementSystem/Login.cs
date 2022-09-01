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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from login where email='" + txtbox_email.Text + "' and password='" + txtbox_password.Text + "'", Conn.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a > 0)
            {
                this.Hide();
                new Home_Form().Show();
            }
            else
                MessageBox.Show("Incorrect username or password","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration_Form().Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ResetPassword_Form().Show();
        }

        int click = 0;
        private void show_hide_password_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0)
            {
                show_hide_password.Image = CollegeManagementSystem.Properties.Resources.off_visibility;
                txtbox_password.UseSystemPasswordChar = false;
            }
            else if (click % 2 == 1)
            {
                show_hide_password.Image = CollegeManagementSystem.Properties.Resources.visibility;
                txtbox_password.UseSystemPasswordChar = true;
            }
            click++;
        }
    }
}
