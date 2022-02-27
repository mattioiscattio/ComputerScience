﻿using System;
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
<<<<<<< HEAD
            for (int i = 0; i < DSDB.userTable.Rows.Count - 1; i++)//loops through userTable for credentials
            {
                if (TBUsername.Text == DSDB.userTable.Rows[i][1].ToString() && TBPassword.Text == DSDB.userTable.Rows[i][2].ToString())
                {
                    switch (DSDB.userTable.Rows[i][3].ToString())//checks userTable data for inputted credentials, then uses case switch to find the login hierarchy to find the target page.
                    {
                        case "0":
                            tempFileWrite(DSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + DSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
=======
            for (int i = 0; i < dSDB.userTable.Rows.Count - 1; i++)//loops through userTable for credentials
            {
                if (TBUsername.Text == dSDB.userTable.Rows[i][1].ToString() && TBPassword.Text == dSDB.userTable.Rows[i][2].ToString())
                {
                    switch (dSDB.userTable.Rows[i][3].ToString())//checks userTable data for inputted credentials, then uses case switch to find the login hierarchy to find the target page.
                    {
                        case "0":
                            tempFileWrite(dSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + dSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
                            this.Hide();
                            new studentView().ShowDialog();
                            return true;
                        case "1":
<<<<<<< HEAD
                            tempFileWrite(DSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + DSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
=======
                            tempFileWrite(dSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + dSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
                            this.Hide();
                            new teacherView().ShowDialog();
                            return true;
                        case "2":
<<<<<<< HEAD
                            tempFileWrite(DSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + DSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
=======
                            tempFileWrite(dSDB.userTable.Rows[i][1].ToString());
                            logWrite("logged in as " + dSDB.userTable.Rows[i][1].ToString() + " at: " + DateTime.Now);
>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
                            this.Hide();
                            new adminView().ShowDialog();
                            return true;
                    }

                }
            }
            return false;
        }


        private void tempFileWrite(string loginCode)
        {
<<<<<<< HEAD
            string path = Path.Combine(@"..\..\..\..\..\..\", @"userData\tempDataFile.txt");
=======
            string path = Path.Combine(@"..\..\..\..\..\", @"userData\tempDataFile.txt");
>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(loginCode);
            }
        }

        private void BTNLogIn_Click(object sender, EventArgs e)
        {
            if (credentialsValidation() == true)//credentialsValidation() runs function to check the databse for the inputted credentials, if correct then the function creates the new windows and closes startup.cs, then empties textboxes for security 
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
            TBPassword.Text = "";//empties password textbox when clicked, allows for inital text
        }

        private void TBUsername_Click(object sender, EventArgs e)
        {
            TBUsername.Text = "";//empties username textbox when clicked, allows for inital text
        }

        private void Startup_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.teacherDataTableAdapter.Fill(this.DSDB.teacherData);
            // TODO: This line of code loads data into the 'dSDB.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.DSDB.userTable);
            WMPScreensaver.uiMode = "None";//removes ui from media player
            WMPScreensaver.URL = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\..\", @"Data\pipesScreensaver.mp4"));
            string var1 = "Program Started At: " + DateTime.Now;//string to be written to logs, datetime.now gives current time and date
            logWrite(var1);
            pointValueUpdater();//updates value of point, need fixing
        }

        private void logWrite(string var1)//writes startup info logs to logDump.txt
        {
            string path = Path.Combine(@"..\..\..\..\..\..\", @"userData\logDump.txt");//merges path of logDump.txt with updirectory path.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(var1);
            }
        }

        private void pointValueUpdater()
        {
            int netDockedPoints = 0;
            int netAwardedPoints = 0;
            for (int i = 0; i < DSDB.teacherData.Rows.Count - 1; i++)
            {
                netDockedPoints += Convert.ToInt32(DSDB.teacherData.Rows[i][3]);
                netAwardedPoints += Convert.ToInt32(DSDB.teacherData.Rows[i][4]);
                double newPointValue = 5*Math.Abs(netAwardedPoints-netDockedPoints);
                string path = Path.Combine(@"..\..\..\..\..\..\", @"userData\pointValueHistory.txt");
=======
            // TODO: This line of code loads data into the 'dSDB.teacherData' table. You can move, or remove it, as needed.
            this.teacherDataTableAdapter.Fill(this.dSDB.teacherData);
            // TODO: This line of code loads data into the 'dSDB.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.dSDB.userTable);
            WMPScreensaver.uiMode = "None";//removes ui from media player
            WMPScreensaver.URL = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\", @"Data\pipesScreensaver.mp4"));
            string var1 = "Program Started At: " + DateTime.Now;//string to be written to logs, datetime.now gives current time and date
            logWrite(var1);
            pointValueUpdater();
        }

        private void logWrite(string var1)//writes startup info logs to logDump.txt
        {
            string path = Path.Combine(@"..\..\..\..\..\", @"userData\logDump.txt");//merges path of logDump.txt with updirectory path.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(var1);
            }
        }

        private void pointValueUpdater()
        {
            int netDockedPoints = 0;
            int netAwardedPoints = 0;
            for (int i = 0; i < dSDB.teacherData.Rows.Count - 1; i++)
            {
                netDockedPoints += Convert.ToInt32(dSDB.teacherData.Rows[i][3]);
                netAwardedPoints += Convert.ToInt32(dSDB.teacherData.Rows[i][4]);




                //netDockedPoints += Convert.ToInt32(DGVteacherData.Rows[i].Cells[3].Value);// i, 3
                //netAwardedPoints += Convert.ToInt32(DGVteacherData.Rows[i].Cells[4].Value);
                TBDebug.Text = netDockedPoints.ToString();
                double newPointValue = 5*Math.Abs(netAwardedPoints-netDockedPoints);
                string path = Path.Combine(@"..\..\..\..\..\", @"userData\pointValueHistory.txt");
>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Math.Round(newPointValue, 1).ToString());
                }
            }
        }

        private void BTNGuestLogin_Click(object sender, EventArgs e)
        {
            this.Close();//hides startup.cs and then opens guestview
            new guestView().ShowDialog();
        }

<<<<<<< HEAD
=======
        private void WMPScreensaver_Enter(object sender, EventArgs e)
        {

        }


>>>>>>> b8ce23a831d19c982fb5cf2b52fc8245804a8d7b
        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
