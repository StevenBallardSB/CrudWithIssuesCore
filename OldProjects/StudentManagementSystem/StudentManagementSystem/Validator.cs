using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    /// <summary>
    /// Contains helper methods for common validation
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Checks if the textbox has any data Whitespace does not count
        /// </summary>
        /// <param name="box">The TextBox to check</param>
        /// <returns>rReturn true if thhere is something besides null or whitespace</returns>
        public static bool isPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the input is a valid 13 digit ISBN dashes are ignored
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsIsbn(string input)
        {
            //dashes are ignored so we remove them
            input = input.Replace("-", string.Empty);

            return Regex.IsMatch(input, @"^/d{13}$");

            //if (input.Length != 13)
            //    return false;

            ////return false if a non-digit character is found
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (!char.IsDigit(input[i]))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
    }
}
