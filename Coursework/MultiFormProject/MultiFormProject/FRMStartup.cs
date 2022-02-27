using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MultiFormProject
{
    public partial class FRMStartup : Form
    {
        public FRMStartup()
        {
            InitializeComponent();
        }

        private void FRMStartup_Load(object sender, EventArgs e)
        {
           
            FRMLogin f2 = new FRMLogin();
            f2.ShowDialog();


        }

    }
}
