using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LBOutput.MultiColumn = true;
            for (int i = 1; i < 21; i++ )
            {
                double output = Math.Round(((i) * 2.2), 2);
                LBOutput.Items.Add(output.ToString() + " Pounds");
            }
            for (int i = 1; i < 21; i++)
            {
                LBOutput.Items.Add(i.ToString() + " KG");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
