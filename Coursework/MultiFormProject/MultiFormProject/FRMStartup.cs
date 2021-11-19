using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'dSDB.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.dSDB.Table1);
            FRMLogin f2 = new FRMLogin();
            f2.ShowDialog();

        }
    }
}
