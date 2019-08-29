using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class StudentDB
    {
        public static List<Student> GetAllStudents()
        {
            //Get a connection to the DB
            SqlConnection con = SmsDB.GetConnection();

            //Set up query
            string query = "SELECT SID, FirstName, LastName, " +
                "DOB, Program " +
                "FROM Students";
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = query;

            //Open connection to DB
            con.Open();

            //Execute query
            SqlDataReader rdr = selCmd.ExecuteReader();

            //Do something with results
            List<Student> stuList = new List<Student>();
            while (rdr.Read())
            {
                Student tempStu = new Student();
                tempStu.StudentId = Convert.ToInt32(rdr["SID"]);
                tempStu.FirstName = Convert.ToString(rdr["FirstName"]);
                tempStu.LastName = Convert.ToString(rdr["LastName"]);
                tempStu.DateOfBirth = Convert.ToDateTime(rdr["DOB"]);
                tempStu.ProgramOfChoice = Convert.ToString(rdr["Program"]);
                stuList.Add(tempStu);
            }

            //Close connection
            con.Close();

            return stuList;
        }

        /// <summary>
        /// Adds a student to the database
        /// </summary>
        /// <param name="s">The student to be added</param>
        /// <exception cref="SqlException"></exception>
        public static void Add(Student s)
        {
            SqlConnection con = SmsDB.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            //ALWAYS USED PARAMETERIZED QUERIES!!!
            addCmd.CommandText = 
                "INSERT INTO Students(FirstName, LastName, DOB, Program) " +
                "VALUES (@fName, @lName, @dob, @program)";
            //Add values into parameters
            addCmd.Parameters.AddWithValue("@fName", s.FirstName);
            addCmd.Parameters.AddWithValue("@lName", s.LastName);
            addCmd.Parameters.AddWithValue("@dob", s.DateOfBirth);
            addCmd.Parameters.AddWithValue("@program", s.ProgramOfChoice);

            try
            {
                con.Open();
                addCmd.ExecuteNonQuery();
                //this will insert correctly OR throw a SQLException
            }
            finally
            {
                //con.Close();
                con.Dispose(); //dispose calls close internally
            }
            
        }

        /// <summary>
        /// Updates an existing student
        /// </summary>
        /// <param name="s">New student data</param>
        /// <exception cref="SqlException"></exception>
        public static void Update(Student s)
        {
            SqlConnection con = SmsDB.GetConnection();
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;
            updateCmd.CommandText = 
                "UPDATE Students " +
                    "SET FirstName = @fName, " +
                    "LastName = @lName, " +
                    "DOB = @dob, " +
                    "Program = @program " +
                "WHERE SID = @sid";
            updateCmd.Parameters.AddWithValue("@fName", s.FirstName);
            updateCmd.Parameters.AddWithValue("@lName", s.LastName);
            updateCmd.Parameters.AddWithValue("@dob", s.DateOfBirth);
            updateCmd.Parameters.AddWithValue("@program", s.ProgramOfChoice);
            updateCmd.Parameters.AddWithValue("@sid", s.StudentId);

            try
            {
                con.Open();
                int rowsAffected = updateCmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }

        /// <summary>
        /// Deletes an existing student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            SqlConnection con = SmsDB.GetConnection();

            SqlCommand delCmd = new SqlCommand();
            delCmd.Connection = con;
            delCmd.CommandText =
                "DELETE FROM Students WHERE " +
                "SID = @id";
            delCmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                int rowsAffected = delCmd.ExecuteNonQuery();
                //if (rowsAffected == 1)
                //    return true;
                //else
                //    return false;
                //return (rowsAffected == 1) ? true : false;
                return rowsAffected == 1;
            }
            finally
            {
                con.Dispose();
            }
        }
        
    }
}
