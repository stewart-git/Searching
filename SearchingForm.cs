using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Stewart Godwin, 
// Updated 06/04/2022
namespace Searching
{
    public partial class SearchingForm : Form
    {
        public SearchingForm()
        {
            InitializeComponent();
            DisplayRainbow();
        }
        // Create an Array of Strings with SORTED data
        string[] Rainbow = new string[] {"Amber","Blue","Crimson","Ebony","Green","Indego",
            "Lavender","Maroon","Orange","Purple","Red","Violet","Yellow"};
        // Display the array of string values
        private void DisplayRainbow()
        {
            ListViewColours.Items.Clear();
            for(int x = 0; x < Rainbow.Length; x++)
            {
                ListViewItem lvi = new ListViewItem(Rainbow[x]);
                lvi.SubItems.Add(Rainbow[x].ToString());
                ListViewColours.Items.Add(lvi);
            }
        }
        private void DisplayItem(int colourIndx)
        {
            ListViewColours.Refresh();  
            ListViewColours.Items[colourIndx].Selected = true;           
            ListViewColours.Select();
        }
        // Binary Search. In this method, the entire list is divided into two sub-lists. 
        // If the item is found in the middle position, it returns the location, otherwise 
        // jump to either left or right sub-list and do the same process again until finding 
        // the item or exceed the range.
        private void ButonBinarySearch_Click(object sender, EventArgs e)
        {
            textBoxFeedback.Clear();
            if (!string.IsNullOrEmpty(TextBoxTarget.Text))
            {
                bool found = false; // assume the item has not been found
                int min = 0;              
                int max = Rainbow.Length - 1; // max is one less than size
                string findThis = TextBoxTarget.Text;
                while (min <= max)
                {
                    int mid = ((min + max) / 2); // uses integer division
                    if(findThis.CompareTo(Rainbow[mid]) == 0)
                    {
                        found = true;
                        DisplayItem(mid);
                        break;
                    }
                    else if(findThis.CompareTo(Rainbow[mid]) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                if(!found)
                {
                    MessageBox.Show("Search failed: item not found");
                }
                else
                {
                    textBoxFeedback.Text = "Success: the item was found";
                    //MessageBox.Show("Success: the item was found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a colour into the TextBox");
            }
            TextBoxTarget.Clear();
        }
        // Jump Search. Creates a block and tries to find the element in that block. 
        // If the item is not in the block, it shifts the entire block. The block 
        // size is based on the size of the list. If the size of the list is n then 
        // block size will be √n. After finding a correct block it finds the item 
        // using a linear search technique. The jump search lies between linear search 
        // and binary search according to its performance.
        private void ButtonJumpSearch_Click(object sender, EventArgs e) 
        {
            textBoxFeedback.Clear();
            bool found = false; // assume the item has not been found
            string target = TextBoxTarget.Text;
            int max = Rainbow.Length;
            int step = (int)Math.Floor(Math.Sqrt(max)); // block size
            int prev = 0;
            while(string.Compare((Rainbow[Math.Min(step, max) - 1]), target) == -1)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(max));
                if (prev >= max)
                {
                    found = false;
                    break;
                }                   
            }
            while(string.Compare(Rainbow[prev], target) == -1)
            {
                prev++;
                if (prev == Math.Min(step, max))
                {
                    found = false;
                    break;
                }
            }
            if (string.Compare(Rainbow[prev], target) == 0)
                found = true;
            if (!found)
            {
                MessageBox.Show("Search failed: item not found");
            }
            else
            {
                textBoxFeedback.Text = "Success: the item was found";
                // MessageBox.Show("Success: the item was found");
            }
            TextBoxTarget.Clear();
        }
        // In computer science, a linear search or sequential search is a method for finding
        // an element within a list. It sequentially checks each element of the list until
        // a match is found or the whole list has been searched.
        private void ButtonLinearSeach_Click(object sender, EventArgs e)
        {
            textBoxFeedback.Clear();
            bool found = false; // assume the item has not been found
            string target = TextBoxTarget.Text;
            // linear Search code
            for (int x = 0; x < Rainbow.Length; x++)
            {
                if(string.Compare(Rainbow[x], target) == 0)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Search failed: item not found");
            }
            else
            {
                textBoxFeedback.Text = "Success: the item was found";
                // MessageBox.Show("Success: the item was found");
            }
            TextBoxTarget.Clear();
        }
        // Ternary search is a decrease(by constant) and conquer algorithm that can be used to find
        // an element in an array. It is similar to binary search where we divide the array into
        // two parts but in this algorithm, we divide the given array into three parts and determine
        // which has the key (searched element). We can divide the array into three parts by
        // taking mid1 and mid2
        private void ButtonTernarySearch_Click(object sender, EventArgs e)
        {
            textBoxFeedback.Clear();
            bool found = false; // assume the item has not been found
            string target = TextBoxTarget.Text;
            int lo = 0;
            int hi = Rainbow.Length - 1;

            while (hi >= lo)
            {
                int mid1 = lo + (hi - lo) / 3;
                int mid2 = hi - (hi - lo) / 3;

                if (string.Compare(Rainbow[mid1], target) == 0)
                {
                    found = true;
                    break;
                }
                if (string.Compare(Rainbow[mid2], target) == 0)
                {
                    found = true;
                    break;
                }
                if (target.CompareTo(Rainbow[mid1]) < 0)
                {
                    hi = mid1 - 1;
                }           
                else if (target.CompareTo(Rainbow[mid2]) > 0)
                {
                    lo = mid2 + 1;
                }
                else
                {
                    lo = mid1 + 1;
                    hi = mid2 - 1;
                }
            }

            if (!found)
            {
                MessageBox.Show("Search failed: item not found");
            }
            else
            {
                textBoxFeedback.Text = "Success: the item was found";
                // MessageBox.Show("Success: the item was found");
            }
            TextBoxTarget.Clear();
        }
    }
}
