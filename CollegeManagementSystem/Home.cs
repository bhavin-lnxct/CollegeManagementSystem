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

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Students_Component().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ovalShape1_Click(sender, e);
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teachers_Component().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ovalShape2_Click(sender, e);
        }

        private void ovalShape3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Users_Component().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ovalShape3_Click(sender, e);
        }

        private void ovalShape4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Department_Component().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ovalShape4_Click(sender, e);
        }

        private void ovalShape5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Fees_Component().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ovalShape5_Click(sender, e);
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            rectangleShape1_Click(sender, e);
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            rectangleShape2_Click(sender, e);
        }
    }
}
