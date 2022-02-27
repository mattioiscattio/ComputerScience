
namespace YearOneProjectOne
{
    partial class guestView
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
            this.guestViewPointsPieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.guestViewPointsPieGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // guestViewPointsPieGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.guestViewPointsPieGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.guestViewPointsPieGraph.Legends.Add(legend1);
            this.guestViewPointsPieGraph.Location = new System.Drawing.Point(377, 66);
            this.guestViewPointsPieGraph.Name = "guestViewPointsPieGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.guestViewPointsPieGraph.Series.Add(series1);
            this.guestViewPointsPieGraph.Size = new System.Drawing.Size(300, 300);
            this.guestViewPointsPieGraph.TabIndex = 0;
            this.guestViewPointsPieGraph.Text = "chart1";
            // 
            // guestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YearOneProjectOne.Properties.Resources.guestViewBackgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guestViewPointsPieGraph);
            this.Name = "guestView";
            this.Text = "Currently viewing as guest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.guestView_FormClosing);
            this.Load += new System.EventHandler(this.guestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestViewPointsPieGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart guestViewPointsPieGraph;
    }
}