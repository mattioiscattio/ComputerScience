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
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);
            this.rewardTableTableAdapter.Fill(this.dSDB.rewardTable);
            LBLDebug.Text = findStudentName();
            loadPointsChart();
        }

        private void studentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();
            frmMain.Show();
        }

        private string findStudentName()
        {
            return File.ReadLines(Path.Combine(@"..\..\..\..\..\", @"userData\tempDataFile.txt")).First();
        }

        
        private void loadPointsChart()
        {
            List<string> titleList = new List<string>();//creats lists of values and titles (x,y respectively) then swaps to array to parse into chart with databindxy
            titleList.Add("+" + Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][5]));
            titleList.Add("-" + Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][6]));
            string[] x = titleList.ToArray();

            List<int> pointsList = new List<int>();
            pointsList.Add(Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][5]));
            pointsList.Add(Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][6]));
            int[] y = pointsList.ToArray();
            ChrtStudentPoints.Series[0].ChartType = SeriesChartType.Doughnut;
            ChrtStudentPoints.Series[0].Points.DataBindXY(x, y);
            ChrtStudentPoints.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            ChrtStudentPoints.Series[0].Points[0].Color = Color.Green;
            ChrtStudentPoints.Series[0].Points[1].Color = Color.Red;



        }

        private int studentRowFind()
        {
            for (int i = 0; i <= dSDB.studentData.Rows.Count - 1; i++)
            {

                if (dSDB.studentData.Rows[i][1].ToString() == findStudentName())
                {
                    return Convert.ToInt32(i);
                }
                else
                {
                    return 1;
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
        }


        private void LBRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dSDB.rewardTable.Rows[LBRewards.SelectedIndex][2]) > (Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][5]) - Convert.ToInt32(dSDB.studentData.Rows[studentRowFind()][6])))
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
            MessageBox.Show("Are you sure you want to purchase: " + TBItemName.Text.ToString() + " for: " + TBItemPrice.Text.ToString());
            dSDB.studentData.Rows[studentRowFind()][]
        }
    }


}
