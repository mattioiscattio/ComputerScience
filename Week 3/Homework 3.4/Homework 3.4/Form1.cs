using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            const int listSize = 12;
            int[] monthList = new int[listSize];
            {
                monthList[0] = 31;
                monthList[1] = 28;
                monthList[2] = 31;
                monthList[3] = 30;
                monthList[4] = 31;
                monthList[5] = 30;
                monthList[6] = 31;
                monthList[7] = 31;
                monthList[8] = 30;
                monthList[9] = 31;
                monthList[10] = 30;
                monthList[11] = 31;
            }
            LBLMonthOutput.Text = (monthList[Convert.ToInt32(TBMonthNum.Text)-1]).ToString();
            if ((Convert.ToInt32(TBYearNum.Text) % 4) == 0)
            {
                LBLYearOutput.Text = "It is a leap year";
            }
            else
                    LBLYearOutput.Text = "It is not a leap year";

        }
    }
}
