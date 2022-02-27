
namespace Homework_4._4
{
    partial class Homework4d
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBLetter1 = new System.Windows.Forms.TextBox();
            this.TBLetter2 = new System.Windows.Forms.TextBox();
            this.BTNRun = new System.Windows.Forms.Button();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBLetter1
            // 
            this.TBLetter1.Location = new System.Drawing.Point(13, 13);
            this.TBLetter1.Name = "TBLetter1";
            this.TBLetter1.Size = new System.Drawing.Size(100, 23);
            this.TBLetter1.TabIndex = 0;
            // 
            // TBLetter2
            // 
            this.TBLetter2.Location = new System.Drawing.Point(120, 13);
            this.TBLetter2.Name = "TBLetter2";
            this.TBLetter2.Size = new System.Drawing.Size(100, 23);
            this.TBLetter2.TabIndex = 1;
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 43);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(75, 23);
            this.BTNRun.TabIndex = 2;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(94, 47);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(45, 15);
            this.LBLOutput.TabIndex = 3;
            this.LBLOutput.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Done in c# without asc() or other functions";
            // 
            // Homework4d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.BTNRun);
            this.Controls.Add(this.TBLetter2);
            this.Controls.Add(this.TBLetter1);
            this.Name = "Homework4d";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLetter1;
        private System.Windows.Forms.TextBox TBLetter2;
        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Label LBLOutput;
        private System.Windows.Forms.Label label1;
    }
}

