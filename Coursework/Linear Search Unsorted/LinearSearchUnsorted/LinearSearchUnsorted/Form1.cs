using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearSearchUnsorted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNRandomise_Click(object sender, EventArgs e)
        {
            Random randVars = new Random();//creates var that when queried will create a random num in a given range
            for (int randNumAmount = Convert.ToInt32(TBRandomNum.Text);randNumAmount > 1; randNumAmount--)//fills dgv with random nums
            {
                DGVOutput[0, 0].Value = randVars.Next(0, Convert.ToInt32(TBrandLimit.Text));
                DGVOutput.Rows.Insert(0);//always inserts random num in first row
            }
            DGVOutput[0, 0].Value = randVars.Next(0, Convert.ToInt32(TBrandLimit.Text));//needs extra fill to fill initial row.
        }

        private void BTNSort_Click(object sender, EventArgs e)
        {
            bool bubbleSortComplete = false;
            for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount)); i++)//copies all randomly generated to the bubble sorted column. then sorts.
            {
                DGVOutput[1, i].Value = Convert.ToInt32(DGVOutput[0, i].Value);
            }

            while (bubbleSortComplete == false)
            {
                bubbleSortComplete = true;//flagged as sorted until a swap occurs
                for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount)-1); i++)
                {
                    if (Convert.ToInt32(DGVOutput[1,i].Value) > Convert.ToInt32(DGVOutput[1,i+1].Value))//swaps 2 vars without third using a=a+b, b=a-b, a=a-b. not significantly more efficient but is more memory efficient
                    {
                        bubbleSortComplete = false;
                        DGVOutput[1,i].Value = Convert.ToInt32(DGVOutput[1,i].Value) + Convert.ToInt32(DGVOutput[1,i + 1].Value);
                        DGVOutput[1,i + 1].Value = Convert.ToInt32(DGVOutput[1,i].Value) - Convert.ToInt32(DGVOutput[1,i + 1].Value);
                        DGVOutput[1,i].Value = Convert.ToInt32(DGVOutput[1,i].Value) - Convert.ToInt32(DGVOutput[1,i+1].Value);
                    }

                }
            }
        }

        private void BTNLinearSearch_Click(object sender, EventArgs e)
        {
            LBLSearchOutput.Visible = true;
            for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount) - 1); i++)
            {
                if (Convert.ToInt32(DGVOutput[0, i].Value) == Convert.ToInt32(TBsearchNum.Text)) //if the item on row i in randomised column = search time then state that.
                {
                    LBLSearchOutput.Text = "Search item found at row: " + i;
                }
                else
                {
                    LBLSearchOutput.Text = "Search item not found.";
                }
            }
        }


        private void BTNinsertionSort_Click(object sender, EventArgs e)
        {
            //add value at 0, check if value at 2 is <> than at 1, sort accordingly, loop up through list 
            //create list from random data then do actions on that before putting it back into table.
            List<int> tempList = new List<int>();
            for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount) - 1);i++)
            {
                tempList.Add(Convert.ToInt32(DGVOutput[0, i].Value));
            }

            for (int i = 1; i < (Convert.ToInt32(DGVOutput.RowCount) - 1);i++)
            {
                int insertionPos = i;
                int sortingVar = tempList[i];
                bool swapComplete = false;
                while (swapComplete == false)
                {
                    if (sortingVar > tempList[insertionPos] && i < Convert.ToInt32(DGVOutput.RowCount))
                    {
                        insertionPos++;
                    }
                    else if (i == Convert.ToInt32(DGVOutput.RowCount))
                    {
                        swapComplete = true;
                    }


                    else
                    {
                        tempList.Insert(insertionPos, sortingVar);
                        tempList.RemoveAt(i);
                    }
                }
            }

            for (int tableInsertionIndex = 0; tableInsertionIndex < Convert.ToInt32(DGVOutput.RowCount) - 1 ; tableInsertionIndex++)
                    {
                DGVOutput[2, tableInsertionIndex].Value = tempList[tableInsertionIndex];
                    }
        }

        private void BTNgridClear_Click(object sender, EventArgs e)//clears all rows in dgv
        {
            DGVOutput.Rows.Clear();
        }

        private void TBsearchNum_Click(object sender, EventArgs e)//clears search num tb when clicked, needed to display text and use input conveniently
        {
            TBsearchNum.Text = "";
        }

        private void TBrandLimit_Click(object sender, EventArgs e)//clears randlimit tb when clicked
        {
            TBrandLimit.Text = "";
        }
        private void TBRandomNum_Click(object sender, EventArgs e)//clears randomNum tb when clicked
        {
            TBRandomNum.Text = "";
        }

    }
}
