
namespace Homework_3._5
{
    partial class Form1
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
            this.TBDay = new System.Windows.Forms.TextBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.TBMonth = new System.Windows.Forms.TextBox();
            this.BTNRun = new System.Windows.Forms.Button();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBDay
            // 
            this.TBDay.Location = new System.Drawing.Point(12, 12);
            this.TBDay.Name = "TBDay";
            this.TBDay.Size = new System.Drawing.Size(100, 20);
            this.TBDay.TabIndex = 0;
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(12, 64);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(100, 20);
            this.TBYear.TabIndex = 1;
            // 
            // TBMonth
            // 
            this.TBMonth.Location = new System.Drawing.Point(12, 38);
            this.TBMonth.Name = "TBMonth";
            this.TBMonth.Size = new System.Drawing.Size(100, 20);
            this.TBMonth.TabIndex = 2;
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 91);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 3;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(119, 13);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(63, 13);
            this.LBLOutput.TabIndex = 4;
            this.LBLOutput.Text = "The Date Is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.BTNRun);
            this.Controls.Add(this.TBMonth);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDay;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.TextBox TBMonth;
        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Label LBLOutput;
    }
}

