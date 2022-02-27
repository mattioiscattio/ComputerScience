using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_Week2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            double inputStone;
            inputStone = (double.Parse(TBInput.Text) * 6.364);
            LBLKG.Text = inputStone.ToString();
        }

        private void BTNCm_Click(object sender, EventArgs e)
        {
            double inputInches;
            inputInches = (double.Parse(TBInput.Text) * 2.54);
            LBLCm.Text = inputInches.ToString();
        }
    }
}
