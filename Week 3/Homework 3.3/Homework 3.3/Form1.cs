using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_3._3
{
    public partial class Homework3c : Form
    {
        public Homework3c()
        {
            InitializeComponent();
        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(TBInput.Text);
            if (input <= 40) 
                {
                LBLOutput.Text = "U";
                }
            else if (input <= 50)
                {
                LBLOutput.Text = "E";
                }
            else if (input <= 60)
            {
                LBLOutput.Text = "D";
            }
            else if (input <= 70)
            {
                LBLOutput.Text = "C";
            }
            else if (input <= 80)
            {
                LBLOutput.Text = "B";
            }
            else if (input <= 100)
            {
                LBLOutput.Text = "A";
            }
        }
    }
}
