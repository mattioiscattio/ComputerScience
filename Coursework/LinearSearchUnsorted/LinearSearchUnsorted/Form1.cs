using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

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
                DGVOutput[0, 0].Value = randVars.Next(0, Convert.ToInt32(TBrandLimit.Text)+1);
                DGVOutput.Rows.Insert(0);//always inserts random num in first row
            }
            DGVOutput[0, 0].Value = randVars.Next(0, Convert.ToInt32(TBrandLimit.Text)+1);//needs extra fill to fill initial row.
        }

        private void BTNSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
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
            TimeSpan ts = stopWatch.Elapsed;
            LBLDebug.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void BTNLinearSearch_Click(object sender, EventArgs e)
        {
            LBLSearchOutput.Visible = true;
            for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount)); i++)
            {
                if (Convert.ToInt32(DGVOutput[0, i].Value) == Convert.ToInt32(TBsearchNum.Text)) //if the item on row i in randomised column = search time then state that.
                {
                    LBLSearchOutput.Text = "Search item found at row: " + i;
                }
            }
            LBLSearchOutput.Text = "Search item not found.";
        }


        private void BTNinsertionSort_Click(object sender, EventArgs e)//create list add 0 at start, copy templist[i] to templist[0], loop up through list checking if templist[0] > templist[listpos]
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            List<int> tempList = new List<int>();
            for (int i = 0; i < (Convert.ToInt32(DGVOutput.RowCount));i++)//creates a temp list from the random data
            {
                tempList.Add(Convert.ToInt32(DGVOutput[0, i].Value));
            }

            for (int sortItem = 0;sortItem < tempList.Count; sortItem++)//loops through list to select item to compare against others.
            {
                for (int compareValue = 0;compareValue < sortItem;compareValue++)//loops up through already sorted items to find place for new item.
                {
                  if (tempList[sortItem] <= tempList[compareValue])//checks value of next index
                  {
                    tempList.Insert(compareValue, tempList[sortItem]);
                    tempList.RemoveAt(sortItem+1);
                    break;
                  }
                }
            }

            for (int tableInsertionIndex = 0; tableInsertionIndex < tempList.Count; tableInsertionIndex++)//enters data from temp list into insertion sort column of dgv
                    {
                DGVOutput[2, tableInsertionIndex].Value = tempList[tableInsertionIndex];
                    }
            TimeSpan ts = stopWatch.Elapsed;
            LBLDebug.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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

        private void BTNBinarySearch_Click(object sender, EventArgs e)
        {
            BTNinsertionSort_Click(sender, e);
            int searchNum = Convert.ToInt32(TBsearchNum.Text);
            bool searchItemFound = false;
            int listLength = DGVOutput.RowCount;
            while (searchItemFound == false)
            {
                listLength = listLength / 2;
                if (searchNum > Convert.ToInt32(DGVOutput[2, listLength].Value))
                {
                    listLength = DGVOutput.RowCount - (listLength / 2);
                }
                else if (searchNum < Convert.ToInt32(DGVOutput[2, listLength].Value))
                {
                    listLength = listLength / 2;
                }
                else if (searchNum == Convert.ToInt32(DGVOutput[2, listLength].Value))
                {
                    searchItemFound = true;
                }
            }

            LBLSearchOutput.Text = "search item found at index: " + listLength;

        }
    }
}
