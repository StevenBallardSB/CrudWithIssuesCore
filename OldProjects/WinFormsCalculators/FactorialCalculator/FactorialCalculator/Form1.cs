﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            long Number = Convert.ToInt64(NumberTxt.Text);
            long Factorial = 1;

            for (int i = 1; i <= Number; i++)
            {
                Factorial *= i;
            }
            FactorialTxt.Text = Convert.ToString(String.Format("{0:n0}", Factorial));
        }
    }
}
