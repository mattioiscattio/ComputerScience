
namespace YearOneProjectOne
{
    partial class studentView
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
            this.LBLDebug = new System.Windows.Forms.Label();
            this.dSDB = new YearOneProjectOne.DSDB();
            this.ChrtStudentPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStudentPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(707, 412);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(35, 13);
            this.LBLDebug.TabIndex = 0;
            this.LBLDebug.Text = "label1";
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChrtStudentPoints
            // 
            chartArea1.Name = "ChartArea1";
            this.ChrtStudentPoints.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChrtStudentPoints.Legends.Add(legend1);
            this.ChrtStudentPoints.Location = new System.Drawing.Point(270, 91);
            this.ChrtStudentPoints.Name = "ChrtStudentPoints";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChrtStudentPoints.Series.Add(series1);
            this.ChrtStudentPoints.Size = new System.Drawing.Size(300, 300);
            this.ChrtStudentPoints.TabIndex = 1;
            this.ChrtStudentPoints.Text = "chart1";
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YearOneProjectOne.Properties.Resources.colorGradientGuestView;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChrtStudentPoints);
            this.Controls.Add(this.LBLDebug);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentView";
            this.Text = "Currently viewing as student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentView_FormClosing);
            this.Load += new System.EventHandler(this.studentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStudentPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLDebug;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtStudentPoints;
        internal DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        internal System.Windows.Forms.BindingSource bindingSource1;
        internal DSDB dSDB;
    }
}