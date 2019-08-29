using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcTotalClick(object sender, EventArgs e)
        {
            double subtotal = Convert.ToDouble(txtSubtotal.Text);
            double taxRate = Convert.ToDouble(txtTaxRate.Text);

            double result = subtotal * (1 + taxRate);

            //c formats as currency
            MessageBox.Show(result.ToString("C"));
        }
    }
}
