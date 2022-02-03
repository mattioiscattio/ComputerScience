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

namespace testProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
        }
        DataSet ds;
        OleDbDataAdapter dataAdapter;
        void ReadData()
        {
            this.ds = new DataSet();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C://Temporary Workspace//Projects//YearOneProjectOne//Databases//yearOneProjectDatabase.mdb");
            this.dataAdapter = new OleDbDataAdapter("SELECT * FROM userTable", conn);
            this.dataAdapter.Fill(this.ds, "userTable");
            this.ds.AcceptChanges();
            //set the table as the datasource for the grid in order to show that data in the grid
            this.dataGridView1.DataSource = ds.DefaultViewManager;
        }

        void SaveData()
        {
            DataSet changes = this.ds.GetChanges();
            if (changes != null)
            {
                //Data has changes. 
                //use update method in the adapter. it should update your datasource
                int updatedRows = this.dataAdapter.Update(changes);
                this.ds.AcceptChanges();
            }

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
