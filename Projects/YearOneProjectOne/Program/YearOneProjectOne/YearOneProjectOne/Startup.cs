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

        private bool credentialsValidation()
        {
            for (int i = 0; i < DGVUserTable.RowCount-1; i++)
            {
                if (TBUsername.Text == DGVUserTable.Rows[i].Cells[1].Value.ToString() && TBPassword.Text == DGVUserTable.Rows[i].Cells[2].Value.ToString())
                {
                    switch (DGVUserTable.Rows[i].Cells[3].Value.ToString())
                    {
                        case "0" :
                            this.Hide();
                            new studentView().ShowDialog();
                            return true;
                        case "1" :
                            this.Hide();
                            new teacherView().ShowDialog();
                            return true;
                        case "2" :
                            this.Hide();
                            new adminView().ShowDialog();
                            return true;
                    }

                }
            }
            TBDebug.Text = "test";
            return false;
        }




        private void BTNLogIn_Click(object sender, EventArgs e)
        {
            if (credentialsValidation() == true)
            {
                TBUsername.Text = "Username";
                TBPassword.Text = "Password";
            }
            else
            {
                TBPassword.Text = "";
                MessageBox.Show("Username Or Password Incorrect");


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
            // TODO: This line of code loads data into the 'mainDatabase1.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.mainDatabase1.userTable);
            WMPScreensaver.uiMode = "None";//removes ui from media player
            WMPScreensaver.URL = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\", @"Data\pipesScreensaver.mp4"));

        }

        private void BTNGuestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new guestView().ShowDialog();
        }
    }
}
