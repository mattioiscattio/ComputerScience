
namespace LinearSearchUnsorted
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
            this.DGVOutput = new System.Windows.Forms.DataGridView();
            this.RandomNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bubbleSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertionSortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNRandomise = new System.Windows.Forms.Button();
            this.TBRandomNum = new System.Windows.Forms.TextBox();
            this.BTNBubbleSort = new System.Windows.Forms.Button();
            this.LBLDebug = new System.Windows.Forms.Label();
            this.BTNLinearSearch = new System.Windows.Forms.Button();
            this.TBsearchNum = new System.Windows.Forms.TextBox();
            this.LBLSearchOutput = new System.Windows.Forms.Label();
            this.TBrandLimit = new System.Windows.Forms.TextBox();
            this.BTNgridClear = new System.Windows.Forms.Button();
            this.BTNinsertionSort = new System.Windows.Forms.Button();
            this.BTNBinarySearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOutput
            // 
            this.DGVOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandomNumbers,
            this.bubbleSort,
            this.InsertionSortColumn});
            this.DGVOutput.Location = new System.Drawing.Point(410, 12);
            this.DGVOutput.Name = "DGVOutput";
            this.DGVOutput.Size = new System.Drawing.Size(341, 190);
            this.DGVOutput.TabIndex = 3;
            // 
            // RandomNumbers
            // 
            this.RandomNumbers.HeaderText = "Random Numbers";
            this.RandomNumbers.Name = "RandomNumbers";
            // 
            // bubbleSort
            // 
            this.bubbleSort.HeaderText = "Bubble Sort";
            this.bubbleSort.Name = "bubbleSort";
            // 
            // InsertionSortColumn
            // 
            this.InsertionSortColumn.HeaderText = "Insertion Sort";
            this.InsertionSortColumn.Name = "InsertionSortColumn";
            // 
            // BTNRandomise
            // 
            this.BTNRandomise.Location = new System.Drawing.Point(10, 11);
            this.BTNRandomise.Name = "BTNRandomise";
            this.BTNRandomise.Size = new System.Drawing.Size(101, 23);
            this.BTNRandomise.TabIndex = 4;
            this.BTNRandomise.Text = "Randomise";
            this.BTNRandomise.UseVisualStyleBackColor = true;
            this.BTNRandomise.Click += new System.EventHandler(this.BTNRandomise_Click);
            // 
            // TBRandomNum
            // 
            this.TBRandomNum.Location = new System.Drawing.Point(117, 15);
            this.TBRandomNum.Name = "TBRandomNum";
            this.TBRandomNum.Size = new System.Drawing.Size(160, 20);
            this.TBRandomNum.TabIndex = 5;
            this.TBRandomNum.Text = "Num Of Randoms To Generate";
            this.TBRandomNum.Click += new System.EventHandler(this.TBRandomNum_Click);
            // 
            // BTNBubbleSort
            // 
            this.BTNBubbleSort.Location = new System.Drawing.Point(10, 104);
            this.BTNBubbleSort.Name = "BTNBubbleSort";
            this.BTNBubbleSort.Size = new System.Drawing.Size(100, 23);
            this.BTNBubbleSort.TabIndex = 6;
            this.BTNBubbleSort.Text = "BubbleSort";
            this.BTNBubbleSort.UseVisualStyleBackColor = true;
            this.BTNBubbleSort.Click += new System.EventHandler(this.BTNSort_Click);
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(472, 214);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(39, 13);
            this.LBLDebug.TabIndex = 7;
            this.LBLDebug.Text = "Debug";
            // 
            // BTNLinearSearch
            // 
            this.BTNLinearSearch.Location = new System.Drawing.Point(10, 40);
            this.BTNLinearSearch.Name = "BTNLinearSearch";
            this.BTNLinearSearch.Size = new System.Drawing.Size(101, 23);
            this.BTNLinearSearch.TabIndex = 8;
            this.BTNLinearSearch.Text = "Linear Search";
            this.BTNLinearSearch.UseVisualStyleBackColor = true;
            this.BTNLinearSearch.Click += new System.EventHandler(this.BTNLinearSearch_Click);
            // 
            // TBsearchNum
            // 
            this.TBsearchNum.Location = new System.Drawing.Point(257, 43);
            this.TBsearchNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBsearchNum.Name = "TBsearchNum";
            this.TBsearchNum.Size = new System.Drawing.Size(148, 20);
            this.TBsearchNum.TabIndex = 9;
            this.TBsearchNum.Text = "Search Number";
            this.TBsearchNum.Click += new System.EventHandler(this.TBsearchNum_Click);
            // 
            // LBLSearchOutput
            // 
            this.LBLSearchOutput.AutoSize = true;
            this.LBLSearchOutput.Location = new System.Drawing.Point(9, 75);
            this.LBLSearchOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLSearchOutput.Name = "LBLSearchOutput";
            this.LBLSearchOutput.Size = new System.Drawing.Size(73, 13);
            this.LBLSearchOutput.TabIndex = 10;
            this.LBLSearchOutput.Text = "SearchOutput";
            this.LBLSearchOutput.Visible = false;
            // 
            // TBrandLimit
            // 
            this.TBrandLimit.Location = new System.Drawing.Point(329, 15);
            this.TBrandLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBrandLimit.Name = "TBrandLimit";
            this.TBrandLimit.Size = new System.Drawing.Size(76, 20);
            this.TBrandLimit.TabIndex = 11;
            this.TBrandLimit.Text = "Random Limit";
            this.TBrandLimit.Click += new System.EventHandler(this.TBrandLimit_Click);
            // 
            // BTNgridClear
            // 
            this.BTNgridClear.Location = new System.Drawing.Point(410, 209);
            this.BTNgridClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNgridClear.Name = "BTNgridClear";
            this.BTNgridClear.Size = new System.Drawing.Size(56, 19);
            this.BTNgridClear.TabIndex = 12;
            this.BTNgridClear.Text = "Clear";
            this.BTNgridClear.UseVisualStyleBackColor = true;
            this.BTNgridClear.Click += new System.EventHandler(this.BTNgridClear_Click);
            // 
            // BTNinsertionSort
            // 
            this.BTNinsertionSort.Location = new System.Drawing.Point(117, 104);
            this.BTNinsertionSort.Name = "BTNinsertionSort";
            this.BTNinsertionSort.Size = new System.Drawing.Size(100, 23);
            this.BTNinsertionSort.TabIndex = 13;
            this.BTNinsertionSort.Text = "InsertionSort";
            this.BTNinsertionSort.UseVisualStyleBackColor = true;
            this.BTNinsertionSort.Click += new System.EventHandler(this.BTNinsertionSort_Click);
            // 
            // BTNBinarySearch
            // 
            this.BTNBinarySearch.Location = new System.Drawing.Point(117, 41);
            this.BTNBinarySearch.Name = "BTNBinarySearch";
            this.BTNBinarySearch.Size = new System.Drawing.Size(101, 23);
            this.BTNBinarySearch.TabIndex = 14;
            this.BTNBinarySearch.Text = "BinarySearch";
            this.BTNBinarySearch.UseVisualStyleBackColor = true;
            this.BTNBinarySearch.Click += new System.EventHandler(this.BTNBinarySearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNBinarySearch);
            this.Controls.Add(this.BTNinsertionSort);
            this.Controls.Add(this.BTNgridClear);
            this.Controls.Add(this.TBrandLimit);
            this.Controls.Add(this.LBLSearchOutput);
            this.Controls.Add(this.TBsearchNum);
            this.Controls.Add(this.BTNLinearSearch);
            this.Controls.Add(this.LBLDebug);
            this.Controls.Add(this.BTNBubbleSort);
            this.Controls.Add(this.TBRandomNum);
            this.Controls.Add(this.BTNRandomise);
            this.Controls.Add(this.DGVOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVOutput;
        private System.Windows.Forms.Button BTNRandomise;
        private System.Windows.Forms.TextBox TBRandomNum;
        private System.Windows.Forms.Button BTNBubbleSort;
        private System.Windows.Forms.Label LBLDebug;
        private System.Windows.Forms.Button BTNLinearSearch;
        private System.Windows.Forms.TextBox TBsearchNum;
        private System.Windows.Forms.Label LBLSearchOutput;
        private System.Windows.Forms.TextBox TBrandLimit;
        private System.Windows.Forms.Button BTNgridClear;
        private System.Windows.Forms.Button BTNinsertionSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn bubbleSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertionSortColumn;
        private System.Windows.Forms.Button BTNBinarySearch;
    }
}

