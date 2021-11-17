
namespace Homework_4._1
{
    partial class Homework4b
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
            this.TBInput = new System.Windows.Forms.TextBox();
            this.LBOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(13, 13);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(128, 23);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Input More Numbers";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(12, 42);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 23);
            this.TBInput.TabIndex = 1;
            // 
            // LBOutput
            // 
            this.LBOutput.AutoSize = true;
            this.LBOutput.Location = new System.Drawing.Point(13, 73);
            this.LBOutput.Name = "LBOutput";
            this.LBOutput.Size = new System.Drawing.Size(45, 15);
            this.LBOutput.TabIndex = 2;
            this.LBOutput.Text = "Output";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(147, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Due to the use of C# input boxes are not available easily, so when 0 is inputted " +
    "by pressing the button the button is hidden.";
            // 
            // Homework4b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBOutput);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.BTNRun);
            this.Name = "Homework4b";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label LBOutput;
        private System.Windows.Forms.Label label1;
    }
}

