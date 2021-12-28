using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string dayAppend()
        {
            string Day = TBDay.Text;
            if (Convert.ToInt32(Day) == 1)
            {
                Day = Day + "st";
            }
            else if (Convert.ToInt32(Day) == 2)
            {
                Day = Day + "nd";
            }
            else if (Convert.ToInt32(Day) == 3)
            {
                Day = Day + "rd";
            }
            else
            {
                Day = Day + "th";
            }
            return Day;
        }

        public string monthConversion()
        {
            switch(TBMonth.Text)
            {
                case "1":
                    return ("January");
                    break;
                case "2":
                    return ("February");
                    break;
                default:
                    return ("Not A Month Number");
                    break;
            }
        }

        public string yearSubstring()
        {
            string year = (TBYear.Text).Substring(TBYear.Text.Length-2);
            return year;

        }
        private void BTNRun_Click(object sender, EventArgs e)
        {
            LBLOutput.Text = dayAppend() + " " + monthConversion() + " " + yearSubstring();

        }
    }
}
