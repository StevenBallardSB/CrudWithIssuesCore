using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class FrmAddAndUpdateStudent : Form
    {
        private Student existingStudent;

        public FrmAddAndUpdateStudent(Student s = null)
        {
            InitializeComponent();
            existingStudent = s;
            if(s != null)
            {
                btnAddStudent.Text = "Update Student";
                //change the form title bar
                Text = "Updating student : " + s.StudentId;

                //populate existing student data on the form
                txtFirstName.Text = existingStudent.FirstName;
                txtLastName.Text = existingStudent.LastName;
                txtProgram.Text = existingStudent.ProgramOfChoice;
                dtpDateOfBirth.Value = existingStudent.DateOfBirth;
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            Student stu = new Student()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ProgramOfChoice = txtProgram.Text,
                DateOfBirth = dtpDateOfBirth.Value
            };
            try
            {
                if (existingStudent != null)
                {
                    stu.StudentId = existingStudent.StudentId;
                    StudentDB.Update(stu);
                    MessageBox.Show("Student updated!");
                }
                else
                {
                    StudentDB.Add(stu);
                    MessageBox.Show("Student added!");
                }
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was a problem with the database, try again later");
#if DEBUG //preprocessor directive
                MessageBox.Show(ex.Message);
#endif
            }

        }
        private void FrmAddAndUpdateStudent_Load(object sender, EventArgs e)
        {
            SetDateOfBirthPickerBoundries();
        }

        /// <summary>
        /// Sets the min and max date a user may choose for the date of birth
        /// </summary>
        private void SetDateOfBirthPickerBoundries()
        {
            const short OldestPossibleStudentInYears = 120;
            dtpDateOfBirth.MaxDate = DateTime.Now;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-OldestPossibleStudentInYears);
        }
    }
}
