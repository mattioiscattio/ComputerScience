using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


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

        private DataSet dataBaseInteraction()
        {
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();

            string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temporary Workspace\\MultiFormProject\\MultiFormProject\\bin\\Debug\\Database11.MDB;";
            string mySql = "SELECT * FROM Table1";

            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(mySql, connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection!");
            }
            return ds;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNEnter_Click(object sender, EventArgs e)
        {
            //dataSetUsers = dataBaseInteraction();
            //LBLDebug.Text = "";
        }
    }
}

