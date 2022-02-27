using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_Week2_Partb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            LBLOutput.Text = (((Convert.ToDouble(TBInput1.Text))-32)*0.55555).ToString();
        }
    }
}
