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
using System.Data.OleDb;

namespace YearOneProjectOne
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }
        private DataSet dataBaseInteraction()
        {
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Documents\\school\\College\\Courses\\Computer Science\\Projects\\YearOneProjectOne\\Databases\\yearOneProjectDatabase.mdb.accdb;";
            string mySql = "SELECT * FROM studentData";

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
       



        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            WMPStartup.uiMode = "None";//removes ui from media player
            WMPStartup.URL = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\", @"Data\win98.mp4"));//combines up movements in directory with path of file.
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)//checks for playstate change
        {
            if (WMPStartup.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                WMPStartup.Hide();
                WMPScreensaver.Show();
                WMPScreensaver.uiMode = "None";//removes ui from media player
                WMPScreensaver.URL = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\", @"Data\pipesScreensaver.mp4"));
            }
        }

        private void BTNLogIn_Click(object sender, EventArgs e)
        {
            new guestView().ShowDialog();

        }

        private void TBPassword_Click(object sender, EventArgs e)
        {
            TBPassword.Text = "";
        }

        private void TBUsername_Click(object sender, EventArgs e)
        {
            TBUsername.Text = "";
        }
    }
}
