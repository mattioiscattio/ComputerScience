
namespace Homework_3._1
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
            this.TBInput = new System.Windows.Forms.TextBox();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(12, 12);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 20);
            this.TBInput.TabIndex = 0;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(118, 19);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(127, 13);
            this.LBLOutput.TabIndex = 1;
            this.LBLOutput.Text = "Enter Water Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.TBInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label LBLOutput;
    }
}

