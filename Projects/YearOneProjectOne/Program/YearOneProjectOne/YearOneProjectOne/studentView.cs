using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearOneProjectOne
{
    public partial class studentView : Form
    {
        public studentView()
        {
            InitializeComponent();
        }

        private void studentView_Load(object sender, EventArgs e)
        {


        }

        private void studentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();
            frmMain.Show();
        }

        private int getStudentRow()
        {
            for (int i = 0; i < dSDB.userTable.Rows.Count - 1; i++)//loops through userTable for credentials
            {
                if (dSDB.userTable.Rows[i][3].ToString() == File.ReadAllText(Path.Combine(@"..\..\..\..\..\", @"userData\tempDataFile.txt")))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
