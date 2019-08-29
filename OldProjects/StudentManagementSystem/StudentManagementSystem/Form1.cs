using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStudentListBox();
        }

        private void PopulateStudentListBox()
        {
            List<Student> students = StudentDB.GetAllStudents();
            //Ordering the students in alphabetical order
            students = students.OrderBy(stu => stu.FirstName).ToList();

            //Databinding - internally loops through and adds each student
            lstStudents.DataSource = students;
            lstStudents.DisplayMember = nameof(Student.FullName);
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddAndUpdateStudent addStuForm = new FrmAddAndUpdateStudent();
            addStuForm.ShowDialog();
            PopulateStudentListBox();
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            //If no student selected, tell user and break out of method
            if(lstStudents.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a student!");
                return;
            }

            Student stu = lstStudents.SelectedItem as Student;

            string msg = $"Are you sure you want to delete {stu.StudentId} : {stu.FullName}. \n {stu.DateOfBirth.ToShortDateString()}\n{stu.ProgramOfChoice}.";

            DialogResult answer = MessageBox.Show(msg, "Delete Student?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(answer == DialogResult.Yes)
            {
                if (StudentDB.Delete(stu.StudentId))
                {
                    PopulateStudentListBox();
                    MessageBox.Show("Student deleted successfully");
                }
                
            }
        }

        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            Student selectedStu = lstStudents.SelectedItem as Student;
            var updateForm = new FrmAddAndUpdateStudent(selectedStu);

            updateForm.ShowDialog();
            PopulateStudentListBox();
        }
    }
}
