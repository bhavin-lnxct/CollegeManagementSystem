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
                this.Hide();
                new Home_Form().Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
            }
        }
    }
}
