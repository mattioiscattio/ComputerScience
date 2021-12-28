using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Homework_4._5
{
    public partial class HW4B : Form
    {
        public HW4B()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNEnterNum_Click(object sender, EventArgs e)
        {
            int largestNum = Convert.ToInt32(LBLOutput.Text);
            if (Convert.ToInt32(TBNumInput.Text) == -1)
            {
                BTNEnterNum.Hide();
            }
            else if (Convert.ToInt32(TBNumInput.Text) > largestNum)
            {
                largestNum = Convert.ToInt32(TBNumInput.Text);
                LBLOutput.Text = largestNum.ToString();
            }
           
        }
    }
}
