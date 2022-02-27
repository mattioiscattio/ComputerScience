using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4._4
{
    public partial class Homework4d : Form
    {
        public Homework4d()
        {
            InitializeComponent();
        }

        static string ReverseString(string alphabet)
        {
            char[] array = alphabet.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        private string alphabetSplitter(string Letter1, string  Letter2)
        {
            int letter1Pos = 0;
            int letter2Pos = 0;
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] alphabetList = alphabet.ToCharArray();//converts the string alphabet to an array of characters 
            for (int i = 0; i < 26; i++)//iterates through the list of letters and checks if they are the desired ones.
            {
                if (alphabetList[i].ToString() == Letter1)
                {
                    letter1Pos = i;
                }
                else if (alphabetList[i].ToString() == Letter2)
                {
                    letter2Pos = i;
                }

            }

            if (letter2Pos > letter1Pos)//if the letters are entered in alphabetical order then it returns it as normal
            {
                return alphabet.Substring(letter1Pos, (letter2Pos - letter1Pos) + 1);
            }
            else//if the letters are not in alphabetical order then it re-runs the process with a reversed alphabet. should use either a subroutine to aid decomposion, performance etc, or used a check before running the loop at all.
            {
                string reverseAlphabet = ReverseString(alphabet);
                char[] reverseAlphabetList = reverseAlphabet.ToCharArray();//converts the string alphabet to an array of characters 
                for (int i = 0; i < 26; i++)//iterates through the list of letters and checks if they are the desired ones.
                {
                    if (reverseAlphabetList[i].ToString() == Letter1)
                    {
                        letter1Pos = i;
                    }
                    else if (reverseAlphabetList[i].ToString() == Letter2)
                    {
                        letter2Pos = i;
                    }

                }
                return reverseAlphabet.Substring(letter1Pos, (letter2Pos - letter1Pos) + 1);
            }
        }


        private void BTNRun_Click(object sender, EventArgs e)
        {
            string Letter1 = TBLetter1.Text;
            string Letter2 = TBLetter2.Text;
            LBLOutput.Text = alphabetSplitter(Letter1, Letter2);
        }
    }
}
