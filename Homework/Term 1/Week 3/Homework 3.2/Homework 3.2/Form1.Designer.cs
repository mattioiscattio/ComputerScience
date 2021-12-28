
namespace Homework_3._2
{
    partial class Homework3b
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
            this.TBInputHours = new System.Windows.Forms.TextBox();
            this.LBLHours = new System.Windows.Forms.Label();
            this.TBInputRate = new System.Windows.Forms.TextBox();
            this.LBLRate = new System.Windows.Forms.Label();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.BTNRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBInputHours
            // 
            this.TBInputHours.Location = new System.Drawing.Point(12, 12);
            this.TBInputHours.Name = "TBInputHours";
            this.TBInputHours.Size = new System.Drawing.Size(100, 20);
            this.TBInputHours.TabIndex = 0;
            this.TBInputHours.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // LBLHours
            // 
            this.LBLHours.AutoSize = true;
            this.LBLHours.Location = new System.Drawing.Point(119, 18);
            this.LBLHours.Name = "LBLHours";
            this.LBLHours.Size = new System.Drawing.Size(104, 13);
            this.LBLHours.TabIndex = 1;
            this.LBLHours.Text = "Enter Hours Worked";
            // 
            // TBInputRate
            // 
            this.TBInputRate.Location = new System.Drawing.Point(13, 39);
            this.TBInputRate.Name = "TBInputRate";
            this.TBInputRate.Size = new System.Drawing.Size(100, 20);
            this.TBInputRate.TabIndex = 2;
            // 
            // LBLRate
            // 
            this.LBLRate.AutoSize = true;
            this.LBLRate.Location = new System.Drawing.Point(120, 45);
            this.LBLRate.Name = "LBLRate";
            this.LBLRate.Size = new System.Drawing.Size(58, 13);
            this.LBLRate.TabIndex = 3;
            this.LBLRate.Text = "Enter Rate";
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(119, 73);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(87, 13);
            this.LBLOutput.TabIndex = 4;
            this.LBLOutput.Text = "Whats your pay?";
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 68);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 5;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // Homework3b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNRun);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.LBLRate);
            this.Controls.Add(this.TBInputRate);
            this.Controls.Add(this.LBLHours);
            this.Controls.Add(this.TBInputHours);
            this.Name = "Homework3b";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInputHours;
        private System.Windows.Forms.Label LBLHours;
        private System.Windows.Forms.TextBox TBInputRate;
        private System.Windows.Forms.Label LBLRate;
        private System.Windows.Forms.Label LBLOutput;
        private System.Windows.Forms.Button BTNRun;
    }
}

