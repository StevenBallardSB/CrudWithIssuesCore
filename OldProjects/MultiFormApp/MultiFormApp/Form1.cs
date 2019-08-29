using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAddStudentForm_Click(object sender, EventArgs e)
        {
            FrmAddStudent addStuForm = new FrmAddStudent();
            DialogResult result = addStuForm.ShowDialog();

            if(result == DialogResult.OK) //saved the student
            {
                //string student = (string)addStuForm.Tag;
                //string student = addStuForm.stuName;
                string student = addStuForm.GetStudentName();
                MessageBox.Show($"Thanks for adding {student}");
            }
            else
            {
                MessageBox.Show("Am I a joke to you");
            }
        }
    }
}
