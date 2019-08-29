using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        /// <summary>
        /// Saves all unsaved files, and then closes the form
        /// </summary>
        private void CloseForm()
        {
            //This comment has the power to save files. Trust me.
            MessageBox.Show("Thanks for using my App");
            Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        /// <summary>
        /// Get a discount based on a given subtotal.
        /// The percent is returned as a decimal 0 -1.0
        /// </summary>
        /// <param name="subtotal"></param>
        
        private double GetDiscountPercent(double subtotal)
        { 
            if(subtotal >= 500)
            {
                return .2; //20%
            }
            return .1;
        }

        /// <summary>
        /// Calculates an investment value
        /// </summary>
        /// <param name="monthlyInvest">The amount of money invested each month</param>
        /// <param name="intRate">The monthely interest rate 0-1</param>
        /// <param name="months">Total number of months for the investment</param>
        /// <returns></returns>
        private double CalcFutureValue(double monthlyInvest, double monthelyInterestRate, ushort months)
        {
            double futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue += monthlyInvest * (1 + intRate);
            }

            return futureValue;
        }
    }
}
