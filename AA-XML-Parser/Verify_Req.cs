using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_XML_Parser
{
    class Verify_Req
    {
        public Verify_Req()
        {
            // Intentionally left blank
        }

        /// <summary>
        /// This funciton searchs for '>', '<', '/' in a substring taken from currentLines.
        /// If '>' or '<' is found in the string not incorporated with a tag it returns -1 to say there is an invalid character.
        /// If '<' + '/' is not found in the string, then the ending tag is on the wrong line and a -2 is returned.
        /// </summary>
        /// <param name="currentLine"></param>
        /// <param name="startChar"></param>
        /// <param name="interCheck"></param>
        /// <param name="endCheck"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int CheckEndTags(string currentLine, char startChar, char interChar, char endChar, int start, int end)
        {
            end = currentLine.IndexOf(endChar, start);

            if (end > 0)
            {
                string subString = currentLine.Substring(start, end - start);

                if (currentLine[end + 1] == interChar && !subString.Contains(startChar))
                    return end;  // if there '<' with a proceeding '/' this is a vaild end tag

                else if (currentLine[end + 1] != interChar || subString.Contains(startChar))
                    return -2;  // If there is a '>' or '<' without a '/' preceeding or proceeding repectively than this string contains invalid characters

                else
                    return end;
            }
            else
                return end;
        }

        /// <summary>
        /// This function iterates over the characters in a given substring looking for the first character
        /// that's not between ASCII 0 and 127. If it finds one it returns false, otherwise it returns true.
        /// </summary>
        /// <param name="currentLine"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public bool ContainsValidChars(string currentLine, int start, int end)
        {
            string subString = currentLine.Substring(start, end - start);

            for (int i = 0; i < subString.Length; i++)
            {
                if (subString[i] > 128)  // ASCII table is 0-127 for english characters, 128-255 is the extened table. 0-127 is valid characters.
                    return false;
            }
            return true;
        }

        /// <summary>
        /// This function checks to see if the string contains a NaN. If it does, it return true if not return false.
        /// </summary>
        /// <param name="currentLine"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public bool ContainsNaN(string currentLine, int start, int end)
        {
            string subString = currentLine.Substring(start, end - start);

            if (subString == "NaN")
                return true;
            
            else
                return false;
        }

        /// <summary>
        /// This function grabs all the character in between the start and end indexes and checks
        /// if the length is greater than 2000 on all tags that are not the Image tag. If the 
        /// length is greater than 2000 false is passed back
        /// </summary>
        /// <param name="count"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public bool IsValidLength(int count, int start, int end, string currentLine)
        {
            string subString = currentLine.Substring(start, end - start);

            subString = currentLine.Substring(start, end - start);

            if (!currentLine.Contains("Image") && subString.Length >= 2000) // Only attribute allowed over 2k characters is the Image attribute
                return false;

            else
                return true;
        }
    }
}
