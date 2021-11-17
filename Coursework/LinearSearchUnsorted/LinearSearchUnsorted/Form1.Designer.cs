
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
            this.RandomNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bubbleSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertionSortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DGVOutput.Location = new System.Drawing.Point(547, 15);
            this.DGVOutput.Margin = new System.Windows.Forms.Padding(4);
            this.DGVOutput.Name = "DGVOutput";
            this.DGVOutput.Size = new System.Drawing.Size(455, 234);
            this.DGVOutput.TabIndex = 3;
            // 
            // BTNRandomise
            // 
            this.BTNRandomise.Location = new System.Drawing.Point(13, 13);
            this.BTNRandomise.Margin = new System.Windows.Forms.Padding(4);
            this.BTNRandomise.Name = "BTNRandomise";
            this.BTNRandomise.Size = new System.Drawing.Size(135, 28);
            this.BTNRandomise.TabIndex = 4;
            this.BTNRandomise.Text = "Randomise";
            this.BTNRandomise.UseVisualStyleBackColor = true;
            this.BTNRandomise.Click += new System.EventHandler(this.BTNRandomise_Click);
            // 
            // TBRandomNum
            // 
            this.TBRandomNum.Location = new System.Drawing.Point(156, 19);
            this.TBRandomNum.Margin = new System.Windows.Forms.Padding(4);
            this.TBRandomNum.Name = "TBRandomNum";
            this.TBRandomNum.Size = new System.Drawing.Size(196, 22);
            this.TBRandomNum.TabIndex = 5;
            this.TBRandomNum.Text = "Num Of Randoms To Generate";
            this.TBRandomNum.Click += new System.EventHandler(this.TBRandomNum_Click);
            // 
            // BTNBubbleSort
            // 
            this.BTNBubbleSort.Location = new System.Drawing.Point(13, 128);
            this.BTNBubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBubbleSort.Name = "BTNBubbleSort";
            this.BTNBubbleSort.Size = new System.Drawing.Size(133, 28);
            this.BTNBubbleSort.TabIndex = 6;
            this.BTNBubbleSort.Text = "BubbleSort";
            this.BTNBubbleSort.UseVisualStyleBackColor = true;
            this.BTNBubbleSort.Click += new System.EventHandler(this.BTNSort_Click);
            // 
            // LBLDebug
            // 
            this.LBLDebug.AutoSize = true;
            this.LBLDebug.Location = new System.Drawing.Point(629, 264);
            this.LBLDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDebug.Name = "LBLDebug";
            this.LBLDebug.Size = new System.Drawing.Size(49, 16);
            this.LBLDebug.TabIndex = 7;
            this.LBLDebug.Text = "Debug";
            // 
            // BTNLinearSearch
            // 
            this.BTNLinearSearch.Location = new System.Drawing.Point(13, 49);
            this.BTNLinearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BTNLinearSearch.Name = "BTNLinearSearch";
            this.BTNLinearSearch.Size = new System.Drawing.Size(135, 28);
            this.BTNLinearSearch.TabIndex = 8;
            this.BTNLinearSearch.Text = "Linear Search";
            this.BTNLinearSearch.UseVisualStyleBackColor = true;
            this.BTNLinearSearch.Click += new System.EventHandler(this.BTNLinearSearch_Click);
            // 
            // TBsearchNum
            // 
            this.TBsearchNum.Location = new System.Drawing.Point(156, 55);
            this.TBsearchNum.Name = "TBsearchNum";
            this.TBsearchNum.Size = new System.Drawing.Size(196, 22);
            this.TBsearchNum.TabIndex = 9;
            this.TBsearchNum.Text = "Search Number";
            this.TBsearchNum.Click += new System.EventHandler(this.TBsearchNum_Click);
            // 
            // LBLSearchOutput
            // 
            this.LBLSearchOutput.AutoSize = true;
            this.LBLSearchOutput.Location = new System.Drawing.Point(12, 92);
            this.LBLSearchOutput.Name = "LBLSearchOutput";
            this.LBLSearchOutput.Size = new System.Drawing.Size(89, 16);
            this.LBLSearchOutput.TabIndex = 10;
            this.LBLSearchOutput.Text = "SearchOutput";
            this.LBLSearchOutput.Visible = false;
            // 
            // TBrandLimit
            // 
            this.TBrandLimit.Location = new System.Drawing.Point(359, 19);
            this.TBrandLimit.Name = "TBrandLimit";
            this.TBrandLimit.Size = new System.Drawing.Size(100, 22);
            this.TBrandLimit.TabIndex = 11;
            this.TBrandLimit.Text = "Random Limit";
            this.TBrandLimit.Click += new System.EventHandler(this.TBrandLimit_Click);
            // 
            // BTNgridClear
            // 
            this.BTNgridClear.Location = new System.Drawing.Point(547, 257);
            this.BTNgridClear.Name = "BTNgridClear";
            this.BTNgridClear.Size = new System.Drawing.Size(75, 23);
            this.BTNgridClear.TabIndex = 12;
            this.BTNgridClear.Text = "Clear";
            this.BTNgridClear.UseVisualStyleBackColor = true;
            this.BTNgridClear.Click += new System.EventHandler(this.BTNgridClear_Click);
            // 
            // BTNinsertionSort
            // 
            this.BTNinsertionSort.Location = new System.Drawing.Point(156, 128);
            this.BTNinsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.BTNinsertionSort.Name = "BTNinsertionSort";
            this.BTNinsertionSort.Size = new System.Drawing.Size(133, 28);
            this.BTNinsertionSort.TabIndex = 13;
            this.BTNinsertionSort.Text = "InsertionSort";
            this.BTNinsertionSort.UseVisualStyleBackColor = true;
            this.BTNinsertionSort.Click += new System.EventHandler(this.BTNinsertionSort_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

