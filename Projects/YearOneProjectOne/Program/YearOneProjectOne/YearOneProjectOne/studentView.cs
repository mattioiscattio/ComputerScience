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
            int studentRow = 0;

            for (int i = 0; i <= dSDB.studentData.Rows.Count - 1; i++)
            {

                if (dSDB.studentData.Rows[i][1].ToString() == findStudentName())
                {
                    studentRow = Convert.ToInt32(i);
                    break;
                }
            }

            List<string> titleList = new List<string>();//creats lists of values and titles (x,y respectively) then swaps to array to parse into chart with databindxy
            titleList.Add("+" + Convert.ToInt32(dSDB.studentData.Rows[studentRow][4]));
            titleList.Add("-" + Convert.ToInt32(dSDB.studentData.Rows[studentRow][5]));
            string[] x = titleList.ToArray();

            List<int> pointsList = new List<int>();
            pointsList.Add(Convert.ToInt32(dSDB.studentData.Rows[studentRow][4]));
            pointsList.Add(Convert.ToInt32(dSDB.studentData.Rows[studentRow][5]));
            int[] y = pointsList.ToArray();
            ChrtStudentPoints.Series[0].ChartType = SeriesChartType.Doughnut;
            ChrtStudentPoints.Series[0].Points.DataBindXY(x, y);
            ChrtStudentPoints.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            ChrtStudentPoints.Series[0].Points[0].Color = Color.Green;
            ChrtStudentPoints.Series[0].Points[1].Color = Color.Red;



        }
    }

}
