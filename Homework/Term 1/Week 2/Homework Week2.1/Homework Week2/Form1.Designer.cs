
namespace Homework_Week2
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
            this.TBInput1 = new System.Windows.Forms.TextBox();
            this.BTNRun = new System.Windows.Forms.Button();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBInput1
            // 
            this.TBInput1.Location = new System.Drawing.Point(12, 12);
            this.TBInput1.Name = "TBInput1";
            this.TBInput1.Size = new System.Drawing.Size(100, 20);
            this.TBInput1.TabIndex = 0;
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 39);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 1;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(12, 65);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(82, 13);
            this.LBLOutput.TabIndex = 2;
            this.LBLOutput.Text = "EnterYourName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.BTNRun);
            this.Controls.Add(this.TBInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput1;
        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Label LBLOutput;
    }
}

