using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YearOneProjectOne
{
    public partial class guestView : Form
    {
        public guestView()
        {
            InitializeComponent();
        }

        private void guestView_Load(object sender, EventArgs e)
        {
            this.teacherDataTableAdapter.Fill(this.dSDB.teacherData);
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);

            loadPointsChart();
            studentCount.Text = "There are currently " + findStudentNum() + " students in the system.";

        }

        private void guestView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            new Startup().ShowDialog();

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
            totalPointsChart.Series[0].ChartType = SeriesChartType.Doughnut;
            totalPointsChart.Series[0].Points.DataBindXY(x, y);
            totalPointsChart.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            totalPointsChart.Series[0].Points[0].Color = Color.Green;
            totalPointsChart.Series[0].Points[1].Color = Color.Red;
        }

        private string findStudentNum()
        {
            return dSDB.studentData.Rows.Count.ToString();
        }


    }
}
