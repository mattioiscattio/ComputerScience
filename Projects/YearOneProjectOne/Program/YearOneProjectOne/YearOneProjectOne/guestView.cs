using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'mainDatabase.pointValueTable' table. You can move, or remove it, as needed.
            this.pointValueTableTableAdapter.Fill(this.mainDatabase.pointValueTable);
            //temp values, implement with values from teacherdata in future when data is in place.
            int netAwardedPoints = 432;
            int netDockedPoints = 96;
            double originalPointValue = 0.25;
            double variablePointValue = (originalPointValue*(netAwardedPoints/netDockedPoints));
            //use teacher data and combine all points docked/awarded to get total points, use to find value of points.
            guestViewPointsPieGraph.Series[0].ChartType = SeriesChartType.Pie;






        }
    }
}
