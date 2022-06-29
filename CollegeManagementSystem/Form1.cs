using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        int startpos = 0;
        string dot = ".";
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            progressBar1.Value = startpos;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new Form2().Show();
            }

            label4.Text = dot;
            if (startpos % 3 == 0)
                dot = ".";
            else
                dot += ".";
        }

        protected override bool  ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                MessageBox.Show("Do not close at this moment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 	        return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
