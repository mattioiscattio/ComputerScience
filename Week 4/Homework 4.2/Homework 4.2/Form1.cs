using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4._2
{
    public partial class Heomwork4b : Form
    {
        public Heomwork4b()
        {
            InitializeComponent();
        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TBInput.Text)>9 && (Convert.ToInt32(TBInput.Text)<21))
            {
                LBOutput.Text = "Number is suitable.";
            }
            else
            {
                LBOutput.Text = "Try a different number";
            }
        }
    }
}
