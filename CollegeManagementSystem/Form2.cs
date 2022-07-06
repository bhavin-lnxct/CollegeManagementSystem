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
    public partial class Form2 : Form
    {
        public Form2()
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
            SqlDataAdapter da = new SqlDataAdapter("select * from login where email='" + textBox1.Text + "' and password='" + textBox2.Text + "'", Conn.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a > 0)
            {
                this.Hide();
                new Form5().Show();
            }
            else
                MessageBox.Show("Incorrect username or password","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        int click = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click++;
            if (click % 2 == 1)
                pictureBox1.Image = CollegeManagementSystem.Properties.Resources.off_visibility;
            else if (click % 2 == 0)
                pictureBox1.Image = CollegeManagementSystem.Properties.Resources.visibility;
        }
    }
}
