
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
            this.LBLDebug = new System.Windows.Forms.Label();
            this.dSDB = new YearOneProjectOne.DSDB();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(13, 13);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(35, 13);
            this.LBLDebug.TabIndex = 0;
            this.LBLDebug.Text = "label1";
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.Namespace = "http://tempuri.org/DSDB.xsd";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLDebug);
            this.Name = "studentView";
            this.Text = "Currently viewing as student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentView_FormClosing);
            this.Load += new System.EventHandler(this.studentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLDebug;
        private DSDB dSDB;
    }
}