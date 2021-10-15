using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_5._1
{
    public partial class HW5A : Form
    {
        public HW5A()
        {
            InitializeComponent();
        }

        private void HW5A_Load(object sender, EventArgs e)
        {

        }

        private void BTNDecimalIn_Click(object sender, EventArgs e)
        {
            decimal decimalVal = decimal.Round(Convert.ToDecimal(TBDecimalInput.Text));//converts input value to decimal and rounds it, before outputting to LBL as string. could shorten to one statement
            LBLDecimalOut.Text = decimalVal.ToString();
        }

        private void BTNStrLenIn_Click(object sender, EventArgs e)
        {
            int stringInputLen = (TBStrLen.Text).Length;
            LBLStrLenOut.Text = stringInputLen.ToString();
        }

        private void TBAsciiIn_Click(object sender, EventArgs e)
        {
            byte[] charInput = Encoding.ASCII.GetBytes(TBAsciiIn.Text);//takes the input from tb and converts it into a list of ascii codes, output is the first one. could add more outputs.
            LBLAsciiOut.Text = charInput[0].ToString();

        }

        private void LBLSurnameOut_Click(object sender, EventArgs e)
        {

        }

        private void BTNCharIn_Click(object sender, EventArgs e)
        {
            char asciiCodeInput = (char)Convert.ToInt32(TBChar.Text);//inputs the ascii code and converts to int, then converts that to char and outputs as string.
            LBLCharOut.Text = asciiCodeInput.ToString();
        }

        private void BTNSurnameIn_Click(object sender, EventArgs e)
        {
            string surnameInput = TBSurname.Text;
            LBLSurnameOut.Text = surnameInput.ToUpper();
        }
    }
}
