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
            dataBaseInteraction();
        }

        private void dataBaseInteraction()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temporary Workspace\\MultiFormProject\\MultiFormProject\\bin\\Debug\\Database11.MDB";
            string strSQL = "SELECT * FROM Table1";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                connection.Open();
                LBLDebug.Text = "test";
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    LBLDebug.Text = reader["FullName"].ToString();
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNEnter_Click(object sender, EventArgs e)
        {
            FRMLogin f2 = new FRMLogin();
            string username = TBUsername.Text;
            string password = TBPasswd.Text;
            int rowCount = f2.dSDB.Table1.Rows.Count;
            for (int row = 0;row < rowCount;row++)
            {
                if (f2.dSDB.Table1.Rows.Count == 3)
                {
                    LBLPasswd.Text = " ";
                }
                else
                {
                    LBLPasswd.Text = "asdf";
                }
            }
        }
    }
}

