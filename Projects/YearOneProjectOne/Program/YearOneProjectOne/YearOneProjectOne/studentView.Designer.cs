
namespace YearOneProjectOne
{
    partial class studentView
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
            this.LBLDebug = new System.Windows.Forms.Label();
            this.studentDataTableAdapter = new YearOneProjectOne.DSDBTableAdapters.studentDataTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useTheShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBRewards = new System.Windows.Forms.ListBox();
            this.rewardTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSDB = new YearOneProjectOne.DSDB();
            this.rewardTableTableAdapter = new YearOneProjectOne.DSDBTableAdapters.rewardTableTableAdapter();
            this.ChrtStudentPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBLItemStock = new System.Windows.Forms.Label();
            this.TBItemPrice = new System.Windows.Forms.TextBox();
            this.TBItemStock = new System.Windows.Forms.TextBox();
            this.TBItemName = new System.Windows.Forms.TextBox();
            this.LBLItemPrice = new System.Windows.Forms.Label();
            this.LBLItemName = new System.Windows.Forms.Label();
            this.BTNPurchase = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStudentPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(707, 412);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(35, 13);
            this.LBLDebug.TabIndex = 0;
            this.LBLDebug.Text = "label1";
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionToolStripMenuItem,
            this.shopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
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
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useTheShopToolStripMenuItem,
            this.purchaseHistoryToolStripMenuItem});
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // useTheShopToolStripMenuItem
            // 
            this.useTheShopToolStripMenuItem.Name = "useTheShopToolStripMenuItem";
            this.useTheShopToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.useTheShopToolStripMenuItem.Text = "Use the shop";
            this.useTheShopToolStripMenuItem.Click += new System.EventHandler(this.useTheShopToolStripMenuItem_Click);
            // 
            // purchaseHistoryToolStripMenuItem
            // 
            this.purchaseHistoryToolStripMenuItem.Name = "purchaseHistoryToolStripMenuItem";
            this.purchaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseHistoryToolStripMenuItem.Text = "Purchase History";
            // 
            // LBRewards
            // 
            this.LBRewards.DataSource = this.rewardTableBindingSource;
            this.LBRewards.DisplayMember = "itemName";
            this.LBRewards.FormattingEnabled = true;
            this.LBRewards.Location = new System.Drawing.Point(12, 40);
            this.LBRewards.Name = "LBRewards";
            this.LBRewards.Size = new System.Drawing.Size(120, 95);
            this.LBRewards.TabIndex = 3;
            this.LBRewards.ValueMember = "itemName";
            this.LBRewards.Visible = false;
            this.LBRewards.SelectedIndexChanged += new System.EventHandler(this.LBRewards_SelectedIndexChanged);
            // 
            // rewardTableBindingSource
            // 
            this.rewardTableBindingSource.DataMember = "rewardTable";
            this.rewardTableBindingSource.DataSource = this.DSDB;
            // 
            // DSDB
            // 
            this.DSDB.DataSetName = "DSDB";
            this.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rewardTableTableAdapter
            // 
            this.rewardTableTableAdapter.ClearBeforeFill = true;
            // 
            // ChrtStudentPoints
            // 
            chartArea1.Name = "ChartArea1";
            this.ChrtStudentPoints.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChrtStudentPoints.Legends.Add(legend1);
            this.ChrtStudentPoints.Location = new System.Drawing.Point(614, 40);
            this.ChrtStudentPoints.Name = "ChrtStudentPoints";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChrtStudentPoints.Series.Add(series1);
            this.ChrtStudentPoints.Size = new System.Drawing.Size(174, 141);
            this.ChrtStudentPoints.TabIndex = 1;
            this.ChrtStudentPoints.Text = "chart1";
            // 
            // LBLItemStock
            // 
            this.LBLItemStock.AutoSize = true;
            this.LBLItemStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLItemStock.Location = new System.Drawing.Point(174, 106);
            this.LBLItemStock.Name = "LBLItemStock";
            this.LBLItemStock.Size = new System.Drawing.Size(66, 22);
            this.LBLItemStock.TabIndex = 53;
            this.LBLItemStock.Text = "Stock: ";
            this.LBLItemStock.Visible = false;
            // 
            // TBItemPrice
            // 
            this.TBItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "price", true));
            this.TBItemPrice.Location = new System.Drawing.Point(246, 74);
            this.TBItemPrice.Name = "TBItemPrice";
            this.TBItemPrice.Size = new System.Drawing.Size(100, 20);
            this.TBItemPrice.TabIndex = 56;
            this.TBItemPrice.Visible = false;
            // 
            // TBItemStock
            // 
            this.TBItemStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "Stock", true));
            this.TBItemStock.Location = new System.Drawing.Point(246, 109);
            this.TBItemStock.Name = "TBItemStock";
            this.TBItemStock.Size = new System.Drawing.Size(100, 20);
            this.TBItemStock.TabIndex = 55;
            this.TBItemStock.Visible = false;
            // 
            // TBItemName
            // 
            this.TBItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardTableBindingSource, "itemName", true));
            this.TBItemName.Location = new System.Drawing.Point(246, 43);
            this.TBItemName.Name = "TBItemName";
            this.TBItemName.Size = new System.Drawing.Size(100, 20);
            this.TBItemName.TabIndex = 54;
            this.TBItemName.Visible = false;
            // 
            // LBLItemPrice
            // 
            this.LBLItemPrice.AutoSize = true;
            this.LBLItemPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLItemPrice.Location = new System.Drawing.Point(185, 72);
            this.LBLItemPrice.Name = "LBLItemPrice";
            this.LBLItemPrice.Size = new System.Drawing.Size(55, 22);
            this.LBLItemPrice.TabIndex = 52;
            this.LBLItemPrice.Text = "Price:";
            this.LBLItemPrice.Visible = false;
            // 
            // LBLItemName
            // 
            this.LBLItemName.AutoSize = true;
            this.LBLItemName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLItemName.Location = new System.Drawing.Point(188, 40);
            this.LBLItemName.Name = "LBLItemName";
            this.LBLItemName.Size = new System.Drawing.Size(52, 22);
            this.LBLItemName.TabIndex = 51;
            this.LBLItemName.Text = "Item:";
            this.LBLItemName.Visible = false;
            // 
            // BTNPurchase
            // 
            this.BTNPurchase.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTNPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPurchase.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNPurchase.Location = new System.Drawing.Point(412, 57);
            this.BTNPurchase.Name = "BTNPurchase";
            this.BTNPurchase.Size = new System.Drawing.Size(132, 55);
            this.BTNPurchase.TabIndex = 57;
            this.BTNPurchase.Text = "Purchase";
            this.BTNPurchase.UseVisualStyleBackColor = false;
            this.BTNPurchase.Visible = false;
            this.BTNPurchase.Click += new System.EventHandler(this.BTNPurchase_Click);
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YearOneProjectOne.Properties.Resources.colorGradientGuestView;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNPurchase);
            this.Controls.Add(this.LBLItemStock);
            this.Controls.Add(this.TBItemPrice);
            this.Controls.Add(this.TBItemStock);
            this.Controls.Add(this.TBItemName);
            this.Controls.Add(this.LBLItemPrice);
            this.Controls.Add(this.LBLItemName);
            this.Controls.Add(this.LBRewards);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ChrtStudentPoints);
            this.Controls.Add(this.LBLDebug);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentView";
            this.Text = "Currently viewing as student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentView_FormClosing);
            this.Load += new System.EventHandler(this.studentView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStudentPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLDebug;
        internal DSDBTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useTheShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseHistoryToolStripMenuItem;
        internal System.Windows.Forms.ListBox LBRewards;
        private DSDBTableAdapters.rewardTableTableAdapter rewardTableTableAdapter;
        internal DSDB DSDB;
        private System.Windows.Forms.BindingSource rewardTableBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtStudentPoints;
        private System.Windows.Forms.Label LBLItemStock;
        internal System.Windows.Forms.TextBox TBItemPrice;
        internal System.Windows.Forms.TextBox TBItemStock;
        internal System.Windows.Forms.TextBox TBItemName;
        private System.Windows.Forms.Label LBLItemPrice;
        private System.Windows.Forms.Label LBLItemName;
        private System.Windows.Forms.Button BTNPurchase;
    }
}