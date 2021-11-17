
namespace Homework2._5
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
            this.LBLOutput = new System.Windows.Forms.Label();
            this.BTNInput = new System.Windows.Forms.Button();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBLength = new System.Windows.Forms.TextBox();
            this.LBLWidth = new System.Windows.Forms.Label();
            this.LBLLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(12, 61);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(39, 13);
            this.LBLOutput.TabIndex = 0;
            this.LBLOutput.Text = "Output";
            // 
            // BTNInput
            // 
            this.BTNInput.Location = new System.Drawing.Point(163, 10);
            this.BTNInput.Name = "BTNInput";
            this.BTNInput.Size = new System.Drawing.Size(75, 23);
            this.BTNInput.TabIndex = 1;
            this.BTNInput.Text = "Run";
            this.BTNInput.UseVisualStyleBackColor = true;
            this.BTNInput.Click += new System.EventHandler(this.BTNInput_Click);
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(12, 38);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(100, 20);
            this.TBWidth.TabIndex = 2;
            // 
            // TBLength
            // 
            this.TBLength.Location = new System.Drawing.Point(12, 12);
            this.TBLength.Name = "TBLength";
            this.TBLength.Size = new System.Drawing.Size(100, 20);
            this.TBLength.TabIndex = 3;
            // 
            // LBLWidth
            // 
            this.LBLWidth.AutoSize = true;
            this.LBLWidth.Location = new System.Drawing.Point(118, 41);
            this.LBLWidth.Name = "LBLWidth";
            this.LBLWidth.Size = new System.Drawing.Size(35, 13);
            this.LBLWidth.TabIndex = 4;
            this.LBLWidth.Text = "Width";
            // 
            // LBLLength
            // 
            this.LBLLength.AutoSize = true;
            this.LBLLength.Location = new System.Drawing.Point(118, 15);
            this.LBLLength.Name = "LBLLength";
            this.LBLLength.Size = new System.Drawing.Size(40, 13);
            this.LBLLength.TabIndex = 5;
            this.LBLLength.Text = "Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLLength);
            this.Controls.Add(this.LBLWidth);
            this.Controls.Add(this.TBLength);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.BTNInput);
            this.Controls.Add(this.LBLOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLOutput;
        private System.Windows.Forms.Button BTNInput;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.TextBox TBLength;
        private System.Windows.Forms.Label LBLWidth;
        private System.Windows.Forms.Label LBLLength;
    }
}

