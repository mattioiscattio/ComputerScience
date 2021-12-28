using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4._1
{
    public partial class Homework4b : Form
    {
        public Homework4b()
        {
            InitializeComponent();
        }
        int cumulativeValue = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TBInput.Text) == 0)
            {
                BTNRun.Hide();
            }
            else
            {
                cumulativeValue += Convert.ToInt32(TBInput.Text);
                LBOutput.Text = cumulativeValue.ToString();
            }


        }


    }
}  