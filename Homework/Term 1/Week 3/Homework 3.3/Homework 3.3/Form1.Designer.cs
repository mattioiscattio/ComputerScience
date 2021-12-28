
namespace Homework_3._3
{
    partial class Homework3c
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
            this.TBInput = new System.Windows.Forms.TextBox();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 54);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(13, 28);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 20);
            this.TBInput.TabIndex = 1;
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(12, 9);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(39, 13);
            this.LBLOutput.TabIndex = 2;
            this.LBLOutput.Text = "Output";
            // 
            // Homework3c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.BTNRun);
            this.Name = "Homework3c";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label LBLOutput;
    }
}

