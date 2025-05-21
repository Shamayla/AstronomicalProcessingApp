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
 * Date: 21/05/2025  Version: 2.0
 * Date:             Version:
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
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
        int selectedIndex;

        public AstronomicalProcessingForm()
        {
            InitializeComponent();
            selectedIndex = LBx_NeutrinoData.SelectedIndex;
        }

        private void BTN_LoadData_Click(object sender, EventArgs e)
        {
            // Loading the integer data into array
            for (int i = 0; i < neutrinoDataArray.Length; i++)
            {
                neutrinoDataArray[i] = random.Next(10, 90);
            }

            // function call to load data to listbox for display on GUI
            LoadData_ListBox();
            // MessageBox.Show("Data has loaded successfully!", "Info: Data is loaded");
            LB_MessageToUser.ForeColor = Color.Green;
            LB_MessageToUser.Text = "Success! Neutrino data has loaded.";


            // setting to true after data is loaded successfully
            isDataLoad = true;

            // seting sorting to false, in case data is loaded again
            isSorted = false;

            //Resetting all textboxes
            TB_MidExtreme.Clear();
            TB_Mode.Clear();
            TB_Range.Clear();
            TB_Average.Clear();
        }

        private void BTN_Sort_Click(object sender, EventArgs e)
        {
            Sort_ArrayData();
        }

        private void Sort_ArrayData()
        {
            if(isDataLoad)
            {
                int temp = 0;

                for (int i = 0; i < neutrinoDataArray.Length - 1; i++)
                {
                    for (int j = 0; j < neutrinoDataArray.Length - i - 1; j++)
                    {
                        if (neutrinoDataArray[j] > neutrinoDataArray[j + 1])
                        {
                            temp = neutrinoDataArray[j];
                            neutrinoDataArray[j] = neutrinoDataArray[j + 1];
                            neutrinoDataArray[j + 1] = temp;
                        }
                    }
                }
                LoadData_ListBox();
                //MessageBox.Show("Data sorted successfully!", "Info: Data is sorted");
                LB_MessageToUser.ForeColor = Color.Green;
                LB_MessageToUser.Text = "Success! Neutrino data has sorted in ascending order.";
                isSorted = true;
            }
            else
            {
                LB_MessageToUser.ForeColor = Color.OrangeRed;
                LB_MessageToUser.Text = "Message! Please load neutrino data.";
            }
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
                //MessageBox.Show("Please load the data first.", "Error!");
                LB_MessageToUser.ForeColor = Color.OrangeRed;
                LB_MessageToUser.Text = "Message! Please load Neutrino data.";
            }
            else if (!isSorted)
            {
                //MessageBox.Show("Please sort the data before performing search.", "Error!");
                LB_MessageToUser.ForeColor = Color.OrangeRed;
                LB_MessageToUser.Text = "Message! Please sort the Neutrino data.";
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
                        //MessageBox.Show("Entered value is found at position " + (foundIndex + 1), "Info: Successful!");
                        LB_MessageToUser.ForeColor = Color.Green;
                        LB_MessageToUser.Text = $"Success (Binary Search)! Value {searchValue} found at position {(foundIndex + 1)}.";
                        LBx_NeutrinoData.SelectedIndex = foundIndex;
                        TB_InputSearchValue.Clear();
                    }
                    else
                    {
                        //MessageBox.Show("Entered value doesn't exist", "Info: Value Not Found");
                        LB_MessageToUser.ForeColor = Color.Red;
                        LB_MessageToUser.Text = $"Not Successful (Binary Search)! Value {searchValue} does not found.";
                        LBx_NeutrinoData.SelectedIndex = foundIndex;
                    }
                }
                else
                {
                    //MessageBox.Show("Please enter valid value to search.", "Error: Invalid/Missing value");
                    LB_MessageToUser.ForeColor = Color.OrangeRed;
                    LB_MessageToUser.Text = $"Error Message! Please enter the value to search.";
                    LBx_NeutrinoData.SelectedIndex = foundIndex;
                }
            }
        }

        private void BTN_SaveData_Click(object sender, EventArgs e)
        {
            selectedIndex = LBx_NeutrinoData.SelectedIndex;
            if (selectedIndex == -1)
            {
                //MessageBox.Show("Please select the data from listbox first!", "Error: Data Not Selected");
                LB_MessageToUser.ForeColor = Color.OrangeRed;
                LB_MessageToUser.Text = $"Error Message! Please select the data from listbox first!";
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
                    TB_SaveData.Clear();
                    selectedIndex = -1;
                    isSorted = false;
                }
                else
                {
                    //MessageBox.Show("Please enter valid integer.", "Error: Invalid data");
                    LB_MessageToUser.ForeColor = Color.Red;
                    LB_MessageToUser.Text = $"Error! Invalid value has entered. Please enter integer value.";
                }
            }
        }

        private void LBL_ProjectDescription_Click(object sender, EventArgs e)
        {

        }

        private void LBx_NeutrinoData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_SequentialSearch_Click(object sender, EventArgs e)
        {
            int searchValue = 0;
            bool isfound = false;
            int foundAtIndex = 0;
            int startIndex = 0;
            int endIndex = neutrinoDataArray.Length - 1;


            // Checks before searching the value
            // Data must be loaded into the listbox and sorted
            if (!isDataLoad)
            {
                //MessageBox.Show("Please load the data first.", "Error!");
                LB_MessageToUser.ForeColor = Color.OrangeRed;
                LB_MessageToUser.Text = $"Error Message! Please load the data.";
            }
            else
            {
                // Capture value from user to search and convert to integer value
                bool result = int.TryParse(TB_InputSearchValue.Text.Trim(), out searchValue);
                if (result)
                {
                    // Sequential Search
                    for (int i = startIndex; i <= endIndex; i++) { 

                        if(neutrinoDataArray[i] == searchValue)
                        {
                            isfound = true;
                            foundAtIndex = i;

                            break;
                        }
                    }
                    
                    if (isfound)
                    {
                        //MessageBox.Show("Entered value is found at position " + (foundAtIndex + 1), "Info: Successful!");
                        LB_MessageToUser.ForeColor = Color.Green;
                        LB_MessageToUser.Text = $"Success (Sequential Search)! Value {searchValue} found at position {(foundAtIndex + 1)}.";
                        LBx_NeutrinoData.SelectedIndex = foundAtIndex;
                        TB_InputSearchValue.Clear();
                    }
                    else
                    {
                        //MessageBox.Show("Entered value doesn't exist", "Info: Value Not Found");
                        LB_MessageToUser.ForeColor = Color.Red;
                        LB_MessageToUser.Text = $"Not Success (Sequential Search)! Value {searchValue} does not found.";
                    }
                }
                else
                {
                    //MessageBox.Show("Please enter valid value to search.", "Error: Invalid/Missing value");
                    LB_MessageToUser.ForeColor = Color.OrangeRed;
                    LB_MessageToUser.Text = $"Error! Invalid value entered. Please provide integer value.";
                }
            }
        }

        private void BTN_MidExtreme_Click(object sender, EventArgs e)
        {
            int smallestValue;
            int largetValue;
            double midExtreme;

            Sort_ArrayData();
            smallestValue = neutrinoDataArray[0];
            largetValue = neutrinoDataArray[neutrinoDataArray.Length - 1];

            float sum = smallestValue + largetValue;
            midExtreme = sum / 2;

            TB_MidExtreme.Text = Math.Round(midExtreme, 2).ToString();
            LB_MessageToUser.ForeColor = Color.Green;
            LB_MessageToUser.Text = $"MideExtreme is calculated successfully!";

        }

        private void BTN_Mode_Click(object sender, EventArgs e)
        {
            Dictionary<string,int> valueCounts = new Dictionary<string,int>();
            int startIndex = 0;
            int endIndex = neutrinoDataArray.Length - 1;
            string mode = "";
            int dataItem;
            int itemCount = 0;
            int maxCount = 0;

            Sort_ArrayData();
            dataItem = neutrinoDataArray[0];
            for (int i = startIndex; i < endIndex; i++) { 
                if (dataItem == neutrinoDataArray[i])
                {
                    itemCount++;
                }
                else
                {
                    //valueCounts = valueCounts + $"{dataItem},{itemCount};";
                    valueCounts.Add(dataItem.ToString(), itemCount);
                    dataItem = neutrinoDataArray[i];
                    itemCount = 1;
                }
            }

            //valueCounts = valueCounts + $"{dataItem},{itemCount};";
            valueCounts.Add(dataItem.ToString(), itemCount);
            int modes = 1;
            foreach ( var item in valueCounts )
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    mode = item.Key;
                    modes = 1;
                }
                else if (item.Value == maxCount)
                {
                    mode = mode + ", " + item.Key;
                    modes++;
                }
            }

            if (modes == 1)
            {
                LB_MessageToUser.Text = $"Data has one mode.";
            }
            else if (modes == 2) {
                LB_MessageToUser.Text = $"Data is bimodal.";
            }
            else
            {
                LB_MessageToUser.Text = $"Data is multi-modal.";
            }

            TB_Mode.Text = mode.ToString();
        }

        private void BTN_Average_Click(object sender, EventArgs e)
        {

            double average = 0;
            int sum = 0;

            foreach (int dataItem in neutrinoDataArray)
            {
                sum += dataItem;
            }

            average = (float)sum / neutrinoDataArray.Length;

            TB_Average.Text = Math.Round(average, 2).ToString();
            LB_MessageToUser.ForeColor = Color.Green;
            LB_MessageToUser.Text = $"Average is calculated successfully!";
        }

        private void BTN_Range_Click(object sender, EventArgs e)
        {
            int smallestValue = 0;
            int largestValue = 0;
            int range = 0;

            smallestValue = neutrinoDataArray[0];
            largestValue = neutrinoDataArray[neutrinoDataArray.Length - 1];

            range = largestValue - smallestValue;
            TB_Range.Text = range.ToString();
            LB_MessageToUser.ForeColor = Color.Green;
            LB_MessageToUser.Text = $"Range is calculated successfully!";

        }
    }
}
