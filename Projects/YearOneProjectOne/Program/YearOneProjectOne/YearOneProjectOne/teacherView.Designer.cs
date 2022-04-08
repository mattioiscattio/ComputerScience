
namespace YearOneProjectOne
{
    partial class teacherView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awardDockPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNDockPoints = new System.Windows.Forms.Button();
            this.BTNAddPoints = new System.Windows.Forms.Button();
            this.LBLSelectStudent = new System.Windows.Forms.Label();
            this.TBNameSearch = new System.Windows.Forms.TextBox();
            this.LBLNameSearch = new System.Windows.Forms.Label();
            this.LBLstudentPointsCounter = new System.Windows.Forms.Label();
            this.TBPointsVaryVal = new System.Windows.Forms.TextBox();
            this.LBSearchedStudents = new System.Windows.Forms.ListBox();
            this.teacherRatioChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.teacherDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.teacherDataTableAdapter();
            this.dSDB = new YearOneProjectOne.DSDB();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRatioChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionToolStripMenuItem,
            this.studentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SessionToolStripMenuItem
            // 
            this.SessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem";
            this.SessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.SessionToolStripMenuItem.Text = "Session";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.awardDockPointsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // awardDockPointsToolStripMenuItem
            // 
            this.awardDockPointsToolStripMenuItem.Name = "awardDockPointsToolStripMenuItem";
            this.awardDockPointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.awardDockPointsToolStripMenuItem.Text = "Award/Dock Points";
            // 
            // BTNDockPoints
            // 
            this.BTNDockPoints.Location = new System.Drawing.Point(272, 236);
            this.BTNDockPoints.Name = "BTNDockPoints";
            this.BTNDockPoints.Size = new System.Drawing.Size(75, 23);
            this.BTNDockPoints.TabIndex = 63;
            this.BTNDockPoints.Text = "Remove ";
            this.BTNDockPoints.UseVisualStyleBackColor = true;
            this.BTNDockPoints.Visible = false;
            // 
            // BTNAddPoints
            // 
            this.BTNAddPoints.Location = new System.Drawing.Point(178, 236);
            this.BTNAddPoints.Name = "BTNAddPoints";
            this.BTNAddPoints.Size = new System.Drawing.Size(75, 23);
            this.BTNAddPoints.TabIndex = 62;
            this.BTNAddPoints.Text = "Add";
            this.BTNAddPoints.UseVisualStyleBackColor = true;
            this.BTNAddPoints.Visible = false;
            // 
            // LBLSelectStudent
            // 
            this.LBLSelectStudent.AutoSize = true;
            this.LBLSelectStudent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSelectStudent.Location = new System.Drawing.Point(12, 117);
            this.LBLSelectStudent.Name = "LBLSelectStudent";
            this.LBLSelectStudent.Size = new System.Drawing.Size(132, 22);
            this.LBLSelectStudent.TabIndex = 61;
            this.LBLSelectStudent.Text = "Select Student:";
            this.LBLSelectStudent.Visible = false;
            // 
            // TBNameSearch
            // 
            this.TBNameSearch.Location = new System.Drawing.Point(150, 44);
            this.TBNameSearch.Name = "TBNameSearch";
            this.TBNameSearch.Size = new System.Drawing.Size(118, 20);
            this.TBNameSearch.TabIndex = 59;
            this.TBNameSearch.Text = "Enter Student Name";
            this.TBNameSearch.Visible = false;
            // 
            // LBLNameSearch
            // 
            this.LBLNameSearch.AutoSize = true;
            this.LBLNameSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNameSearch.Location = new System.Drawing.Point(12, 41);
            this.LBLNameSearch.Name = "LBLNameSearch";
            this.LBLNameSearch.Size = new System.Drawing.Size(132, 22);
            this.LBLNameSearch.TabIndex = 58;
            this.LBLNameSearch.Text = "Student Name:";
            this.LBLNameSearch.Visible = false;
            // 
            // LBLstudentPointsCounter
            // 
            this.LBLstudentPointsCounter.AutoSize = true;
            this.LBLstudentPointsCounter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLstudentPointsCounter.Location = new System.Drawing.Point(142, 268);
            this.LBLstudentPointsCounter.Name = "LBLstudentPointsCounter";
            this.LBLstudentPointsCounter.Size = new System.Drawing.Size(256, 22);
            this.LBLstudentPointsCounter.TabIndex = 57;
            this.LBLstudentPointsCounter.Text = "Student Currently has * Points";
            this.LBLstudentPointsCounter.Visible = false;
            // 
            // TBPointsVaryVal
            // 
            this.TBPointsVaryVal.Location = new System.Drawing.Point(195, 205);
            this.TBPointsVaryVal.Name = "TBPointsVaryVal";
            this.TBPointsVaryVal.Size = new System.Drawing.Size(138, 20);
            this.TBPointsVaryVal.TabIndex = 56;
            this.TBPointsVaryVal.Visible = false;
            // 
            // LBSearchedStudents
            // 
            this.LBSearchedStudents.DisplayMember = "studentName";
            this.LBSearchedStudents.FormattingEnabled = true;
            this.LBSearchedStudents.Location = new System.Drawing.Point(150, 75);
            this.LBSearchedStudents.MultiColumn = true;
            this.LBSearchedStudents.Name = "LBSearchedStudents";
            this.LBSearchedStudents.Size = new System.Drawing.Size(223, 95);
            this.LBSearchedStudents.TabIndex = 60;
            this.LBSearchedStudents.Visible = false;
            // 
            // teacherRatioChart
            // 
            chartArea1.Name = "ChartArea1";
            this.teacherRatioChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.teacherRatioChart.Legends.Add(legend1);
            this.teacherRatioChart.Location = new System.Drawing.Point(473, 27);
            this.teacherRatioChart.Name = "teacherRatioChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.teacherRatioChart.Series.Add(series1);
            this.teacherRatioChart.Size = new System.Drawing.Size(300, 221);
            this.teacherRatioChart.TabIndex = 64;
            this.teacherRatioChart.Text = "chart1";
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // teacherDataTableAdapter
            // 
            this.teacherDataTableAdapter.ClearBeforeFill = true;
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teacherRatioChart);
            this.Controls.Add(this.BTNDockPoints);
            this.Controls.Add(this.BTNAddPoints);
            this.Controls.Add(this.LBLSelectStudent);
            this.Controls.Add(this.TBNameSearch);
            this.Controls.Add(this.LBLNameSearch);
            this.Controls.Add(this.LBLstudentPointsCounter);
            this.Controls.Add(this.TBPointsVaryVal);
            this.Controls.Add(this.LBSearchedStudents);
            this.Controls.Add(this.menuStrip1);
            this.Name = "teacherView";
            this.Text = "Currently viewing as teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.teacherView_FormClosing);
            this.Load += new System.EventHandler(this.teacherView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRatioChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awardDockPointsToolStripMenuItem;
        private System.Windows.Forms.Button BTNDockPoints;
        private System.Windows.Forms.Button BTNAddPoints;
        private System.Windows.Forms.Label LBLSelectStudent;
        internal System.Windows.Forms.TextBox TBNameSearch;
        private System.Windows.Forms.Label LBLNameSearch;
        private System.Windows.Forms.Label LBLstudentPointsCounter;
        internal System.Windows.Forms.TextBox TBPointsVaryVal;
        internal System.Windows.Forms.ListBox LBSearchedStudents;
        private System.Windows.Forms.DataVisualization.Charting.Chart teacherRatioChart;
        private DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private DSDBTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        private DSDB dSDB;
    }
}