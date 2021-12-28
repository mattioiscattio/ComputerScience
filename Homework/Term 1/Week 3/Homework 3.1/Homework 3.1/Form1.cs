using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TBInput.Text) > 100)
                {
                LBLOutput.Text = TBInput.Text + " is boiling";
                }
            else if (Convert.ToDouble(TBInput.Text) < 0)
                {
                LBLOutput.Text = TBInput.Text + " is frozen";
                }
            else
                {
                LBLOutput.Text = TBInput.Text + " is not frozen or boiling";
                }
        }
    }
}
