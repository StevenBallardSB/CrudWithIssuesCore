using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstrolStructuresForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DayOfWeek currDay = DateTime.Today.DayOfWeek;

            switch (currDay)
            {
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                default:
                    break;
            }
            string employeeType = "WorkStudy";

            switch (employeeType)
            {
                case "Faculty":
                    MessageBox.Show("Teach well!");
                    break;
                case "Staff":
                    MessageBox.Show("Support the college!");
                    break;
                case "WorkStudy":
                    MessageBox.Show("Get paid!");
                    break;
                case "Prostitute":
                    MessageBox.Show("Get Laid!");
                    break;
            }


            bool isStudent = true;

            if (isStudent)
            {
                MessageBox.Show("You are a student");
            }

            double subtotal = 100;
            double discountPerc = 0;

            if (subtotal >= 0 && subtotal <= 50)
            {
                discountPerc = .1;
            }
            else if (subtotal > 50 && subtotal < 100)
            {
                discountPerc = .2;
            }
            else //If subtotal is greater than or equal to 100
            {
                discountPerc = .25;
            }
            MessageBox.Show($"Your discount percent is {discountPerc:p}");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
