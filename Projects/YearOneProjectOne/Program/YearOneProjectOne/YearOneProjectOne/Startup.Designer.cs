
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
            this.BTNGuestLogin = new System.Windows.Forms.Button();
            this.userTableTableAdapter = new YearOneProjectOne.mainDatabaseTableAdapters.userTableTableAdapter();
            this.teacherDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGVteacherData = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsAwardedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDockedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataTableAdapter = new YearOneProjectOne.mainDatabaseTableAdapters.teacherDataTableAdapter();
            this.LBLloggedInUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherData)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNLogIn
            // 
            this.BTNLogIn.BackColor = System.Drawing.Color.LawnGreen;
            this.BTNLogIn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogIn.Location = new System.Drawing.Point(532, 518);
            this.BTNLogIn.Name = "BTNLogIn";
            this.BTNLogIn.Size = new System.Drawing.Size(206, 37);
            this.BTNLogIn.TabIndex = 2;
            this.BTNLogIn.Text = "Log In";
            this.BTNLogIn.UseVisualStyleBackColor = false;
            this.BTNLogIn.Click += new System.EventHandler(this.BTNLogIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.AcceptsTab = true;
            this.TBPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.TBPassword.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(532, 475);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(206, 37);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Text = "Password";
            this.TBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.Click += new System.EventHandler(this.TBPassword_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.AcceptsTab = true;
            this.TBUsername.BackColor = System.Drawing.Color.PowderBlue;
            this.TBUsername.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.Location = new System.Drawing.Point(532, 432);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(206, 37);
            this.TBUsername.TabIndex = 4;
            this.TBUsername.Text = "Username";
            this.TBUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsername.Click += new System.EventHandler(this.TBUsername_Click);
            // 
            // WMPScreensaver
            // 
            this.WMPScreensaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPScreensaver.Enabled = true;
            this.WMPScreensaver.Location = new System.Drawing.Point(0, 0);
            this.WMPScreensaver.Name = "WMPScreensaver";
            this.WMPScreensaver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPScreensaver.OcxState")));
            this.WMPScreensaver.Size = new System.Drawing.Size(1264, 681);
            this.WMPScreensaver.TabIndex = 7;
            // 
            // TBDebug
            // 
            this.TBDebug.Location = new System.Drawing.Point(1101, 578);
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
            this.DGVUserTable.Visible = false;
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
            // BTNGuestLogin
            // 
            this.BTNGuestLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.BTNGuestLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuestLogin.Location = new System.Drawing.Point(515, 561);
            this.BTNGuestLogin.Name = "BTNGuestLogin";
            this.BTNGuestLogin.Size = new System.Drawing.Size(235, 52);
            this.BTNGuestLogin.TabIndex = 10;
            this.BTNGuestLogin.Text = "Login As Guest";
            this.BTNGuestLogin.UseVisualStyleBackColor = false;
            this.BTNGuestLogin.Click += new System.EventHandler(this.BTNGuestLogin_Click);
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // teacherDataBindingSource
            // 
            this.teacherDataBindingSource.DataMember = "teacherData";
            this.teacherDataBindingSource.DataSource = this.mainDatabase1;
            // 
            // DGVteacherData
            // 
            this.DGVteacherData.AutoGenerateColumns = false;
            this.DGVteacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVteacherData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherDOBDataGridViewTextBoxColumn,
            this.pointsAwardedDataGridViewTextBoxColumn,
            this.pointsDockedDataGridViewTextBoxColumn});
            this.DGVteacherData.DataSource = this.teacherDataBindingSource;
            this.DGVteacherData.Location = new System.Drawing.Point(506, 13);
            this.DGVteacherData.Name = "DGVteacherData";
            this.DGVteacherData.Size = new System.Drawing.Size(240, 150);
            this.DGVteacherData.TabIndex = 12;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "teacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "teacherName";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // teacherDOBDataGridViewTextBoxColumn
            // 
            this.teacherDOBDataGridViewTextBoxColumn.DataPropertyName = "teacherDOB";
            this.teacherDOBDataGridViewTextBoxColumn.HeaderText = "teacherDOB";
            this.teacherDOBDataGridViewTextBoxColumn.Name = "teacherDOBDataGridViewTextBoxColumn";
            // 
            // pointsAwardedDataGridViewTextBoxColumn
            // 
            this.pointsAwardedDataGridViewTextBoxColumn.DataPropertyName = "Points Awarded";
            this.pointsAwardedDataGridViewTextBoxColumn.HeaderText = "Points Awarded";
            this.pointsAwardedDataGridViewTextBoxColumn.Name = "pointsAwardedDataGridViewTextBoxColumn";
            // 
            // pointsDockedDataGridViewTextBoxColumn
            // 
            this.pointsDockedDataGridViewTextBoxColumn.DataPropertyName = "Points Docked";
            this.pointsDockedDataGridViewTextBoxColumn.HeaderText = "Points Docked";
            this.pointsDockedDataGridViewTextBoxColumn.Name = "pointsDockedDataGridViewTextBoxColumn";
            // 
            // teacherDataTableAdapter
            // 
            this.teacherDataTableAdapter.ClearBeforeFill = true;
            // 
            // LBLloggedInUser
            // 
            this.LBLloggedInUser.AutoSize = true;
            this.LBLloggedInUser.Location = new System.Drawing.Point(13, 169);
            this.LBLloggedInUser.Name = "LBLloggedInUser";
            this.LBLloggedInUser.Size = new System.Drawing.Size(0, 13);
            this.LBLloggedInUser.TabIndex = 13;
            this.LBLloggedInUser.Visible = false;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LBLloggedInUser);
            this.Controls.Add(this.DGVteacherData);
            this.Controls.Add(this.BTNGuestLogin);
            this.Controls.Add(this.DGVUserTable);
            this.Controls.Add(this.TBDebug);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTNLogIn);
            this.Controls.Add(this.WMPScreensaver);
            this.Name = "Startup";
            this.Text = "Login To Continue";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNGuestLogin;
        private System.Windows.Forms.DataGridView DGVteacherData;
        private System.Windows.Forms.BindingSource teacherDataBindingSource;
        private mainDatabaseTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsAwardedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDockedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LBLloggedInUser;
    }
}

