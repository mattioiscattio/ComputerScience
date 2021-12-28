
namespace Homework_Week2._3
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
            this.LBLKG = new System.Windows.Forms.Label();
            this.BTNKG = new System.Windows.Forms.Button();
            this.LBLCm = new System.Windows.Forms.Label();
            this.BTNCm = new System.Windows.Forms.Button();
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
            // LBLKG
            // 
            this.LBLKG.AutoSize = true;
            this.LBLKG.Location = new System.Drawing.Point(12, 35);
            this.LBLKG.Name = "LBLKG";
            this.LBLKG.Size = new System.Drawing.Size(63, 13);
            this.LBLKG.TabIndex = 1;
            this.LBLKG.Text = "Enter Stone";
            this.LBLKG.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNKG
            // 
            this.BTNKG.Location = new System.Drawing.Point(118, 30);
            this.BTNKG.Name = "BTNKG";
            this.BTNKG.Size = new System.Drawing.Size(100, 23);
            this.BTNKG.TabIndex = 2;
            this.BTNKG.Text = "Convert to KG";
            this.BTNKG.UseVisualStyleBackColor = true;
            this.BTNKG.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // LBLCm
            // 
            this.LBLCm.AutoSize = true;
            this.LBLCm.Location = new System.Drawing.Point(12, 61);
            this.LBLCm.Name = "LBLCm";
            this.LBLCm.Size = new System.Drawing.Size(67, 13);
            this.LBLCm.TabIndex = 3;
            this.LBLCm.Text = "Enter Inches";
            // 
            // BTNCm
            // 
            this.BTNCm.Location = new System.Drawing.Point(118, 56);
            this.BTNCm.Name = "BTNCm";
            this.BTNCm.Size = new System.Drawing.Size(100, 23);
            this.BTNCm.TabIndex = 4;
            this.BTNCm.Text = "Conver to cm";
            this.BTNCm.UseVisualStyleBackColor = true;
            this.BTNCm.Click += new System.EventHandler(this.BTNCm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCm);
            this.Controls.Add(this.LBLCm);
            this.Controls.Add(this.BTNKG);
            this.Controls.Add(this.LBLKG);
            this.Controls.Add(this.TBInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label LBLKG;
        private System.Windows.Forms.Button BTNKG;
        private System.Windows.Forms.Label LBLCm;
        private System.Windows.Forms.Button BTNCm;
    }
}

