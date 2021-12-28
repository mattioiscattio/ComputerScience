using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNInput_Click(object sender, EventArgs e)
        {
            int Volume;
            Volume = (((Int32.Parse(TBDepth1.Text) + Int32.Parse(TBDepth2.Text))/2) * Int32.Parse(TBWidth.Text) * Int32.Parse(TBLength.Text));
            LBOutput.Text = Volume.ToString();
        }

        private void LBOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
