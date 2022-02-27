
namespace MultiFormProject
{
    partial class FRMLogin
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
            this.components = new System.ComponentModel.Container();
            this.BTNLoginExit = new System.Windows.Forms.Button();
            this.BTNEnter = new System.Windows.Forms.Button();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPasswd = new System.Windows.Forms.TextBox();
            this.LBLUsername = new System.Windows.Forms.Label();
            this.LBLPasswd = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSDB = new MultiFormProject.DSDB();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new MultiFormProject.DSDBTableAdapters.Table1TableAdapter();
            this.LBLDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNLoginExit
            // 
            this.BTNLoginExit.Location = new System.Drawing.Point(184, 2);
            this.BTNLoginExit.Name = "BTNLoginExit";
            this.BTNLoginExit.Size = new System.Drawing.Size(75, 23);
            this.BTNLoginExit.TabIndex = 0;
            this.BTNLoginExit.Text = "Exit";
            this.BTNLoginExit.UseVisualStyleBackColor = true;
            this.BTNLoginExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNEnter
            // 
            this.BTNEnter.Location = new System.Drawing.Point(12, 93);
            this.BTNEnter.Name = "BTNEnter";
            this.BTNEnter.Size = new System.Drawing.Size(75, 23);
            this.BTNEnter.TabIndex = 1;
            this.BTNEnter.Text = "Enter";
            this.BTNEnter.UseVisualStyleBackColor = true;
            this.BTNEnter.Click += new System.EventHandler(this.BTNEnter_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(12, 28);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 2;
            // 
            // TBPasswd
            // 
            this.TBPasswd.Location = new System.Drawing.Point(12, 67);
            this.TBPasswd.Name = "TBPasswd";
            this.TBPasswd.Size = new System.Drawing.Size(100, 20);
            this.TBPasswd.TabIndex = 3;
            // 
            // LBLUsername
            // 
            this.LBLUsername.AutoSize = true;
            this.LBLUsername.Location = new System.Drawing.Point(9, 12);
            this.LBLUsername.Name = "LBLUsername";
            this.LBLUsername.Size = new System.Drawing.Size(53, 13);
            this.LBLUsername.TabIndex = 4;
            this.LBLUsername.Text = "username";
            // 
            // LBLPasswd
            // 
            this.LBLPasswd.AutoSize = true;
            this.LBLPasswd.Location = new System.Drawing.Point(12, 51);
            this.LBLPasswd.Name = "LBLPasswd";
            this.LBLPasswd.Size = new System.Drawing.Size(53, 13);
            this.LBLPasswd.TabIndex = 5;
            this.LBLPasswd.Text = "Password";
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.dSDB;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(113, 179);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(39, 13);
            this.LBLDebug.TabIndex = 6;
            this.LBLDebug.Text = "Debug";
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 271);
            this.ControlBox = false;
            this.Controls.Add(this.LBLDebug);
            this.Controls.Add(this.LBLPasswd);
            this.Controls.Add(this.LBLUsername);
            this.Controls.Add(this.TBPasswd);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.BTNEnter);
            this.Controls.Add(this.BTNLoginExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRMLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNLoginExit;
        private System.Windows.Forms.Button BTNEnter;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPasswd;
        private System.Windows.Forms.Label LBLUsername;
        private System.Windows.Forms.Label LBLPasswd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DSDB dSDB;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private DSDBTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.Label LBLDebug;
    }
}