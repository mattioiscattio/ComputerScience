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
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();

        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSDB.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.dSDB.Table1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
