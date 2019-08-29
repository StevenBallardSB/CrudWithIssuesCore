using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLunchOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creates global variable for addon price
        double addon = 0;

        //Creates global variable for taxrate
        double taxrate = .0775;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RbtnHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHamburger.Checked)
            {
                ClearTextBoxes();
                ClearCheckBoxes();
                ModifyAddonItems("Add-on items ($.75/each)", "Lettuce, tomato, and onions", "Ketchup, mustard, and mayo", "French fries", .75);
            }

        }

        private void RbtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPizza.Checked)
            {
                ClearTextBoxes();
                ClearCheckBoxes();
                ModifyAddonItems("Add-on items ($.50/each)", "Pepperoni", "Sausage", "Olives", .50);
            }
        }



        private void RbtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSalad.Checked)
            {
                ClearTextBoxes();
                ClearCheckBoxes();
                ModifyAddonItems("Add-on items ($.25/each)", "Croutons", "Bacon bits", "Bread sticks", .25);
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// Checks to see which maincourse has been checked, once it knows that it asigns the appropirate value to subtotal.
        /// this method then checks which addons have been added, then adds the cost of the addons to subtotal
        /// </summary>
        /// <returns>double: the value of subtotal</returns>
        private double CalculateSubtotal()
        {
            //A variable to hold the value that needs to be returned
            double subtotal = 0.0;
            if (rbtnHamburger.Checked)
            {
                subtotal = 6.95;
            }
            else if (rbtnPizza.Checked)
            {
                subtotal = 5.95;
            }
            else if (rbtnSalad.Checked)
            {
                subtotal = 4.95;
            }

            if (checkBox1.Checked)
            {
                subtotal += addon;
            }
            if (checkBox2.Checked)
            {
                subtotal += addon;
            }
            if (checkBox3.Checked)
            {
                subtotal += addon;
            }
            return subtotal;
        }

        /// <summary>
        /// Modifies the items in the checkboxes according to the main course selected
        /// </summary>
        /// <param name="title">The global variable title</param>
        /// <param name="cbox1">The checkbox 1 text</param>
        /// <param name="cbox2">The checkbox 2 text</param>
        /// <param name="cbox3">The checkbox 3 text</param>
        /// <param name="value">The addons monetary value</param>
        private void ModifyAddonItems(String title, String cbox1, String cbox2, String cbox3, Double value)
        {
            gboxAddOnItems.Text = title;
            checkBox1.Text = cbox1;
            checkBox2.Text = cbox2;
            checkBox3.Text = cbox3;
            addon = value;
        }

        /// <summary>
        /// sets the textboxes in the ordertotal to a blank textbox
        /// </summary>
        private void ClearTextBoxes()
        {
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtOrderTotal.Text = "";
            
        }

        /// <summary>
        /// unchecks the addons
        /// </summary>
        private void ClearCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        /// <summary>
        /// Calculates the tax by multiplying the subtotal against the global variable taxrate
        /// </summary>
        /// <param name="subtotal">The subtotal value that is multiplied against the taxrate</param>
        /// <returns>The value of tax</returns>
        private double CalculateTax(double subtotal)
        {
            return subtotal * taxrate;
        }

        /// <summary>
        /// Calculates the total by adding subtotal and tax together
        /// </summary>
        /// <param name="subtotal">The subtotal value thats added against tax</param>
        /// <param name="tax">The tax value thats added against subtotal</param>
        /// <returns>The total value</returns>
        private double CalculateTotal(double subtotal, double tax)
        {
            return subtotal + tax;
        }

        /// <summary>
        /// fills the text boxes with the appropirate values after calling some calculate methods.
        /// </summary>
        private void FillTextBoxes()
        {
            //This variable holds the subtotal
            double subtotal = CalculateSubtotal();
            txtSubtotal.Text = subtotal.ToString("C", CultureInfo.CurrentCulture);

            //This variable holds the tax
            double tax = CalculateTax(subtotal);
            txtTax.Text = tax.ToString("C", CultureInfo.CurrentCulture);

            //This variable holds the total
            double total = CalculateTotal(subtotal, tax);
            txtOrderTotal.Text = total.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}