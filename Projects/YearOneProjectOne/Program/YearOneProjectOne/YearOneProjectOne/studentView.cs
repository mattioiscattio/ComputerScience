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
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;



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
            this.studentDataTableAdapter.Fill(this.DSDB.studentData);
            this.rewardTableTableAdapter.Fill(this.DSDB.rewardTable);
            this.userTableTableAdapter.Fill(this.DSDB.userTable);
            LBLDebug.Text = findStudentName();
            loadPointsChart();
            stockCheck();
            userTableRowFind();
            if ((DSDB.userTable.Rows[userTableRowFind()][1].ToString() == findStudentName()) & (DSDB.userTable.Rows[userTableRowFind()][2].ToString() == "123"))
            {
                MessageBox.Show("Your password is currently at default, please change it.");
            }
        }

        private void studentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();
            frmMain.Show();
        }

        private void stockCheck()
        {
            for (int i = 0; i < DSDB.rewardTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(DSDB.rewardTable.Rows[i][3]) < Convert.ToInt32(DSDB.rewardTable.Rows[i][4]))
                {
                    LBLDebug.Text = "ta";
                }
            }
        }

        private int userTableRowFind()
        {
            int studentRow = 0;
            for (int i = 0; i < DSDB.userTable.Rows.Count;i++)
            {

                if (DSDB.userTable.Rows[i][1].ToString() == findStudentName())
                {
                    studentRow = i;
                    return studentRow;
                }

            }
            return studentRow;

        }

        private string findStudentName()
        {
            return File.ReadLines(Path.Combine(@"..\..\..\..\..\", @"userData\tempDataFile.txt")).Last();
        }

        
        private void loadPointsChart()
        {
            List<string> titleList = new List<string>();//creats lists of values and titles (x,y respectively) then swaps to array to parse into chart with databindxy
            titleList.Add("+" + Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][5]));
            titleList.Add("-" + Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][6]));
            titleList.Add("$ " + Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][7]));
            string[] x = titleList.ToArray();

            List<int> pointsList = new List<int>();
            pointsList.Add(Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][5]));
            pointsList.Add(Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][6]));
            pointsList.Add(Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][7]));
            int[] y = pointsList.ToArray();
            ChrtStudentPoints.Series[0].ChartType = SeriesChartType.Doughnut;
            ChrtStudentPoints.Series[0].Points.DataBindXY(x, y);
            ChrtStudentPoints.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            ChrtStudentPoints.Series[0].Points[0].Color = Color.Green;
            ChrtStudentPoints.Series[0].Points[1].Color = Color.Red;
            ChrtStudentPoints.Series[0].Points[2].Color = Color.Yellow;



        }

        private int studentRowFind()
        {
            for (int i = 0; i <= DSDB.studentData.Rows.Count - 1; i++)
            {

                if (DSDB.studentData.Rows[i][1].ToString() == findStudentName())
                {
                    return Convert.ToInt32(i);
                }
            }
            return 1;
        }

        private void useTheShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBRewards.Visible == Visible)
            {
                menuComponentsHide();
            }
            else
            {
                menuComponentsHide();
                LBRewards.Show();
                LBLItemName.Show();
                LBLItemPrice.Show();
                LBLItemStock.Show();
                TBItemName.Show();
                TBItemPrice.Show();
                TBItemStock.Show();
                BTNPurchase.Show();

            }
        }

        private void menuComponentsHide()
        {
            LBRewards.Hide();
            LBLItemName.Hide();
            LBLItemPrice.Hide();
            LBLItemStock.Hide();
            TBItemName.Hide();
            TBItemPrice.Hide();
            TBItemStock.Hide();
            BTNPurchase.Hide();
            BTNChangePass.Hide();
            TBConfirmPass.Hide();
            TBOldPass.Hide();
            TBNewPass.Hide();
            LBLConfirmPass.Hide();
            LBLNewPass.Hide();
            LBLOldPass.Hide();
        }

        private void colourUpdate()
        {
            if (Convert.ToInt32(DSDB.rewardTable.Rows[LBRewards.SelectedIndex][2]) > Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][5]) - Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][6]) - Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][7]))
            {
                LBRewards.BackColor = Color.Red;
                LBRewards.ForeColor = Color.White;
                LBLItemPrice.BackColor = Color.Red;
                LBLItemPrice.ForeColor = Color.White;
                LBLItemName.BackColor = Color.Red;
                LBLItemName.ForeColor = Color.White;
                LBLItemStock.BackColor = Color.Red;
                LBLItemStock.ForeColor = Color.White;
            }

            else if (Convert.ToInt32(DSDB.rewardTable.Rows[LBRewards.SelectedIndex][3]) == 0)
            {
                LBRewards.BackColor = Color.Yellow;
                LBRewards.ForeColor = Color.Black;
                LBLItemPrice.BackColor = Color.Yellow;
                LBLItemPrice.ForeColor = Color.Black;
                LBLItemName.BackColor = Color.Yellow;
                LBLItemName.ForeColor = Color.Black;
                LBLItemStock.BackColor = Color.Yellow;
                LBLItemStock.ForeColor = Color.Black;
            }

            else
             {
                LBRewards.BackColor = Color.Green;
                LBRewards.ForeColor = Color.Black;
                LBLItemPrice.BackColor = Color.Green;
                LBLItemPrice.ForeColor = Color.Black;
                LBLItemName.BackColor = Color.Green;
                LBLItemName.ForeColor = Color.Black;
                LBLItemStock.BackColor = Color.Green;
                LBLItemStock.ForeColor = Color.Black;
            }
        }


        private void LBRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            colourUpdate();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);  //closes everything.   
        }

        private void BTNPurchase_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DSDB.rewardTable.Rows[LBRewards.SelectedIndex][3]) > 0 & (Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][5]) - Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][7]) - Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][6])) > Convert.ToInt32(TBItemPrice.Text))
                {
                MessageBox.Show("Are you sure you want to purchase: " + TBItemName.Text.ToString() + " for: " + TBItemPrice.Text.ToString());
                DSDB.studentData.Rows[studentRowFind()][7] = Convert.ToInt32(DSDB.studentData.Rows[studentRowFind()][7]) + Convert.ToInt32(TBItemPrice.Text);
                DSDB.rewardTable.Rows[LBRewards.SelectedIndex][3] = Convert.ToInt32(DSDB.rewardTable.Rows[LBRewards.SelectedIndex][3]) - 1;
                studentDataTableAdapter.Update(DSDB.studentData);
                rewardTableTableAdapter.Update(DSDB.rewardTable);
                colourUpdate();
                loadPointsChart();
            }

            else if (!(Convert.ToInt32(DSDB.rewardTable.Rows[LBRewards.SelectedIndex][3]) > 0))
            {
                MessageBox.Show("There is not enough stock for this item, please wait for a restock");
            }

            else
            {
                MessageBox.Show("You do not have enough points to purchase this item.");
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBOldPass.Text = DSDB.userTable.Rows[userTableRowFind()][2].ToString();
            menuComponentsHide();
            BTNChangePass.Show();
            TBConfirmPass.Show();
            TBOldPass.Show();
            TBNewPass.Show();
            LBLConfirmPass.Show();
            LBLNewPass.Show();
            LBLOldPass.Show();
        }

        private void BTNChangePass_Click(object sender, EventArgs e)
        {
            if (TBConfirmPass.ToString() == TBNewPass.ToString())
            {
                DSDB.userTable.Rows[userTableRowFind()][2] = TBConfirmPass.Text;
                MessageBox.Show("Password updated successfully!");
                userTableTableAdapter.Update(DSDB.userTable);
                DSDB.AcceptChanges();

            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }


}
