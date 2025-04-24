/* Program: Sort and Search from streamed data of Neutrino particles in an integer array
 * Description: A forms-based GUI application for Astronominal Data Processing, which displays the data and allows users to sort and search from the data. 
 *              Also enables user to edit this data.
 * 
 * Author: Shamayla
 * Date: 25/04/2025
 * Version: 1.0
 * 
 * Code Revision History:
 * ---------------------
 * Date:            Version: 
 * Date:            Version:
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessingForm : Form
    {
        Random random = new Random();
        int[] neutrinoDataArray = new int[24];
        bool isDataLoad = false;
        bool isSorted = false;

        public AstronomicalProcessingForm()
        {
            InitializeComponent();
        }

        private void BTN_LoadData_Click(object sender, EventArgs e)
        {
            // Loading the integer data into array
            for (int i = 0; i < neutrinoDataArray.Length; i++)
            {
                neutrinoDataArray[i] = random.Next(10, 200);
            }

            // function call to load data to listbox for display on GUI
            LoadData_ListBox();
            MessageBox.Show("Data has loaded successfully!", "Info: Data is loaded");

            // setting to true after data is loaded successfully
            isDataLoad = true;

            // seting sorting to false, in case data is loaded again
            isSorted = false;
        }

        private void BTN_Sort_Click(object sender, EventArgs e)
        {
            int temp = 0;

            for(int i = 0; i < neutrinoDataArray.Length - 1; i++)
            {
                for(int j = 0; j < neutrinoDataArray.Length - i - 1; j++)
                {
                    if (neutrinoDataArray[j] > neutrinoDataArray[j + 1])
                    {
                        temp = neutrinoDataArray[j];
                        neutrinoDataArray[j] = neutrinoDataArray[j + 1];
                        neutrinoDataArray[j+1] = temp;
                    }
                }
            }
            LoadData_ListBox();
            MessageBox.Show("Data sorted successfully!", "Info: Data is sorted");
            isSorted = true;
        }

        // private function to load data into listbox on GUI display screen
        private void LoadData_ListBox()
        {
            LBx_NeutrinoData.Items.Clear();
            for (int i = 0; i < neutrinoDataArray.Length; i++)
            {

                LBx_NeutrinoData.Items.Add(neutrinoDataArray[i]);
            }
        }

        private void LB_EnterValue_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            int searchValue = 0;
            int foundIndex = 0;
            bool isfound = false;
            int startIndex = 0;
            int endIndex = neutrinoDataArray.Length - 1;
            int midIndex = 0;

            // Checks before searching the value
            // Data must be loaded into the listbox and sorted
            if (!isDataLoad)
            {
                MessageBox.Show("Please load the data first.", "Error!");
            }
            else if (!isSorted)
            {
                MessageBox.Show("Please sort the data before performing search.", "Error!");
            }
            else
            {
                // Capture value from user to search and convert to integer value
                bool result = int.TryParse(TB_InputSearchValue.Text.Trim(), out searchValue);
                if (result)
                {
                    // Binary Search
                    while (startIndex <= endIndex)
                    {
                        midIndex = (startIndex + endIndex) / 2;
                        if (searchValue == neutrinoDataArray[midIndex])
                        {
                            isfound = true;
                            foundIndex = midIndex;
                            LBx_NeutrinoData.SelectedIndex = foundIndex;
                            break;
                        }
                        else if (searchValue < neutrinoDataArray[midIndex])
                        {
                            endIndex = midIndex - 1;
                        }
                        else
                        {
                           startIndex = midIndex + 1; 
                        }
                    }
                    if (isfound)
                    { 
                        MessageBox.Show("Entered value is found at position " + (foundIndex + 1), "Info: Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Entered value doesn't exist", "Info: Value Not Found");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid value to search.", "Error: Invalid/Missing value");
                }
            }
        }
        int selectedIndex;
        private void BTN_EditData_Click(object sender, EventArgs e)
        {
            selectedIndex = LBx_NeutrinoData.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select the data from listbox first!", "Error: Data Not Selected");
            }
            else
            {
                TB_EditData.Text = LBx_NeutrinoData.SelectedItem.ToString();
            }
        }

        private void BTN_SaveData_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select the data from listbox first!", "Error: Data Not Selected");
            }
            else
            {
                bool result = int.TryParse(TB_SaveData.Text, out int editedValue);
                if (result)
                {
                    neutrinoDataArray[LBx_NeutrinoData.SelectedIndex] = editedValue;
                    LoadData_ListBox();
                    LBx_NeutrinoData.SelectedIndex = selectedIndex;
                    
                    // Resetting the values to default
                    TB_EditData.Clear();
                    TB_SaveData.Clear();
                    selectedIndex = -1;
                    isSorted = false;
                }
                else
                {
                    MessageBox.Show("Please enter valid integer.", "Error: Invalid data");
                }
            }
        }
    }
}
