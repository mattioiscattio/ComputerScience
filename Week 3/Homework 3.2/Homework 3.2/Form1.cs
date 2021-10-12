using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_3._2
{
    public partial class Homework3b : Form
    {
        public Homework3b()
        {
            InitializeComponent();
        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(TBInputHours.Text) < 60) && (Convert.ToInt32(TBInputHours.Text)) > 0)
            {
                int grossPay = 0;
                if (Convert.ToInt32(TBInputHours.Text) > 40)
                {
                    grossPay += (Convert.ToInt32(TBInputHours.Text) - 40) * Convert.ToInt32(TBInputRate.Text);
                    grossPay += 40 * Convert.ToInt32(TBInputRate.Text);
                    LBLOutput.Text = grossPay.ToString();
                }
                else
                {
                    grossPay += Convert.ToInt32(TBInputHours.Text) * Convert.ToInt32(TBInputRate.Text);
                    LBLOutput.Text = grossPay.ToString();
                }
            }
            else
            {
                LBLOutput.Text = "input hours is outside of specified values.";
            }
        }
    }
}
