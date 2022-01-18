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
using System.Data.SqlClient;



namespace YearOneProjectOne
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
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

        private void credentialsValidation()
        {
            for (int i = 0; i < DGVUserTable.RowCount; i++)
            {
                if (TBUsername.Text == DGVUserTable.Rows[1].Cells[0].Value.ToString())
                {
                    TBDebug.Text = "fd";
                }
                else
                {
                    TBDebug.Text = "asdf";
                }
            }
        }




        private void BTNLogIn_Click(object sender, EventArgs e)
        {
            //login system here
            if (credentialsValidation() == true)
            {
                TBUsername.Text = "Username";
                TBPassword.Text = "Password";
                new adminView().ShowDialog();
            }
            else
            {
                TBPassword.Text = "";
                
            }
        }

        private void TBPassword_Click(object sender, EventArgs e)
        {
            TBPassword.Text = "";
        }

        private void TBUsername_Click(object sender, EventArgs e)
        {
            TBUsername.Text = "";
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.userTableTableAdapter.Fill(this.mainDatabase1.userTable);
        }

    }
}
