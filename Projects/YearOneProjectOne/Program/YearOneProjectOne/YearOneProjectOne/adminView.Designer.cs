
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awardDockPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDB = new YearOneProjectOne.DSDB();
            this.LBLStudentName = new System.Windows.Forms.Label();
            this.LBLStudentDOB = new System.Windows.Forms.Label();
            this.LBLStudentPoints = new System.Windows.Forms.Label();
            this.TBStudentName = new System.Windows.Forms.TextBox();
            this.TBStudentPoints = new System.Windows.Forms.TextBox();
            this.TBStudentDOB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.teacherDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.teacherDataTableAdapter();
            this.LBLDebug = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNLoad = new System.Windows.Forms.ToolStripButton();
            this.BTNSave = new System.Windows.Forms.ToolStripButton();
            this.BTNCancel = new System.Windows.Forms.ToolStripButton();
            this.TBPointsVaryVal = new System.Windows.Forms.TextBox();
            this.LBLPointsVaryVal = new System.Windows.Forms.Label();
            this.LBLstudentPointsCounter = new System.Windows.Forms.Label();
            this.TBNameSearch = new System.Windows.Forms.TextBox();
            this.LBLNameSearch = new System.Windows.Forms.Label();
            this.LBSearchedStudents = new System.Windows.Forms.ListBox();
            this.LBLSelectStudent = new System.Windows.Forms.Label();
            this.BTNAddPoints = new System.Windows.Forms.Button();
            this.BTNDockPoints = new System.Windows.Forms.Button();
            this.StudentDataViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.shopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SessionToolStripMenuItem
            // 
            this.SessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem";
            this.SessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.SessionToolStripMenuItem.Text = "Session";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.awardDockPointsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.viewStudentsToolStripMenuItem.Text = "View/Edit Student Data";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // awardDockPointsToolStripMenuItem
            // 
            this.awardDockPointsToolStripMenuItem.Name = "awardDockPointsToolStripMenuItem";
            this.awardDockPointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.awardDockPointsToolStripMenuItem.Text = "Award/Dock Points";
            this.awardDockPointsToolStripMenuItem.Click += new System.EventHandler(this.awardDockPointsToolStripMenuItem_Click);
            // 
            // studentPointsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.studentPointsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.studentPointsChart.Legends.Add(legend3);
            this.studentPointsChart.Location = new System.Drawing.Point(941, 47);
            this.studentPointsChart.Name = "studentPointsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.studentPointsChart.Series.Add(series3);
            this.studentPointsChart.Size = new System.Drawing.Size(300, 221);
            this.studentPointsChart.TabIndex = 1;
            this.studentPointsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(980, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Net Awarded/Docked Points";
            // 
            // LBStudents
            // 
            this.LBStudents.DataSource = this.StudentBindingSource;
            this.LBStudents.DisplayMember = "studentName";
            this.LBStudents.FormattingEnabled = true;
            this.LBStudents.Location = new System.Drawing.Point(71, 29);
            this.LBStudents.MultiColumn = true;
            this.LBStudents.Name = "LBStudents";
            this.LBStudents.Size = new System.Drawing.Size(223, 95);
            this.LBStudents.TabIndex = 3;
            this.LBStudents.Visible = false;
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataMember = "studentData";
            this.StudentBindingSource.DataSource = this.dSDB;
            // 
            // dSDB
            // 
            this.dSDB.DataSetName = "DSDB";
            this.dSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBLStudentName
            // 
            this.LBLStudentName.AutoSize = true;
            this.LBLStudentName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStudentName.Location = new System.Drawing.Point(326, 28);
            this.LBLStudentName.Name = "LBLStudentName";
            this.LBLStudentName.Size = new System.Drawing.Size(63, 22);
            this.LBLStudentName.TabIndex = 4;
            this.LBLStudentName.Text = "Name:";
            this.LBLStudentName.Visible = false;
            // 
            // LBLStudentDOB
            // 
            this.LBLStudentDOB.AutoSize = true;
            this.LBLStudentDOB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStudentDOB.Location = new System.Drawing.Point(337, 60);
            this.LBLStudentDOB.Name = "LBLStudentDOB";
            this.LBLStudentDOB.Size = new System.Drawing.Size(52, 22);
            this.LBLStudentDOB.TabIndex = 5;
            this.LBLStudentDOB.Text = "DOB:";
            this.LBLStudentDOB.Visible = false;
            // 
            // LBLStudentPoints
            // 
            this.LBLStudentPoints.AutoSize = true;
            this.LBLStudentPoints.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStudentPoints.Location = new System.Drawing.Point(322, 92);
            this.LBLStudentPoints.Name = "LBLStudentPoints";
            this.LBLStudentPoints.Size = new System.Drawing.Size(67, 22);
            this.LBLStudentPoints.TabIndex = 9;
            this.LBLStudentPoints.Text = "Points:";
            this.LBLStudentPoints.Visible = false;
            // 
            // TBStudentName
            // 
            this.TBStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentName", true));
            this.TBStudentName.Location = new System.Drawing.Point(396, 29);
            this.TBStudentName.Name = "TBStudentName";
            this.TBStudentName.Size = new System.Drawing.Size(100, 20);
            this.TBStudentName.TabIndex = 10;
            this.TBStudentName.Visible = false;
            // 
            // TBStudentPoints
            // 
            this.TBStudentPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentPoints", true));
            this.TBStudentPoints.Location = new System.Drawing.Point(395, 94);
            this.TBStudentPoints.Name = "TBStudentPoints";
            this.TBStudentPoints.Size = new System.Drawing.Size(100, 20);
            this.TBStudentPoints.TabIndex = 11;
            this.TBStudentPoints.Visible = false;
            // 
            // TBStudentDOB
            // 
            this.TBStudentDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentDOB", true));
            this.TBStudentDOB.Location = new System.Drawing.Point(396, 62);
            this.TBStudentDOB.Name = "TBStudentDOB";
            this.TBStudentDOB.Size = new System.Drawing.Size(100, 20);
            this.TBStudentDOB.TabIndex = 13;
            this.TBStudentDOB.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // teacherDataTableAdapter
            // 
            this.teacherDataTableAdapter.ClearBeforeFill = true;
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(1206, 644);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(35, 13);
            this.LBLDebug.TabIndex = 20;
            this.LBLDebug.Text = "label2";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.StudentBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.BTNLoad,
            this.BTNSave,
            this.BTNCancel});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(53, 653);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // BTNLoad
            // 
            this.BTNLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTNLoad.Image = ((System.Drawing.Image)(resources.GetObject("BTNLoad.Image")));
            this.BTNLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNLoad.Name = "BTNLoad";
            this.BTNLoad.Size = new System.Drawing.Size(50, 19);
            this.BTNLoad.Text = "Load";
            this.BTNLoad.Click += new System.EventHandler(this.BTNLoad_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTNSave.Image = ((System.Drawing.Image)(resources.GetObject("BTNSave.Image")));
            this.BTNSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(50, 19);
            this.BTNSave.Text = "Save";
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTNCancel.Image = ((System.Drawing.Image)(resources.GetObject("BTNCancel.Image")));
            this.BTNCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(50, 19);
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // TBPointsVaryVal
            // 
            this.TBPointsVaryVal.Location = new System.Drawing.Point(542, 54);
            this.TBPointsVaryVal.Name = "TBPointsVaryVal";
            this.TBPointsVaryVal.Size = new System.Drawing.Size(138, 20);
            this.TBPointsVaryVal.TabIndex = 25;
            this.TBPointsVaryVal.Visible = false;
            // 
            // LBLPointsVaryVal
            // 
            this.LBLPointsVaryVal.AutoSize = true;
            this.LBLPointsVaryVal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPointsVaryVal.Location = new System.Drawing.Point(461, 29);
            this.LBLPointsVaryVal.Name = "LBLPointsVaryVal";
            this.LBLPointsVaryVal.Size = new System.Drawing.Size(340, 22);
            this.LBLPointsVaryVal.TabIndex = 24;
            this.LBLPointsVaryVal.Text = "How Many Points Do You Want To Add?";
            this.LBLPointsVaryVal.Visible = false;
            // 
            // LBLstudentPointsCounter
            // 
            this.LBLstudentPointsCounter.AutoSize = true;
            this.LBLstudentPointsCounter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLstudentPointsCounter.Location = new System.Drawing.Point(489, 117);
            this.LBLstudentPointsCounter.Name = "LBLstudentPointsCounter";
            this.LBLstudentPointsCounter.Size = new System.Drawing.Size(256, 22);
            this.LBLstudentPointsCounter.TabIndex = 26;
            this.LBLstudentPointsCounter.Text = "Student Currently has * Points";
            this.LBLstudentPointsCounter.Visible = false;
            // 
            // TBNameSearch
            // 
            this.TBNameSearch.Location = new System.Drawing.Point(150, 54);
            this.TBNameSearch.Name = "TBNameSearch";
            this.TBNameSearch.Size = new System.Drawing.Size(118, 20);
            this.TBNameSearch.TabIndex = 28;
            this.TBNameSearch.Text = "Enter Student Name";
            this.TBNameSearch.Visible = false;
            this.TBNameSearch.Click += new System.EventHandler(this.TBNameSearch_Click);
            this.TBNameSearch.TextChanged += new System.EventHandler(this.TBNameSearch_TextChanged);
            // 
            // LBLNameSearch
            // 
            this.LBLNameSearch.AutoSize = true;
            this.LBLNameSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNameSearch.Location = new System.Drawing.Point(12, 51);
            this.LBLNameSearch.Name = "LBLNameSearch";
            this.LBLNameSearch.Size = new System.Drawing.Size(132, 22);
            this.LBLNameSearch.TabIndex = 27;
            this.LBLNameSearch.Text = "Student Name:";
            this.LBLNameSearch.Visible = false;
            // 
            // LBSearchedStudents
            // 
            this.LBSearchedStudents.DataSource = this.StudentBindingSource;
            this.LBSearchedStudents.DisplayMember = "studentName";
            this.LBSearchedStudents.FormattingEnabled = true;
            this.LBSearchedStudents.Location = new System.Drawing.Point(150, 85);
            this.LBSearchedStudents.MultiColumn = true;
            this.LBSearchedStudents.Name = "LBSearchedStudents";
            this.LBSearchedStudents.Size = new System.Drawing.Size(223, 95);
            this.LBSearchedStudents.TabIndex = 30;
            this.LBSearchedStudents.Visible = false;
            this.LBSearchedStudents.SelectedIndexChanged += new System.EventHandler(this.LBSearchedStudents_SelectedIndexChanged);
            // 
            // LBLSelectStudent
            // 
            this.LBLSelectStudent.AutoSize = true;
            this.LBLSelectStudent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSelectStudent.Location = new System.Drawing.Point(12, 127);
            this.LBLSelectStudent.Name = "LBLSelectStudent";
            this.LBLSelectStudent.Size = new System.Drawing.Size(132, 22);
            this.LBLSelectStudent.TabIndex = 31;
            this.LBLSelectStudent.Text = "Select Student:";
            this.LBLSelectStudent.Visible = false;
            // 
            // BTNAddPoints
            // 
            this.BTNAddPoints.Location = new System.Drawing.Point(525, 85);
            this.BTNAddPoints.Name = "BTNAddPoints";
            this.BTNAddPoints.Size = new System.Drawing.Size(75, 23);
            this.BTNAddPoints.TabIndex = 32;
            this.BTNAddPoints.Text = "Add";
            this.BTNAddPoints.UseVisualStyleBackColor = true;
            this.BTNAddPoints.Visible = false;
            this.BTNAddPoints.Click += new System.EventHandler(this.BTNAddPoints_Click);
            // 
            // BTNDockPoints
            // 
            this.BTNDockPoints.Location = new System.Drawing.Point(619, 85);
            this.BTNDockPoints.Name = "BTNDockPoints";
            this.BTNDockPoints.Size = new System.Drawing.Size(75, 23);
            this.BTNDockPoints.TabIndex = 33;
            this.BTNDockPoints.Text = "Remove ";
            this.BTNDockPoints.UseVisualStyleBackColor = true;
            this.BTNDockPoints.Visible = false;
            this.BTNDockPoints.Click += new System.EventHandler(this.BTNDockPoints_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemsToolStripMenuItem});
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // editItemsToolStripMenuItem
            // 
            this.editItemsToolStripMenuItem.Name = "editItemsToolStripMenuItem";
            this.editItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editItemsToolStripMenuItem.Text = "Edit Items";
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.BTNDockPoints);
            this.Controls.Add(this.BTNAddPoints);
            this.Controls.Add(this.LBLSelectStudent);
            this.Controls.Add(this.LBSearchedStudents);
            this.Controls.Add(this.TBNameSearch);
            this.Controls.Add(this.LBLNameSearch);
            this.Controls.Add(this.LBLstudentPointsCounter);
            this.Controls.Add(this.TBPointsVaryVal);
            this.Controls.Add(this.LBLPointsVaryVal);
            this.Controls.Add(this.LBLDebug);
            this.Controls.Add(this.TBStudentDOB);
            this.Controls.Add(this.TBStudentPoints);
            this.Controls.Add(this.TBStudentName);
            this.Controls.Add(this.LBLStudentPoints);
            this.Controls.Add(this.LBLStudentDOB);
            this.Controls.Add(this.LBLStudentName);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.LBStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPointsChart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminView";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminView_FormClosing_1);
            this.Load += new System.EventHandler(this.adminView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentPointsChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLStudentName;
        private System.Windows.Forms.Label LBLStudentDOB;
        private System.Windows.Forms.Label LBLStudentPoints;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.BindingSource StudentBindingSource;
        internal System.Windows.Forms.ListBox LBStudents;
        internal System.Windows.Forms.TextBox TBStudentName;
        internal System.Windows.Forms.TextBox TBStudentPoints;
        internal System.Windows.Forms.TextBox TBStudentDOB;
        internal DSDBTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        internal DSDB dSDB;
        internal DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.Label LBLDebug;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNLoad;
        private System.Windows.Forms.ToolStripButton BTNSave;
        private System.Windows.Forms.ToolStripButton BTNCancel;
        private System.Windows.Forms.ToolStripMenuItem awardDockPointsToolStripMenuItem;
        internal System.Windows.Forms.TextBox TBPointsVaryVal;
        private System.Windows.Forms.Label LBLPointsVaryVal;
        private System.Windows.Forms.Label LBLstudentPointsCounter;
        internal System.Windows.Forms.TextBox TBNameSearch;
        private System.Windows.Forms.Label LBLNameSearch;
        internal System.Windows.Forms.ListBox LBSearchedStudents;
        private System.Windows.Forms.Label LBLSelectStudent;
        private System.Windows.Forms.Button BTNAddPoints;
        private System.Windows.Forms.Button BTNDockPoints;
        private System.Windows.Forms.BindingSource StudentDataViewBindingSource;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemsToolStripMenuItem;
    }
}