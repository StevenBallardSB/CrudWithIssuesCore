using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    /// <summary>
    /// an individual clover park student
    /// </summary>
    public class Student
    {
        private DateTime _dateOfBirth;
        private string _programOfChoice;

        //This is the default no-args constructor
        //The compiler will create a no-args constructor
        //If no other constructors are found
        public Student() { }

        /// <summary>
        /// Creates a student with a given first and last name
        /// </summary>
        /// <param name="fName">The legal first name</param>
        /// <param name="lName">The legal last name</param>
        public Student(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        /// <summary>
        /// The legal first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name of the student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The Id of the student
        /// Auto incremented value
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The students official date of birth
        /// Only month day and year.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Future birth dates not allowed");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// The name of the program that the student is registered in.
        /// ex. Mechetronics
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if being set to null or whitespace</exception>
        public string ProgramOfChoice
        {
            get
            {
                return _programOfChoice;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cannot be null or whitespace");
                }
                _programOfChoice = value;
            }
        }

        /// <summary>
        /// A read-only property that returns the students full legal name (first + last)
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        /// <summary>
        /// Returns all student data split by text
        /// </summary>
        /// <param name="separator"></param>
        /// <returns></returns>
        public string GetDisplayText(string separator)
        {
            return $"{LastName},{FirstName}{separator}" + $"{DateOfBirth.ToShortDateString()}{separator}";
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
