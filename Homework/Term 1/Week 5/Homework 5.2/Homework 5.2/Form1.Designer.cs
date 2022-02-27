
namespace Homework_5._2
{
    partial class HW5B
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
            this.LBLExamMark = new System.Windows.Forms.Label();
            this.LBLMean = new System.Windows.Forms.Label();
            this.TBinput = new System.Windows.Forms.TextBox();
            this.TBmean = new System.Windows.Forms.TextBox();
            this.BTNok = new System.Windows.Forms.Button();
            this.BTNmean = new System.Windows.Forms.Button();
            this.BTNquit = new System.Windows.Forms.Button();
            this.marksList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBLExamMark
            // 
            this.LBLExamMark.AutoSize = true;
            this.LBLExamMark.Location = new System.Drawing.Point(13, 13);
            this.LBLExamMark.Name = "LBLExamMark";
            this.LBLExamMark.Size = new System.Drawing.Size(109, 16);
            this.LBLExamMark.TabIndex = 0;
            this.LBLExamMark.Text = "Enter Exam Mark";
            // 
            // LBLMean
            // 
            this.LBLMean.AutoSize = true;
            this.LBLMean.Location = new System.Drawing.Point(13, 38);
            this.LBLMean.Name = "LBLMean";
            this.LBLMean.Size = new System.Drawing.Size(112, 16);
            this.LBLMean.TabIndex = 1;
            this.LBLMean.Text = "Mean Exam Mark";
            this.LBLMean.Visible = false;
            // 
            // TBinput
            // 
            this.TBinput.Location = new System.Drawing.Point(128, 10);
            this.TBinput.Name = "TBinput";
            this.TBinput.Size = new System.Drawing.Size(100, 22);
            this.TBinput.TabIndex = 2;
            this.TBinput.TextChanged += new System.EventHandler(this.TBinput_TextChanged);
            // 
            // TBmean
            // 
            this.TBmean.Location = new System.Drawing.Point(128, 35);
            this.TBmean.Name = "TBmean";
            this.TBmean.Size = new System.Drawing.Size(100, 22);
            this.TBmean.TabIndex = 3;
            this.TBmean.WordWrap = false;
            // 
            // BTNok
            // 
            this.BTNok.Enabled = false;
            this.BTNok.Location = new System.Drawing.Point(284, 13);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(138, 23);
            this.BTNok.TabIndex = 4;
            this.BTNok.Text = "OK";
            this.BTNok.UseVisualStyleBackColor = true;
            this.BTNok.Click += new System.EventHandler(this.BTNok_Click);
            // 
            // BTNmean
            // 
            this.BTNmean.Enabled = false;
            this.BTNmean.Location = new System.Drawing.Point(284, 42);
            this.BTNmean.Name = "BTNmean";
            this.BTNmean.Size = new System.Drawing.Size(138, 23);
            this.BTNmean.TabIndex = 5;
            this.BTNmean.Text = "Show Mean";
            this.BTNmean.UseVisualStyleBackColor = true;
            this.BTNmean.Click += new System.EventHandler(this.BTNmean_Click);
            // 
            // BTNquit
            // 
            this.BTNquit.Location = new System.Drawing.Point(284, 71);
            this.BTNquit.Name = "BTNquit";
            this.BTNquit.Size = new System.Drawing.Size(138, 23);
            this.BTNquit.TabIndex = 6;
            this.BTNquit.Text = "Quit";
            this.BTNquit.UseVisualStyleBackColor = true;
            this.BTNquit.Click += new System.EventHandler(this.BTNquit_Click);
            // 
            // marksList
            // 
            this.marksList.FormattingEnabled = true;
            this.marksList.ItemHeight = 16;
            this.marksList.Location = new System.Drawing.Point(439, 10);
            this.marksList.Name = "marksList";
            this.marksList.Size = new System.Drawing.Size(120, 84);
            this.marksList.TabIndex = 7;
            // 
            // HW5B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.marksList);
            this.Controls.Add(this.BTNquit);
            this.Controls.Add(this.BTNmean);
            this.Controls.Add(this.BTNok);
            this.Controls.Add(this.TBmean);
            this.Controls.Add(this.TBinput);
            this.Controls.Add(this.LBLMean);
            this.Controls.Add(this.LBLExamMark);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HW5B";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HW5B_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLExamMark;
        private System.Windows.Forms.Label LBLMean;
        private System.Windows.Forms.TextBox TBinput;
        private System.Windows.Forms.TextBox TBmean;
        private System.Windows.Forms.Button BTNok;
        private System.Windows.Forms.Button BTNmean;
        private System.Windows.Forms.Button BTNquit;
        private System.Windows.Forms.ListBox marksList;
    }
}

