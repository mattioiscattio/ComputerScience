
namespace Homework_4._2
{
    partial class Heomwork4b
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
            this.BTNRun = new System.Windows.Forms.Button();
            this.LBOutput = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 13);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(202, 23);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Enter a number between 10 and 20";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBOutput
            // 
            this.LBOutput.AutoSize = true;
            this.LBOutput.Location = new System.Drawing.Point(12, 69);
            this.LBOutput.Name = "LBOutput";
            this.LBOutput.Size = new System.Drawing.Size(45, 15);
            this.LBOutput.TabIndex = 1;
            this.LBOutput.Text = "Output";
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(13, 43);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 23);
            this.TBInput.TabIndex = 2;
            // 
            // Heomwork4b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.LBOutput);
            this.Controls.Add(this.BTNRun);
            this.Name = "Heomwork4b";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Label LBOutput;
        private System.Windows.Forms.TextBox TBInput;
    }
}

