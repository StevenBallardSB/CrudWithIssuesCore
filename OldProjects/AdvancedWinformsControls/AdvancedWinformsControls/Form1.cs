using System;
using System.Windows.Forms;

namespace AdvancedWinformsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateExpirationYears();
        }

        /// <summary>
        /// Populates the list of the next 5 years
        /// into the expiration year combobox
        /// </summary>
        private void PopulateExpirationYears()
        {
            cboExpYear.Items.Add("-- Choose an Exp Year --");

            int currYear = DateTime.Now.Year;
            int endYear = currYear + 5;
            for (int year = currYear; year <= endYear; year++)
            {
                cboExpYear.Items.Add(year);
            }

            cboExpYear.SelectedIndex = 0;
        }

        private void cboExpYear_SelectedIndexChanged(object sender, EventArgs e)
        { //Fires everytime the index is changed

            if (cboExpYear.SelectedIndex <= 0)
            {
                return;
            }

            //cast object to int
            int chosenYear = (int)cboExpYear.SelectedItem;
            MessageBox.Show($"You chose {chosenYear}");
        }

        private void btnClearYears_Click(object sender, EventArgs e)
        {
            int totalItems = cboExpYear.Items.Count;
            MessageBox.Show($"Items before clear {totalItems}");

            cboExpYear.Items.Clear();
        }

        private void radFaculty_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonChoise(radFaculty);
        }

        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonChoise(radStaff);
        }
        private void DisplayPersonChoise(RadioButton radButton)
        {
            if (radButton.Checked)
            {
                MessageBox.Show($"You chose {radButton.Text}!");
            }
        }
    }
}
