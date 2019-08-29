using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Validates inputs is a valid byte. If invalid, error message is shown in target Label.
        /// </summary>
        /// <param name="input">Input to validate</param>
        /// <param name="errlbl">Label to show error msg</param>
        /// <returns></returns>
        private bool IsValidByte(string input, Label errlbl)
        {
            try
            {
                Convert.ToByte(input);
                return true;
            }
            catch (Exception)
            {
                errlbl.Text = "Must be a number between 0 and 255";
                return false;
            }
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            ResetAllErrorMessages(lblAgeErrMsg);

            if(IsValidByte(txtAge.Text, lblAgeErrMsg))
            {
                byte age = Convert.ToByte(txtAge.Text);
                MessageBox.Show($"Thank you, now we know that you are {age} years old.");
            }

            /*
            try
            {
                byte age = Convert.ToByte(txtAge.Text);
                MessageBox.Show("Thanks!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Please enter a valid age. Ex. 30");
            }
            */
           

            
        }

        private void ResetAllErrorMessages(Label errlbl)
        {
            //reset all error labels one by one
            errlbl.Text = string.Empty;
        }

        /// <summary>
        /// Checks if a string is a byte and displays an error msg if not
        /// </summary>
        /// <param name="input">Input to check if it is a byte</param>
        /// <param name="nameOfInput">Name of data to display in err msg</param>
        /// <returns></returns>
        private bool IsValidByte(string input, string nameOfInput)
        {
            try
            {
                Convert.ToByte(input);
                return true;
            }
            catch (FormatException) //input was not a number
            {
                MessageBox.Show($"{nameOfInput} must be a number!");
                //return false;
            }
            catch (OverflowException) //input was could not fit into a byte
            {
                MessageBox.Show($"{nameOfInput} must be between the numbers {byte.MinValue} and {byte.MaxValue}");
                //return false;
            }
            return false;
        }

        /// <summary>
        /// Ensure username is not one of the blacklisted names
        /// </summary>
        /// <exception cref="Exception"></exception>
        /// <param name="username">The username to check</param>
        /// <returns></returns>
        private bool isValidUsername(string username)
        {
            try
            {
                if (username.ToLower() == "admin")
                {
                    throw new Exception("Invalid username!!");
                }
                return true;
            }
            catch(Exception ex)
            {
                //log the exception to a text file
                throw ex;
            }
        }

        private bool IsValidAge(string input)
        {
            try
            {
                byte age = Convert.ToByte(input);
                if(age < 12 || age > 125)
                {
                    throw new OverflowException("Age not valdi");
                }
                return true;
                //if (age >= 12 && age <= 125)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnValidateUsername_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidUsername(txtUserName.Text))
                {
                    MessageBox.Show("Username is valid!!!");
                }
                else
                {
                    MessageBox.Show("Pick a different name!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("That username CANNOT be used!");
            }
        }
        
        /// <summary>
        /// Checks to see if the Usernanme is empty
        /// </summary>
        /// <param name="box"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsPresent(TextBox box, string name)
        {
            //if(box.Text.Trim() == string.Empty)
            if(string.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show($"{name} is required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="box"></param>
        /// <param name="name"></param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max"></param>
        /// <returns></returns>
        private bool IsWithinRange(TextBox box, string name, double min, double max)
        {
            throw new NotImplementedException();
        }
    }


}
