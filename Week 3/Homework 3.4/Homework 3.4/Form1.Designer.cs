
namespace Homework_3._4
{
    partial class HW3D
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
            this.BTNRun = new System.Windows.Forms.Button();
            this.LBLMonthOutput = new System.Windows.Forms.Label();
            this.LBLYearOutput = new System.Windows.Forms.Label();
            this.TBYearNum = new System.Windows.Forms.TextBox();
            this.TBMonthNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 68);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBLMonthOutput
            // 
            this.LBLMonthOutput.AutoSize = true;
            this.LBLMonthOutput.Location = new System.Drawing.Point(118, 15);
            this.LBLMonthOutput.Name = "LBLMonthOutput";
            this.LBLMonthOutput.Size = new System.Drawing.Size(76, 13);
            this.LBLMonthOutput.TabIndex = 1;
            this.LBLMonthOutput.Text = "Days In Month";
            // 
            // LBLYearOutput
            // 
            this.LBLYearOutput.AutoSize = true;
            this.LBLYearOutput.Location = new System.Drawing.Point(118, 41);
            this.LBLYearOutput.Name = "LBLYearOutput";
            this.LBLYearOutput.Size = new System.Drawing.Size(56, 13);
            this.LBLYearOutput.TabIndex = 2;
            this.LBLYearOutput.Text = "Leap Year";
            // 
            // TBYearNum
            // 
            this.TBYearNum.Location = new System.Drawing.Point(13, 38);
            this.TBYearNum.Name = "TBYearNum";
            this.TBYearNum.Size = new System.Drawing.Size(100, 20);
            this.TBYearNum.TabIndex = 3;
            // 
            // TBMonthNum
            // 
            this.TBMonthNum.Location = new System.Drawing.Point(12, 12);
            this.TBMonthNum.Name = "TBMonthNum";
            this.TBMonthNum.Size = new System.Drawing.Size(100, 20);
            this.TBMonthNum.TabIndex = 4;
            // 
            // HW3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBMonthNum);
            this.Controls.Add(this.TBYearNum);
            this.Controls.Add(this.LBLYearOutput);
            this.Controls.Add(this.LBLMonthOutput);
            this.Controls.Add(this.BTNRun);
            this.Name = "HW3D";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Label LBLMonthOutput;
        private System.Windows.Forms.Label LBLYearOutput;
        private System.Windows.Forms.TextBox TBYearNum;
        private System.Windows.Forms.TextBox TBMonthNum;
    }
}

