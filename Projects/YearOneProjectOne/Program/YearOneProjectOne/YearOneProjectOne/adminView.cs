using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            // TODO: This line of code loads data into the 'dSDB.rewardTable' table. You can move, or remove it, as needed.
            this.rewardTableTableAdapter.Fill(this.dSDB.rewardTable);
            // TODO: This line of code loads data into the 'dSDB.teacherData' table. You can move, or remove it, as needed.
            this.teacherDataTableAdapter.Fill(this.dSDB.teacherData);
            // TODO: This line of code loads data into the 'dSDB.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);
            loadPointsChart();//gets total point information and creats chart to display it.

        }

        private void loadPointsChart()
        {
            int netPosPoints = 0;
            int netNegPoints = 0;

            for (int i = 0; i <= dSDB.teacherData.Rows.Count - 1; i++)//polls all teacher points/root points to get total docked/awarded
            {
                netPosPoints += Convert.ToInt32(dSDB.teacherData.Rows[i][3]);
                netNegPoints += Convert.ToInt32(dSDB.teacherData.Rows[i][4]);
            }

            List<string> titleList = new List<string>();//creats lists of values and titles (x,y respectively) then swaps to array to parse into chart with databindxy
            titleList.Add("+" + netPosPoints.ToString());
            titleList.Add("-" + netNegPoints.ToString());
            string[] x = titleList.ToArray();

            List<int> pointsList = new List<int>();
            pointsList.Add(netPosPoints);
            pointsList.Add(netNegPoints);
            int[] y = pointsList.ToArray();
            studentPointsChart.Series[0].ChartType = SeriesChartType.Doughnut;
            studentPointsChart.Series[0].Points.DataBindXY(x, y);
            studentPointsChart.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            studentPointsChart.Series[0].Points[0].Color = Color.Green;
            studentPointsChart.Series[0].Points[1].Color = Color.Red;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adminView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();//when closing reopens the main form.
            frmMain.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);  //closes everything.   
        }



        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBRewardList.Visible == Visible)
            {
                dropDownComponentsHide();
            }

            else
            {
                LBLRewardName.Show();
                LBLRewardPrice.Show();
                LBLRewardStock.Show();
                LBLRewardThreshold.Show();
                LBRewardList.Show();
                TBRewardName.Show();
                TBRewardPrice.Show();
                TBRewardStock.Show();
                TBRewardThreshold.Show();
                BindingNavigatorReward.Show();
            }
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)//toggles between showing or hiding the studentTable data screen.
        {
            if (LBLStudentName.Visible == Visible)
            {
                dropDownComponentsHide();

            }
            else
            {
                dropDownComponentsHide();
                TBStudentName.Show();
                TBStudentDOB.Show();
                TBStudentPointsPos.Show();
                LBLStudentName.Show();
                LBLStudentDOB.Show();
                LBLStudentPointsPos.Show();
                LBLStudentPointsNeg.Show();
                LBStudents.Show();
                bindingNavigator1.Show();
                TBStudentPointsNeg.Show();

            }
        }

        private void dropDownComponentsHide()
        {
                TBStudentName.Hide();
                TBStudentDOB.Hide();
                TBStudentPointsPos.Hide();
                LBLStudentName.Hide();
                LBLStudentDOB.Hide();
                LBLStudentPointsPos.Hide();
                LBStudents.Hide();
                bindingNavigator1.Hide();
                LBLPointsVaryVal.Hide();
                TBPointsVaryVal.Hide();
                LBLstudentPointsCounter.Hide();
                LBLNameSearch.Hide();
                TBNameSearch.Hide();
                TBPointsVaryVal.Hide();
                LBSearchedStudents.Hide();
                LBLSelectStudent.Hide();
                BTNAddPoints.Hide();
                BTNDockPoints.Hide();
                LBLRewardName.Hide();
                LBLRewardPrice.Hide();
                LBLRewardStock.Hide();
                LBLRewardThreshold.Hide();
                LBRewardList.Hide();
                TBRewardName.Hide();
                TBRewardPrice.Hide();
                TBRewardStock.Hide();
                TBRewardThreshold.Hide();
                BindingNavigatorReward.Hide();
                LBLStudentPointsNeg.Hide();
                TBStudentPointsNeg.Hide();


        }




        private void BTNLoad_Click(object sender, EventArgs e)
        {
            studentDataTableAdapter.Fill(dSDB.studentData);
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            studentDataTableAdapter.Update(dSDB.studentData);
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            StudentBindingSource.CancelEdit();
        }

        private void awardDockPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBLNameSearch.Visible == Visible)
            {
                dropDownComponentsHide();
            }

            else
            {
                dropDownComponentsHide();
                LBLPointsVaryVal.Show();
                TBPointsVaryVal.Show();
                LBLstudentPointsCounter.Show();
                LBLNameSearch.Show();
                TBNameSearch.Show();
                LBLPointsVaryVal.Show();
                TBPointsVaryVal.Show();
                LBSearchedStudents.Show();
                LBLSelectStudent.Show();
                BTNDockPoints.Show();
                BTNAddPoints.Show();
            }
        }

        private void TBNameSearch_TextChanged(object sender, EventArgs e)
        {   

            DataView studentDataView = dSDB.studentData.DefaultView;
            studentDataView.RowFilter = "studentName LIKE '%" + TBNameSearch.Text + "%'";
            LBSearchedStudents.DataSource = studentDataView;
        }

        private void TBNameSearch_Click(object sender, EventArgs e)
        {
            TBNameSearch.Text = "";
        }

        private void BTNAddPoints_Click(object sender, EventArgs e)//add reason for points add/dock, student file generation + logs
        {
            try
            {
                int currentPoints = Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]);
                if (Convert.ToInt32(TBPointsVaryVal.Text) > 0)
                {
                    dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5] = currentPoints + Convert.ToInt32(TBPointsVaryVal.Text);
                    studentDataTableAdapter.Update(dSDB.studentData);
                    LBLstudentPointsCounter.Text = "Student Currently has " + (Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]) - Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][6]) - Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][7])) + " points";

                }

                else if (Convert.ToInt32(TBPointsVaryVal.Text) <= 0)
                {
                    MessageBox.Show("You can't add less than 1 point");
                }
            }

            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }

        private void BTNDockPoints_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPoints = Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]);
                if (Convert.ToInt32(TBPointsVaryVal.Text) > 0 && Convert.ToInt32(TBPointsVaryVal.Text) <= currentPoints)
                    {
                    dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5] = currentPoints - Convert.ToInt32(TBPointsVaryVal.Text);
                    studentDataTableAdapter.Update(dSDB.studentData);
                    LBLstudentPointsCounter.Text = "Student Currently has " + Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]) + " points";
                }

                else if (Convert.ToInt32(TBPointsVaryVal.Text) > 0 && Convert.ToInt32(TBPointsVaryVal.Text) > currentPoints)
                {
                    dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5] = 0;
                    LBLstudentPointsCounter.Text = "Student Currently has " + Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]) + " points";
                }

                else if (Convert.ToInt32(TBPointsVaryVal.Text) <= 0)
                {
                    MessageBox.Show("You can't remove less than 1 point");
                }
            }

            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }

        private void LBSearchedStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LBLstudentPointsCounter.Text = "Student Currently has " + Convert.ToInt32(dSDB.studentData.Rows[LBSearchedStudents.SelectedIndex][5]) + " points";//breaks on load, add watch no available
            }
            catch
            {

            }
       }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            rewardTableTableAdapter.Update(dSDB.rewardTable);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            rewardTableTableAdapter.Fill(dSDB.rewardTable);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            rewardTableBindingSource.CancelEdit();
        }


    }
}
