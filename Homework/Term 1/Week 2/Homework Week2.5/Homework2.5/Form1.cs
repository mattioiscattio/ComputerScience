using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNInput_Click(object sender, EventArgs e)
        {
            int perimiterCost;
            perimiterCost = (Int32.Parse(TBLength.Text) + Int32.Parse(TBWidth.Text)) * 20;
            LBLOutput.Text = "£" + perimiterCost.ToString();
        }
    }
}
