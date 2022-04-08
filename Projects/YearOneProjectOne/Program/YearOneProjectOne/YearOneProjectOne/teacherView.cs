using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class teacherView : Form
    {
        public teacherView()
        {
            InitializeComponent();
        }

        private void teacherView_Load(object sender, EventArgs e)
        {
            this.teacherDataTableAdapter.Fill(this.dSDB.teacherData);
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);
            loadPointsChart();
        }

        private void teacherView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();//when closing reopens the main form.
            frmMain.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);  //closes everything.   
        }

        private string findTeacherName()
        {
            return File.ReadLines(Path.Combine(@"..\..\..\..\..\", @"userData\tempDataFile.txt")).Last();
        }


        private int teacherRowFind()
        {
            for (int i = 0; i <= dSDB.teacherData.Rows.Count - 1; i++)
            {

                if (dSDB.teacherData.Rows[i][2].ToString() == findTeacherName())
                {
                    return Convert.ToInt32(i);
                }
            }
            return 1;
        }


        private void loadPointsChart()
        {
            List<string> titleList = new List<string>();//creats lists of values and titles (x,y respectively) then swaps to array to parse into chart with databindxy
            titleList.Add("+" + Convert.ToInt32(dSDB.teacherData.Rows[teacherRowFind()][3]));
            titleList.Add("-" + Convert.ToInt32(dSDB.teacherData.Rows[teacherRowFind()][4]));
            string[] x = titleList.ToArray();

            List<int> pointsList = new List<int>();
            pointsList.Add(Convert.ToInt32(dSDB.teacherData.Rows[teacherRowFind()][3]));
            pointsList.Add(Convert.ToInt32(dSDB.teacherData.Rows[teacherRowFind()][4]));
            int[] y = pointsList.ToArray();
            teacherRatioChart.Series[0].ChartType = SeriesChartType.Doughnut;
            teacherRatioChart.Series[0].Points.DataBindXY(x, y);
            teacherRatioChart.ChartAreas[0].Area3DStyle.Enable3D = true;//gives 3d style to doughnut point chart
            teacherRatioChart.Series[0].Points[0].Color = Color.Green;
            teacherRatioChart.Series[0].Points[1].Color = Color.Red;
        }



    }
}
