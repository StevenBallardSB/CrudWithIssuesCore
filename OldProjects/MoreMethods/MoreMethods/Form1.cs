using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int userNum;

            string input = "5431321";
            if(int.TryParse(input, out int userNum))
            {

            }
            else
            {
                MessageBox.Show("Thas's not a number");
            }

            string name = "joe";
            //THIS DOES NOT WORK
            //STIRNGS ARE IMMUTABLE (CANNOT BE CHANGED)
            MakeStringAllCaps(name);
            MessageBox.Show(name);

            //WORKS! Creating a new string and reassigning to the name variable
            name = name.ToUpper();

            PopulateTextBox(textBox1);
            PopulateTextBox(textBox2);
            PopulateTextBox(textBox3);

            int c = 25;
            MessageBox.Show("Before: " + c);
            DoubleNumberByRef(ref c);
            MessageBox.Show("After: " + c);

            int a = 5;
            int b = DoubleNumberByValue(a);
            MessageBox.Show(a + " " + b);
        }

        private void MakeStringAllCaps(string name)
        {
            name = name.ToUpper();
        }

        private void PopulateTextBox(TextBox box)
        {
            box.Text = "CLASSIFIED!!!!";
            box.ForeColor = Color.Red;
        }

        private void DoubleNumberByRef(ref int numToDouble)
        {
            numToDouble *= 2;
        }

        private int DoubleNumberByValue(int num)
        {
            return num * 2;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = "DO NOT CLICK ME!";

            //MessageBox.Show("Don't click here...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye, it was a good life");
        }
    }
}
