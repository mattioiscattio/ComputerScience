
namespace Homework2._4
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
            this.TBLength = new System.Windows.Forms.TextBox();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBDepth2 = new System.Windows.Forms.TextBox();
            this.TBDepth1 = new System.Windows.Forms.TextBox();
            this.LBOutput = new System.Windows.Forms.Label();
            this.BTNInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBLength
            // 
            this.TBLength.Location = new System.Drawing.Point(12, 90);
            this.TBLength.Name = "TBLength";
            this.TBLength.Size = new System.Drawing.Size(100, 20);
            this.TBLength.TabIndex = 0;
            this.TBLength.Text = "Enter Length";
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(12, 64);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(100, 20);
            this.TBWidth.TabIndex = 1;
            this.TBWidth.Text = "Enter Width";
            // 
            // TBDepth2
            // 
            this.TBDepth2.Location = new System.Drawing.Point(12, 38);
            this.TBDepth2.Name = "TBDepth2";
            this.TBDepth2.Size = new System.Drawing.Size(100, 20);
            this.TBDepth2.TabIndex = 2;
            this.TBDepth2.Text = "Enter Depth2";
            this.TBDepth2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TBDepth1
            // 
            this.TBDepth1.Location = new System.Drawing.Point(12, 12);
            this.TBDepth1.Name = "TBDepth1";
            this.TBDepth1.Size = new System.Drawing.Size(100, 20);
            this.TBDepth1.TabIndex = 3;
            this.TBDepth1.Text = "Enter Depth1";
            // 
            // LBOutput
            // 
            this.LBOutput.AutoSize = true;
            this.LBOutput.Location = new System.Drawing.Point(12, 117);
            this.LBOutput.Name = "LBOutput";
            this.LBOutput.Size = new System.Drawing.Size(39, 13);
            this.LBOutput.TabIndex = 4;
            this.LBOutput.Text = "Output";
            this.LBOutput.Click += new System.EventHandler(this.LBOutput_Click);
            // 
            // BTNInput
            // 
            this.BTNInput.Location = new System.Drawing.Point(118, 12);
            this.BTNInput.Name = "BTNInput";
            this.BTNInput.Size = new System.Drawing.Size(75, 23);
            this.BTNInput.TabIndex = 5;
            this.BTNInput.Text = "Run";
            this.BTNInput.UseVisualStyleBackColor = true;
            this.BTNInput.Click += new System.EventHandler(this.BTNInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNInput);
            this.Controls.Add(this.LBOutput);
            this.Controls.Add(this.TBDepth1);
            this.Controls.Add(this.TBDepth2);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.TBLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLength;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.TextBox TBDepth2;
        private System.Windows.Forms.TextBox TBDepth1;
        private System.Windows.Forms.Label LBOutput;
        private System.Windows.Forms.Button BTNInput;
    }
}

