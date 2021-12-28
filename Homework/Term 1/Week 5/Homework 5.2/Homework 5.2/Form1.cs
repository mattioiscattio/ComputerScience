using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_5._2
{
    public partial class HW5B : Form
    {
        int total = 0;
        int numOfMrks = 0;
        public HW5B()
        {
            InitializeComponent();
        }

        private void HW5B_Load(object sender, EventArgs e)
        {
        }

        private void processOneNumber(int examMrk, ref int mrksTotal, ref int mrksCount)//subprogram to add inputted marks to the total and to increment the num of inputs
        {
            mrksTotal += examMrk;
            mrksCount++;
        }

        private void calcMean(int mrksTotal, int mrksCount, ref double avg)
        {
            avg = mrksTotal / mrksCount;//takes mean from values calculated in processonenumber()
        }


        private void BTNok_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = Convert.ToInt32(TBinput.Text);
            marksList.Items.Add(num);//adds input to listbox
            processOneNumber(num, ref total, ref numOfMrks);
            BTNmean.Enabled = true;
            TBinput.Text = "";
            TBinput.Focus();
        }

        private void BTNmean_Click(object sender, EventArgs e)//on click of mean button calculates the mean and then makes mean information visible to user, additionally disables ok button again until new input.
        {
            double mean = 0;
            calcMean(total, numOfMrks, ref mean);
            TBmean.Text = mean.ToString();
            TBmean.Visible = true;
            LBLMean.Visible = true;
            BTNok.Enabled = false;
        }

        private void BTNquit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TBinput_TextChanged(object sender, EventArgs e)//re-enables ok button after an input is entered.
        {
            BTNok.Enabled = true;
        }
    }
}
