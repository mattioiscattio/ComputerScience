
namespace YearOneProjectOne
{
    partial class adminView
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
            this.mainDatabase1 = new YearOneProjectOne.MainDatabase();
            this.DGVstudentData = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabase1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new YearOneProjectOne.MainDatabaseTableAdapters.studentDataTableAdapter();
            this.DGVteacherData = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointRatioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherDataTableAdapter = new YearOneProjectOne.MainDatabaseTableAdapters.teacherDataTableAdapter();
            this.DGVtimeTable = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableTableAdapter = new YearOneProjectOne.MainDatabaseTableAdapters.timeTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPointsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtimeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDatabase1
            // 
            this.mainDatabase1.DataSetName = "MainDatabase";
            this.mainDatabase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVstudentData
            // 
            this.DGVstudentData.AllowUserToAddRows = false;
            this.DGVstudentData.AllowUserToDeleteRows = false;
            this.DGVstudentData.AllowUserToResizeColumns = false;
            this.DGVstudentData.AllowUserToResizeRows = false;
            this.DGVstudentData.AutoGenerateColumns = false;
            this.DGVstudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVstudentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentDOBDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentPointsDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn});
            this.DGVstudentData.DataSource = this.studentDataBindingSource;
            this.DGVstudentData.Location = new System.Drawing.Point(13, 13);
            this.DGVstudentData.Name = "DGVstudentData";
            this.DGVstudentData.Size = new System.Drawing.Size(240, 150);
            this.DGVstudentData.TabIndex = 0;
            this.DGVstudentData.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "studentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentDOBDataGridViewTextBoxColumn
            // 
            this.studentDOBDataGridViewTextBoxColumn.DataPropertyName = "studentDOB";
            this.studentDOBDataGridViewTextBoxColumn.HeaderText = "studentDOB";
            this.studentDOBDataGridViewTextBoxColumn.Name = "studentDOBDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentPointsDataGridViewTextBoxColumn
            // 
            this.studentPointsDataGridViewTextBoxColumn.DataPropertyName = "studentPoints";
            this.studentPointsDataGridViewTextBoxColumn.HeaderText = "studentPoints";
            this.studentPointsDataGridViewTextBoxColumn.Name = "studentPointsDataGridViewTextBoxColumn";
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            this.tagsDataGridViewTextBoxColumn.DataPropertyName = "tags";
            this.tagsDataGridViewTextBoxColumn.HeaderText = "tags";
            this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.mainDatabase1BindingSource;
            // 
            // mainDatabase1BindingSource
            // 
            this.mainDatabase1BindingSource.DataSource = this.mainDatabase1;
            this.mainDatabase1BindingSource.Position = 0;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // DGVteacherData
            // 
            this.DGVteacherData.AutoGenerateColumns = false;
            this.DGVteacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVteacherData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherDOBDataGridViewTextBoxColumn,
            this.netPointsDataGridViewTextBoxColumn,
            this.pointRatioDataGridViewTextBoxColumn});
            this.DGVteacherData.DataSource = this.teacherDataBindingSource;
            this.DGVteacherData.Location = new System.Drawing.Point(273, 13);
            this.DGVteacherData.Name = "DGVteacherData";
            this.DGVteacherData.Size = new System.Drawing.Size(240, 150);
            this.DGVteacherData.TabIndex = 1;
            this.DGVteacherData.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
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
            // netPointsDataGridViewTextBoxColumn
            // 
            this.netPointsDataGridViewTextBoxColumn.DataPropertyName = "netPoints";
            this.netPointsDataGridViewTextBoxColumn.HeaderText = "netPoints";
            this.netPointsDataGridViewTextBoxColumn.Name = "netPointsDataGridViewTextBoxColumn";
            // 
            // pointRatioDataGridViewTextBoxColumn
            // 
            this.pointRatioDataGridViewTextBoxColumn.DataPropertyName = "Point Ratio";
            this.pointRatioDataGridViewTextBoxColumn.HeaderText = "Point Ratio";
            this.pointRatioDataGridViewTextBoxColumn.Name = "pointRatioDataGridViewTextBoxColumn";
            // 
            // teacherDataBindingSource
            // 
            this.teacherDataBindingSource.DataMember = "teacherData";
            this.teacherDataBindingSource.DataSource = this.mainDatabase1BindingSource;
            // 
            // teacherDataTableAdapter
            // 
            this.teacherDataTableAdapter.ClearBeforeFill = true;
            // 
            // DGVtimeTable
            // 
            this.DGVtimeTable.AutoGenerateColumns = false;
            this.DGVtimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtimeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdayDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn});
            this.DGVtimeTable.DataSource = this.timeTableBindingSource;
            this.DGVtimeTable.Location = new System.Drawing.Point(520, 13);
            this.DGVtimeTable.Name = "DGVtimeTable";
            this.DGVtimeTable.Size = new System.Drawing.Size(240, 150);
            this.DGVtimeTable.TabIndex = 2;
            this.DGVtimeTable.Visible = false;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "Monday";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "Monday";
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            // 
            // thursdayDataGridViewTextBoxColumn
            // 
            this.thursdayDataGridViewTextBoxColumn.DataPropertyName = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.HeaderText = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.Name = "thursdayDataGridViewTextBoxColumn";
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "Friday";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "Friday";
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataMember = "timeTable";
            this.timeTableBindingSource.DataSource = this.mainDatabase1BindingSource;
            // 
            // timeTableTableAdapter
            // 
            this.timeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.studentNameDataGridViewTextBoxColumn1,
            this.studentDOBDataGridViewTextBoxColumn1,
            this.studentIDDataGridViewTextBoxColumn1,
            this.studentPointsDataGridViewTextBoxColumn1,
            this.tagsDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.studentDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // studentDataBindingSource1
            // 
            this.studentDataBindingSource1.DataMember = "studentData";
            this.studentDataBindingSource1.DataSource = this.mainDatabase1BindingSource;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // studentNameDataGridViewTextBoxColumn1
            // 
            this.studentNameDataGridViewTextBoxColumn1.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn1.HeaderText = "studentName";
            this.studentNameDataGridViewTextBoxColumn1.Name = "studentNameDataGridViewTextBoxColumn1";
            // 
            // studentDOBDataGridViewTextBoxColumn1
            // 
            this.studentDOBDataGridViewTextBoxColumn1.DataPropertyName = "studentDOB";
            this.studentDOBDataGridViewTextBoxColumn1.HeaderText = "studentDOB";
            this.studentDOBDataGridViewTextBoxColumn1.Name = "studentDOBDataGridViewTextBoxColumn1";
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            // 
            // studentPointsDataGridViewTextBoxColumn1
            // 
            this.studentPointsDataGridViewTextBoxColumn1.DataPropertyName = "studentPoints";
            this.studentPointsDataGridViewTextBoxColumn1.HeaderText = "studentPoints";
            this.studentPointsDataGridViewTextBoxColumn1.Name = "studentPointsDataGridViewTextBoxColumn1";
            // 
            // tagsDataGridViewTextBoxColumn1
            // 
            this.tagsDataGridViewTextBoxColumn1.DataPropertyName = "tags";
            this.tagsDataGridViewTextBoxColumn1.HeaderText = "tags";
            this.tagsDataGridViewTextBoxColumn1.Name = "tagsDataGridViewTextBoxColumn1";
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DGVtimeTable);
            this.Controls.Add(this.DGVteacherData);
            this.Controls.Add(this.DGVstudentData);
            this.Name = "adminView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.adminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtimeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDatabase mainDatabase1;
        private System.Windows.Forms.DataGridView DGVstudentData;
        private System.Windows.Forms.BindingSource mainDatabase1BindingSource;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private MainDatabaseTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGVteacherData;
        private System.Windows.Forms.BindingSource teacherDataBindingSource;
        private MainDatabaseTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointRatioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGVtimeTable;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private MainDatabaseTableAdapters.timeTableTableAdapter timeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPointsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource studentDataBindingSource1;
    }
}