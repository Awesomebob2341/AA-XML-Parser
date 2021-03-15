using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AA_XML_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (fileDialog.ShowDialog() == DialogResult.OK)
                FileName.Text = fileDialog.FileName;
        }

        private void RunParse_Click(object sender, EventArgs e)
        {
            Results.Text = "";

            int count = 3;  // The first line containing attributes starts at array position 3 (4th line in the xml)

            char startChar = '>';
            char interChar = '/';
            char endChar = '<';

            int preCheck = 0;
            int start = 0;
            int end = 0;

            string[] fileLines = File.ReadAllLines(FileName.Text);  // Line 1 in the file corresponds to fileLines[0]. count++ gives the current line

            List<int> linesOfFail = new List<int>();  // Contains falied line number
            List<string> errorType = new List<string>();  // Contains error type respective to the linesOfFail
            Verify_Req req = new Verify_Req();  // Class contains the logic

            while (count <= fileLines.Length - 3)  // The last 3 lines are ending tags for xmls
            {
                LineCount.Text = count.ToString();
                LineCount.Update();

                string currentLine = fileLines[count];

                preCheck = currentLine.IndexOf(endChar);  // Find the index of the first '<'

                if (currentLine[preCheck + 1] != interChar)  // Is the charater proceeding '<' a '/'? If it is, this is a tag with nothing to check
                {
                    start = currentLine.IndexOf(startChar) + 1;  // Add 1 to start so '>' is not collected as part of the substring to check
                    end = req.CheckEndTags(currentLine, startChar, interChar, endChar, start, end);

                    if (end > 0) // If end is -1 an end tag was never found and this could be an error
                    {
                        if (req.IsValidLength(count, start, end, currentLine))
                        {
                            if (req.ContainsValidChars(currentLine, start, end))
                            {
                                if (req.ContainsNaN(currentLine, start, end))
                                {
                                    linesOfFail.Add(++count);
                                    errorType.Add(" NaN found");
                                }
                            }
                            else
                            {
                                linesOfFail.Add(++count);
                                errorType.Add(" Invalid character found");
                            }
                        }
                        else
                        {
                            linesOfFail.Add(++count);
                            errorType.Add(" Over 2k characters");
                        }
                    }
                    else if (end == -2)
                    {
                        linesOfFail.Add(++count);
                        errorType.Add(" Invaild carrot found");
                    }
                }
                count++;
            }

            if (linesOfFail.Count > 0)
            {
                for (int i = 0; i < linesOfFail.Count; i++)
                {
                    Results.Text += linesOfFail[i].ToString() + errorType[i] + "\n\n";
                }
            }
            else
            {
                Results.Text = "No errored lines detected";
            }
        }
    }
}