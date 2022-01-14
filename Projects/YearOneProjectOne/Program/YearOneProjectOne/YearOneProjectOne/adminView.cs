using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearOneProjectOne
{
    public partial class adminView : Form
    {
        public adminView()
        {
            InitializeComponent();
        }

        public void adminView_Load(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //run save function 
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run save function
            Environment.Exit(1);
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new guestView().ShowDialog();
        }

    }
}
