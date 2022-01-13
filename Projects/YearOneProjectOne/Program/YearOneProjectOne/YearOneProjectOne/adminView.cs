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
    public partial class adminView : Form
    {
        public adminView()
        {
            InitializeComponent();
        }

        public void adminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabase1.timeTable' table. You can move, or remove it, as needed.
            this.timeTableTableAdapter.Fill(this.mainDatabase1.timeTable);
            // TODO: This line of code loads data into the 'mainDatabase1.teacherData' table. You can move, or remove it, as needed.
            this.teacherDataTableAdapter.Fill(this.mainDatabase1.teacherData);
            // TODO: This line of code loads data into the 'mainDatabase1.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.mainDatabase1.studentData);
            Startup startup = new Startup();
            startup.textbox1.Text = DGVstudentData.Rows[0].Cells[0].Value.ToString();
        }

    }
}
