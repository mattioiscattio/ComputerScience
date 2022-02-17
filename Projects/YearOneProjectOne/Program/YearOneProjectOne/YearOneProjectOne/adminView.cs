using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
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
            // TODO: This line of code loads data into the 'dSDB.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.dSDB.studentData);
            loadPointsChart();//use total points awarded/docked, not specific users.
            
        }

    private void loadPointsChart()
        {
            studentPointsChart.Legends.Add("Negative Points");
            studentPointsChart.Legends[0].Title = "Negative Points";
            string Negative = "negativePoints";
            studentPointsChart.Series.Add(Negative);
            studentPointsChart.Series[Negative].ChartType = SeriesChartType.Doughnut;
        }
    private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //run save function 
            Close();
        }

        private void adminView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Startup frmMain = new Startup();
            frmMain.Show();
        }
    }
}
