using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_xxy180008
{
    public partial class Form1 : Form
    {
        String[] left = {"Number of records",
                        "Minimum entry time",
                        "Maximum entry time",
                        "Average entry time",
                        "Minimum inter-record time",
                        "Maximum inter-record time",
                        "Average inter-record time",
                        "Total time",
                        "Backspace count"}; // Array to store the left columns contents of the datagrid
        String[] right; // Array to store the right columns contents of the datagrid, which is the analysed data

        List<RebateForm> forms; // List to store rebate form records

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // By default, analysis button is disabled, and warning lable are invisable
            btAnalysis.Enabled = false;
            lbWarning.Visible = false;
           
            tb.Enabled = false;
            tb.ReadOnly = true;
            tb.Text = "Choose a text file to analysis";

            openFileDialog.Multiselect = false; // Does not allow multiselect

            setUpDataGrid();
        }
        
        
        private void btSelectFile_Click(object sender, EventArgs e)
        {
            lbWarning.Text = default;
            lbWarning.Visible = false;
            tb.Text = "Select a file to analysis";
            openFile();

            for (int i = 0; i < 9; i++)
            {
                dataGrid.Rows[i].Cells[1].Value = default; // Reset all the datagrid value to default
            }

        }
        private void btAnalysis_Click(object sender, EventArgs e)
        {
            lbWarning.Text = default;
            lbWarning.Visible = false;

            analysisData();

            for (int i = 0; i < 9; i++)
            {
                dataGrid.Rows[i].Cells[1].Value = right[i];
            }


            saveToFile("CS6326Asg3.txt");

            btAnalysis.Enabled = false;
        }


        /// <summary>
        /// Method to let user choose and open a file
        /// </summary>
        private void openFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!openFileDialog.FileName.EndsWith(".txt")) // Has to be a txt file
                {
                    // Display warning
                    lbWarning.Visible = true;
                    lbWarning.Text = "INVALID FILE TYPE";
                }
                else if (!readFile(openFileDialog.FileName)) // File contents are invalid
                { }
                else // Read file successfully
                {
                    tb.Text = openFileDialog.FileName;

                    lbWarning.Visible = true;
                    lbWarning.Text = "READ FILE SUCCESSFULLY";

                    // Enable analysis button, ready to analysis
                    btAnalysis.Enabled = true;
                }

            }
        }

        /// <summary>
        /// Method to read file and check valid data
        /// </summary>
        /// <returns> true if file contents are valid </returns>
        private Boolean readFile(String fileName)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);

            forms = new List<RebateForm>();

            String l; // Let l be the entire line when read the file line by line

            while ((l = file.ReadLine()) != null)
            {
                String[] fields = l.Split(',');
                RebateForm rb = new RebateForm();
                try
                {
                    rb.StartTime = Convert.ToDateTime(fields[13]);
                    rb.EndTime = Convert.ToDateTime(fields[14]);
                    rb.Backcount = Convert.ToInt32(fields[15]);
                    forms.Add(rb); // Add to the list
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Display warning
                    lbWarning.Visible = true;
                    lbWarning.Text = "FILE CONTENTS ARE INVALID";

                    return false;
                }
            }

            file.Close();

            if (forms.Count != 10)
            {
                // Display warning
                lbWarning.Visible = true;
                lbWarning.Text = "THE NUMBER OF RECORDS HAS TO BE 10";

                return false;
            }

            return true;
        }


        /// <summary>
        /// Method to analysis data records
        /// </summary>
        private void analysisData()
        {
            right = new string[9];

            right[0] = $"{forms.Count()}"; // Number of records

            List<TimeSpan> time = new List<TimeSpan>(); // List to store time spend for each record
            List<TimeSpan> interTime = new List<TimeSpan>(); // List to store time between each two records
            int totalbackSpace = 0; // Integer to store total backspace pressed for all ten records

            for (int i = 0; i < forms.Count; i++)
            {
                totalbackSpace += forms[0].Backcount;

                time.Add(forms[i].EndTime.Subtract(forms[i].StartTime)); // Time for each record = endtime - starttime

                if (i != 0)
                {
                    interTime.Add(forms[i].StartTime.Subtract(forms[i - 1].EndTime)); // Inter-time for each two records = current start time - previous end time
                }
            }

            right[1] = time.Min().ToString(@"mm\:ss"); // Minimum entry time
            right[2] = time.Max().ToString(@"mm\:ss"); // Maximum entry time
            right[3] = new TimeSpan(Convert.ToInt64(time.Average(t => t.Ticks))).ToString(@"mm\:ss"); // Average entry time
            right[4] = interTime.Min().ToString(@"mm\:ss"); // Minimum inter-record time
            right[5] = interTime.Max().ToString(@"mm\:ss"); // Maximum inter-record time
            right[6] = new TimeSpan(Convert.ToInt64(interTime.Average(t => t.Ticks))).ToString(@"mm\:ss"); // Average inter-record time
            right[7] = forms[9].EndTime.Subtract(forms[0].StartTime).ToString(@"mm\:ss"); // Total time
            right[8] = $"{totalbackSpace}"; // Backspace count
        }

        /// <summary>
        /// Initalize the datagrid, and fill all the left columns for each row
        /// </summary>
        private void setUpDataGrid()
        {
            dataGrid.RowCount = 9;
            dataGrid.ColumnCount = 2;

            for (int i = 0; i < 9; i++)
            {
                dataGrid.Rows[i].Cells[0].Value = left[i];
            }
        }

        /// <summary>
        /// Method to save analysed data to file 
        /// </summary>
        /// <param name="fileName"></param>
        public void saveToFile(String fileName)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);

            for (int i = 0; i < 9; i++)
            {
                file.WriteLine(left[i] + ": " + right[i]);
            }

            file.Close();
        }
    }
}
