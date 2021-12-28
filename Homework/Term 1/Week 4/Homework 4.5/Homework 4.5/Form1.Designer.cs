
namespace Homework_4._5
{
    partial class HW4B
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
            this.BTNEnterNum = new System.Windows.Forms.Button();
            this.TBNumInput = new System.Windows.Forms.TextBox();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNEnterNum
            // 
            this.BTNEnterNum.Location = new System.Drawing.Point(13, 13);
            this.BTNEnterNum.Name = "BTNEnterNum";
            this.BTNEnterNum.Size = new System.Drawing.Size(75, 23);
            this.BTNEnterNum.TabIndex = 0;
            this.BTNEnterNum.Text = "Input";
            this.BTNEnterNum.UseVisualStyleBackColor = true;
            this.BTNEnterNum.Click += new System.EventHandler(this.BTNEnterNum_Click);
            // 
            // TBNumInput
            // 
            this.TBNumInput.Location = new System.Drawing.Point(95, 15);
            this.TBNumInput.Name = "TBNumInput";
            this.TBNumInput.Size = new System.Drawing.Size(100, 20);
            this.TBNumInput.TabIndex = 1;
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Location = new System.Drawing.Point(13, 43);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(13, 13);
            this.LBLOutput.TabIndex = 2;
            this.LBLOutput.Text = "0";
            // 
            // HW4B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.TBNumInput);
            this.Controls.Add(this.BTNEnterNum);
            this.Name = "HW4B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNEnterNum;
        private System.Windows.Forms.TextBox TBNumInput;
        private System.Windows.Forms.Label LBLOutput;
    }
}

