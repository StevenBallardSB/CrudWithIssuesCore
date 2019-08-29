using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>();

        private void BtnAddName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
            {
                if (names.Count < 10)
                {
                    names.Add(txtName.Text);
                    MessageBox.Show($"{txtName.Text} has been added to the list.");
                    txtName.Clear();
                }
                else
                {
                    MessageBox.Show("No more names may be entered");
                    txtName.Clear();
                }
            }
            else
            {
                MessageBox.Show("A name must be entered before submitting");
            }
        }

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            names.Sort();
            names.Reverse();
            MessageBox.Show(String.Join(", ", names));
        }
    }
}
