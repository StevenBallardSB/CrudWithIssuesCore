using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            
            if (IsPresent() && IsValidData() && IsOperator())
            {
                decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
                string Operator = txtOperator.Text;
                decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
                Calculate(Operand1, Operator, Operand2);
            }
            else
            {
                if (!IsPresent())
                {
                    MessageBox.Show("All fields must have a value.");
                }
                else
                {
                    if (!IsDecimal())
                    {
                        MessageBox.Show("Operand fields must be a decimal value.");
                    }
                    else
                    {
                        if (!IsValidData())
                        {
                            MessageBox.Show("Operand fields must be greater than 0 and less than 1,000,000,");
                        }
                    }
                    if (!IsOperator())
                    {
                        MessageBox.Show("Operator field must be one of these operators ('+' '-' '*' '/')");
                    }
                }
            }
        }

        private void Calculate(decimal txtOperand1, string txtOperator, decimal txtOperand2)
        {
            decimal result = 0;
            if (txtOperator == "+")
            {
                result = txtOperand1 + txtOperand2;
            }
            if (txtOperator == "-")
            {
                result = txtOperand1 - txtOperand2;
            }
            if (txtOperator == "*")
            {
                result = txtOperand1 * txtOperand2;
            }
            if (txtOperator == "/")
            {
                result = txtOperand1 / txtOperand2;
            }
            result = Math.Round(result, 4);
            txtResult.Text = Convert.ToString(result);
        }

        private bool IsOperator()
        {
            if (txtOperator.Text == "/".Trim() || txtOperator.Text == "+".Trim() || txtOperator.Text == "-".Trim() || txtOperator.Text == "*".Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidData()
        {
            if (IsDecimal())
            {
                decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
                if (Operand1 > 0 && Operand1 < 1000000 && Operand2 > 0 && Operand2 < 1000000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool IsDecimal()
        {
            try
            {
                decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }

        private bool IsPresent()
        {
            if (txtOperand1.Text == "".Trim() || txtOperator.Text == "".Trim() || txtOperand2.Text == "".Trim())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
