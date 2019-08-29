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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        public string stuName;

        private string studentName;

        public string GetStudentName()
        {
            //return the private field
            return studentName;
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;

            //save to database here...

            MessageBox.Show("Thanks, student saved!");

            DialogResult = DialogResult.OK;
            Tag = name; //Store name in the Form Tag property
            stuName = name; //store name in a public  field
            studentName = name; //store name in private field
            Close();
        }
    }
}
