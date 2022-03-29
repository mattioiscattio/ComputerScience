
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awardDockPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDB = new YearOneProjectOne.DSDB();
            this.LBLStudentName = new System.Windows.Forms.Label();
            this.LBLStudentDOB = new System.Windows.Forms.Label();
            this.LBLStudentPointsPos = new System.Windows.Forms.Label();
            this.TBStudentName = new System.Windows.Forms.TextBox();
            this.TBStudentPointsPos = new System.Windows.Forms.TextBox();
            this.TBStudentDOB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.teacherDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.teacherDataTableAdapter();
            this.LBLDebug = new System.Windows.Forms.Label();
            this.StudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.LBRewardList = new System.Windows.Forms.ListBox();
            this.rewardTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LBLRewardName = new System.Windows.Forms.Label();
            this.LBLRewardThreshold = new System.Windows.Forms.Label();
            this.LBLRewardStock = new System.Windows.Forms.Label();
            this.LBLRewardPrice = new System.Windows.Forms.Label();
            this.TBRewardName = new System.Windows.Forms.TextBox();
            this.TBRewardThreshold = new System.Windows.Forms.TextBox();
            this.TBRewardStock = new System.Windows.Forms.TextBox();
            this.TBRewardPrice = new System.Windows.Forms.TextBox();
            this.rewardTableTableAdapter = new YearOneProjectOne.DSDBTableAdapters.rewardTableTableAdapter();
            this.BindingNavigatorReward = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.LBLStudentPointsNeg = new System.Windows.Forms.Label();
            this.TBStudentPointsNeg = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingNavigator)).BeginInit();
            this.StudentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorReward)).BeginInit();
            this.BindingNavigatorReward.SuspendLayout();
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
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.editItemsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editItemsToolStripMenuItem.Text = "Edit Items";
            this.editItemsToolStripMenuItem.Click += new System.EventHandler(this.editItemsToolStripMenuItem_Click);
            // 
            // studentPointsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.studentPointsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.studentPointsChart.Legends.Add(legend1);
            this.studentPointsChart.Location = new System.Drawing.Point(941, 47);
            this.studentPointsChart.Name = "studentPointsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.studentPointsChart.Series.Add(series1);
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
            this.LBLStudentName.Location = new System.Drawing.Point(387, 28);
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
            this.LBLStudentDOB.Location = new System.Drawing.Point(398, 59);
            this.LBLStudentDOB.Name = "LBLStudentDOB";
            this.LBLStudentDOB.Size = new System.Drawing.Size(52, 22);
            this.LBLStudentDOB.TabIndex = 5;
            this.LBLStudentDOB.Text = "DOB:";
            this.LBLStudentDOB.Visible = false;
            // 
            // LBLStudentPointsPos
            // 
            this.LBLStudentPointsPos.AutoSize = true;
            this.LBLStudentPointsPos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStudentPointsPos.Location = new System.Drawing.Point(313, 93);
            this.LBLStudentPointsPos.Name = "LBLStudentPointsPos";
            this.LBLStudentPointsPos.Size = new System.Drawing.Size(137, 22);
            this.LBLStudentPointsPos.TabIndex = 9;
            this.LBLStudentPointsPos.Text = "Positive Points:";
            this.LBLStudentPointsPos.Visible = false;
            // 
            // TBStudentName
            // 
            this.TBStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentName", true));
            this.TBStudentName.Location = new System.Drawing.Point(456, 31);
            this.TBStudentName.Name = "TBStudentName";
            this.TBStudentName.Size = new System.Drawing.Size(100, 20);
            this.TBStudentName.TabIndex = 10;
            this.TBStudentName.Visible = false;
            // 
            // TBStudentPointsPos
            // 
            this.TBStudentPointsPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentPositivePoints", true));
            this.TBStudentPointsPos.Location = new System.Drawing.Point(456, 97);
            this.TBStudentPointsPos.Name = "TBStudentPointsPos";
            this.TBStudentPointsPos.Size = new System.Drawing.Size(100, 20);
            this.TBStudentPointsPos.TabIndex = 11;
            this.TBStudentPointsPos.Visible = false;
            // 
            // TBStudentDOB
            // 
            this.TBStudentDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentDOB", true));
            this.TBStudentDOB.Location = new System.Drawing.Point(456, 62);
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
            // StudentBindingNavigator
            // 
            this.StudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.StudentBindingNavigator.BindingSource = this.StudentBindingSource;
            this.StudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.StudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.StudentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.StudentBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.StudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.StudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.StudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.StudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.StudentBindingNavigator.Name = "StudentBindingNavigator";
            this.StudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.StudentBindingNavigator.Size = new System.Drawing.Size(53, 653);
            this.StudentBindingNavigator.TabIndex = 23;
            this.StudentBindingNavigator.Text = "bindingNavigator1";
            this.StudentBindingNavigator.Visible = false;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // LBRewardList
            // 
            this.LBRewardList.DataSource = this.rewardTableBindingSource;
            this.LBRewardList.DisplayMember = "itemName";
            this.LBRewardList.FormattingEnabled = true;
            this.LBRewardList.Location = new System.Drawing.Point(50, 186);
            this.LBRewardList.Name = "LBRewardList";
            this.LBRewardList.Size = new System.Drawing.Size(181, 186);
            this.LBRewardList.TabIndex = 35;
            this.LBRewardList.Visible = false;
            // 
            // rewardTableBindingSource
            // 
            this.rewardTableBindingSource.DataMember = "rewardTable";
            this.rewardTableBindingSource.DataSource = this.dSDB;
            // 
            // LBLRewardName
            // 
            this.LBLRewardName.AutoSize = true;
            this.LBLRewardName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRewardName.Location = new System.Drawing.Point(353, 90);
            this.LBLRewardName.Name = "LBLRewardName";
            this.LBLRewardName.Size = new System.Drawing.Size(147, 25);
            this.LBLRewardName.TabIndex = 36;
            this.LBLRewardName.Text = "Reward Name - ";
            this.LBLRewardName.Visible = false;
            // 
            // LBLRewardThreshold
            // 
            this.LBLRewardThreshold.AutoSize = true;
            this.LBLRewardThreshold.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRewardThreshold.Location = new System.Drawing.Point(349, 360);
            this.LBLRewardThreshold.Name = "LBLRewardThreshold";
            this.LBLRewardThreshold.Size = new System.Drawing.Size(132, 25);
            this.LBLRewardThreshold.TabIndex = 41;
            this.LBLRewardThreshold.Text = "Buy Threshold";
            this.LBLRewardThreshold.Visible = false;
            // 
            // LBLRewardStock
            // 
            this.LBLRewardStock.AutoSize = true;
            this.LBLRewardStock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRewardStock.Location = new System.Drawing.Point(426, 270);
            this.LBLRewardStock.Name = "LBLRewardStock";
            this.LBLRewardStock.Size = new System.Drawing.Size(69, 25);
            this.LBLRewardStock.TabIndex = 42;
            this.LBLRewardStock.Text = "Stock -";
            this.LBLRewardStock.Visible = false;
            // 
            // LBLRewardPrice
            // 
            this.LBLRewardPrice.AutoSize = true;
            this.LBLRewardPrice.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRewardPrice.Location = new System.Drawing.Point(429, 180);
            this.LBLRewardPrice.Name = "LBLRewardPrice";
            this.LBLRewardPrice.Size = new System.Drawing.Size(67, 25);
            this.LBLRewardPrice.TabIndex = 43;
            this.LBLRewardPrice.Text = "Price -";
            this.LBLRewardPrice.Visible = false;
            // 
            // TBRewardName
            // 
            this.TBRewardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "itemName", true));
            this.TBRewardName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRewardName.Location = new System.Drawing.Point(542, 87);
            this.TBRewardName.Name = "TBRewardName";
            this.TBRewardName.Size = new System.Drawing.Size(152, 31);
            this.TBRewardName.TabIndex = 44;
            this.TBRewardName.Visible = false;
            // 
            // TBRewardThreshold
            // 
            this.TBRewardThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "StockThreshold", true));
            this.TBRewardThreshold.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRewardThreshold.Location = new System.Drawing.Point(542, 358);
            this.TBRewardThreshold.Name = "TBRewardThreshold";
            this.TBRewardThreshold.Size = new System.Drawing.Size(152, 31);
            this.TBRewardThreshold.TabIndex = 45;
            this.TBRewardThreshold.Visible = false;
            // 
            // TBRewardStock
            // 
            this.TBRewardStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "Stock", true));
            this.TBRewardStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRewardStock.Location = new System.Drawing.Point(542, 271);
            this.TBRewardStock.Name = "TBRewardStock";
            this.TBRewardStock.Size = new System.Drawing.Size(152, 31);
            this.TBRewardStock.TabIndex = 46;
            this.TBRewardStock.Visible = false;
            // 
            // TBRewardPrice
            // 
            this.TBRewardPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "price", true));
            this.TBRewardPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRewardPrice.Location = new System.Drawing.Point(542, 180);
            this.TBRewardPrice.Name = "TBRewardPrice";
            this.TBRewardPrice.Size = new System.Drawing.Size(152, 31);
            this.TBRewardPrice.TabIndex = 47;
            this.TBRewardPrice.Visible = false;
            // 
            // rewardTableTableAdapter
            // 
            this.rewardTableTableAdapter.ClearBeforeFill = true;
            // 
            // BindingNavigatorReward
            // 
            this.BindingNavigatorReward.AddNewItem = this.toolStripButton1;
            this.BindingNavigatorReward.BindingSource = this.rewardTableBindingSource;
            this.BindingNavigatorReward.CountItem = this.toolStripLabel1;
            this.BindingNavigatorReward.DeleteItem = this.toolStripButton2;
            this.BindingNavigatorReward.Dock = System.Windows.Forms.DockStyle.Left;
            this.BindingNavigatorReward.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.BindingNavigatorReward.Location = new System.Drawing.Point(0, 24);
            this.BindingNavigatorReward.MoveFirstItem = this.toolStripButton3;
            this.BindingNavigatorReward.MoveLastItem = this.toolStripButton6;
            this.BindingNavigatorReward.MoveNextItem = this.toolStripButton5;
            this.BindingNavigatorReward.MovePreviousItem = this.toolStripButton4;
            this.BindingNavigatorReward.Name = "BindingNavigatorReward";
            this.BindingNavigatorReward.PositionItem = this.toolStripTextBox1;
            this.BindingNavigatorReward.Size = new System.Drawing.Size(53, 653);
            this.BindingNavigatorReward.TabIndex = 48;
            this.BindingNavigatorReward.Text = "RewardBindingNavigator";
            this.BindingNavigatorReward.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton1.Text = "Add new";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 15);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(50, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(50, 20);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(50, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(50, 6);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(50, 19);
            this.toolStripButton7.Text = "Load";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(50, 19);
            this.toolStripButton8.Text = "Save";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(50, 19);
            this.toolStripButton9.Text = "Cancel";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // LBLStudentPointsNeg
            // 
            this.LBLStudentPointsNeg.AutoSize = true;
            this.LBLStudentPointsNeg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStudentPointsNeg.Location = new System.Drawing.Point(305, 128);
            this.LBLStudentPointsNeg.Name = "LBLStudentPointsNeg";
            this.LBLStudentPointsNeg.Size = new System.Drawing.Size(145, 22);
            this.LBLStudentPointsNeg.TabIndex = 49;
            this.LBLStudentPointsNeg.Text = "Negative Points:";
            this.LBLStudentPointsNeg.Visible = false;
            // 
            // TBStudentPointsNeg
            // 
            this.TBStudentPointsNeg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentBindingSource, "studentNegativePoints", true));
            this.TBStudentPointsNeg.Location = new System.Drawing.Point(456, 131);
            this.TBStudentPointsNeg.Name = "TBStudentPointsNeg";
            this.TBStudentPointsNeg.Size = new System.Drawing.Size(100, 20);
            this.TBStudentPointsNeg.TabIndex = 50;
            this.TBStudentPointsNeg.Visible = false;
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.TBStudentPointsNeg);
            this.Controls.Add(this.LBLStudentPointsNeg);
            this.Controls.Add(this.LBLStudentPointsPos);
            this.Controls.Add(this.BindingNavigatorReward);
            this.Controls.Add(this.TBRewardPrice);
            this.Controls.Add(this.TBRewardStock);
            this.Controls.Add(this.TBRewardThreshold);
            this.Controls.Add(this.TBRewardName);
            this.Controls.Add(this.LBLRewardPrice);
            this.Controls.Add(this.LBLRewardStock);
            this.Controls.Add(this.LBLRewardThreshold);
            this.Controls.Add(this.LBRewardList);
            this.Controls.Add(this.BTNDockPoints);
            this.Controls.Add(this.BTNAddPoints);
            this.Controls.Add(this.LBLSelectStudent);
            this.Controls.Add(this.TBNameSearch);
            this.Controls.Add(this.LBLNameSearch);
            this.Controls.Add(this.LBLstudentPointsCounter);
            this.Controls.Add(this.TBPointsVaryVal);
            this.Controls.Add(this.LBLPointsVaryVal);
            this.Controls.Add(this.LBLDebug);
            this.Controls.Add(this.TBStudentDOB);
            this.Controls.Add(this.TBStudentPointsPos);
            this.Controls.Add(this.TBStudentName);
            this.Controls.Add(this.LBLStudentDOB);
            this.Controls.Add(this.LBLStudentName);
            this.Controls.Add(this.StudentBindingNavigator);
            this.Controls.Add(this.LBStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPointsChart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBSearchedStudents);
            this.Controls.Add(this.LBLRewardName);
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
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingNavigator)).EndInit();
            this.StudentBindingNavigator.ResumeLayout(false);
            this.StudentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorReward)).EndInit();
            this.BindingNavigatorReward.ResumeLayout(false);
            this.BindingNavigatorReward.PerformLayout();
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
        private System.Windows.Forms.Label LBLStudentPointsPos;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.BindingSource StudentBindingSource;
        internal System.Windows.Forms.ListBox LBStudents;
        internal System.Windows.Forms.TextBox TBStudentName;
        internal System.Windows.Forms.TextBox TBStudentPointsPos;
        internal System.Windows.Forms.TextBox TBStudentDOB;
        internal DSDBTableAdapters.teacherDataTableAdapter teacherDataTableAdapter;
        internal DSDB dSDB;
        internal DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.Label LBLDebug;
        private System.Windows.Forms.BindingNavigator StudentBindingNavigator;
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
        private System.Windows.Forms.ListBox LBRewardList;
        private System.Windows.Forms.Label LBLRewardName;
        private System.Windows.Forms.Label LBLRewardThreshold;
        private System.Windows.Forms.Label LBLRewardStock;
        private System.Windows.Forms.Label LBLRewardPrice;
        private System.Windows.Forms.TextBox TBRewardName;
        private System.Windows.Forms.TextBox TBRewardThreshold;
        private System.Windows.Forms.TextBox TBRewardStock;
        private System.Windows.Forms.TextBox TBRewardPrice;
        private System.Windows.Forms.BindingSource rewardTableBindingSource;
        private DSDBTableAdapters.rewardTableTableAdapter rewardTableTableAdapter;
        private System.Windows.Forms.BindingNavigator BindingNavigatorReward;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.Label LBLStudentPointsNeg;
        internal System.Windows.Forms.TextBox TBStudentPointsNeg;
    }
}