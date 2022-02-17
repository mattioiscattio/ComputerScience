
namespace YearOneProjectOne
{
    partial class adminView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDB = new YearOneProjectOne.DSDB();
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.studentPointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.dSDB;
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.Namespace = "http://tempuri.org/DSDB.xsd";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // studentPointsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.studentPointsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.studentPointsChart.Legends.Add(legend1);
            this.studentPointsChart.Location = new System.Drawing.Point(13, 28);
            this.studentPointsChart.Name = "studentPointsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.studentPointsChart.Series.Add(series1);
            this.studentPointsChart.Size = new System.Drawing.Size(300, 300);
            this.studentPointsChart.TabIndex = 1;
            this.studentPointsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPointsChart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminView";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminView_FormClosing_1);
            this.Load += new System.EventHandler(this.adminView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DSDB dSDB;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentPointsChart;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}