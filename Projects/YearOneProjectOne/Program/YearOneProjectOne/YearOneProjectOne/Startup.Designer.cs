
namespace YearOneProjectOne
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.WMPStartup = new AxWMPLib.AxWindowsMediaPlayer();
            this.BTNLogIn = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.WMPScreensaver = new AxWMPLib.AxWindowsMediaPlayer();
            this.TBDebug = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DGVUserTable = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabase1 = new YearOneProjectOne.mainDatabase();
            this.userTableTableAdapter = new YearOneProjectOne.mainDatabaseTableAdapters.userTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPStartup
            // 
            this.WMPStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPStartup.Enabled = true;
            this.WMPStartup.Location = new System.Drawing.Point(0, 0);
            this.WMPStartup.Name = "WMPStartup";
            this.WMPStartup.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPStartup.OcxState")));
            this.WMPStartup.Size = new System.Drawing.Size(800, 450);
            this.WMPStartup.TabIndex = 1;
            this.WMPStartup.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.WMPStartup.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // BTNLogIn
            // 
            this.BTNLogIn.Location = new System.Drawing.Point(360, 415);
            this.BTNLogIn.Name = "BTNLogIn";
            this.BTNLogIn.Size = new System.Drawing.Size(75, 23);
            this.BTNLogIn.TabIndex = 2;
            this.BTNLogIn.Text = "Log In";
            this.BTNLogIn.UseVisualStyleBackColor = true;
            this.BTNLogIn.Click += new System.EventHandler(this.BTNLogIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(346, 389);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Text = "Password";
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.Click += new System.EventHandler(this.TBPassword_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(346, 363);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 4;
            this.TBUsername.Text = "Username";
            this.TBUsername.Click += new System.EventHandler(this.TBUsername_Click);
            // 
            // WMPScreensaver
            // 
            this.WMPScreensaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPScreensaver.Enabled = true;
            this.WMPScreensaver.Location = new System.Drawing.Point(0, 0);
            this.WMPScreensaver.Name = "WMPScreensaver";
            this.WMPScreensaver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPScreensaver.OcxState")));
            this.WMPScreensaver.Size = new System.Drawing.Size(800, 450);
            this.WMPScreensaver.TabIndex = 7;
            this.WMPScreensaver.Visible = false;
            // 
            // TBDebug
            // 
            this.TBDebug.Location = new System.Drawing.Point(665, 363);
            this.TBDebug.Name = "TBDebug";
            this.TBDebug.Size = new System.Drawing.Size(100, 20);
            this.TBDebug.TabIndex = 8;
            // 
            // DGVUserTable
            // 
            this.DGVUserTable.AutoGenerateColumns = false;
            this.DGVUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.schoolIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userLevelDataGridViewTextBoxColumn});
            this.DGVUserTable.DataSource = this.userTableBindingSource;
            this.DGVUserTable.Location = new System.Drawing.Point(12, 12);
            this.DGVUserTable.Name = "DGVUserTable";
            this.DGVUserTable.Size = new System.Drawing.Size(240, 150);
            this.DGVUserTable.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "SchoolID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "SchoolID";
            this.schoolIDDataGridViewTextBoxColumn.Name = "schoolIDDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userLevelDataGridViewTextBoxColumn
            // 
            this.userLevelDataGridViewTextBoxColumn.DataPropertyName = "UserLevel";
            this.userLevelDataGridViewTextBoxColumn.HeaderText = "UserLevel";
            this.userLevelDataGridViewTextBoxColumn.Name = "userLevelDataGridViewTextBoxColumn";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.mainDatabase1;
            // 
            // mainDatabase1
            // 
            this.mainDatabase1.DataSetName = "mainDatabase";
            this.mainDatabase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVUserTable);
            this.Controls.Add(this.TBDebug);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTNLogIn);
            this.Controls.Add(this.WMPScreensaver);
            this.Controls.Add(this.WMPStartup);
            this.Name = "Startup";
            this.Text = "Login To Continue";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer WMPStartup;
        private System.Windows.Forms.Button BTNLogIn;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private AxWMPLib.AxWindowsMediaPlayer WMPScreensaver;
        private System.Windows.Forms.TextBox TBDebug;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private mainDatabase mainDatabase1;
        private System.Windows.Forms.DataGridView DGVUserTable;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private mainDatabaseTableAdapters.userTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLevelDataGridViewTextBoxColumn;
    }
}

