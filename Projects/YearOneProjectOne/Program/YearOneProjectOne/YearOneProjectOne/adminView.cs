using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
            // TODO: This line of code loads data into the 'dSDB.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);

            string var1 = "Logged in as" + "user" + "at: " + DateTime.Now;//string to be written to logs, datetime.now gives current time and date
            appendLoginData(var1);
            pointsChart1.

        }
    

    private void appendLoginData(string var1)//writes startup info logs to logDump.txt
    {
        string path = Path.Combine(@"..\..\..\..\..\", @"userData\logDump.txt");//merges path of logDump.txt with updirectory path.
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine(var1);
        }
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

        private void adminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

            this.Show();
        }
    }
}
