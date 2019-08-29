using ModelsAndModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding
{
    public class StudentDB
    {
        /// <summary>
        /// Register a student
        /// </summary>
        /// <param name="stu">Student to be registered</param>
        /// <exception cref="SqlException"
        public static void Register(Student stu)
        {
            throw new NotImplementedException();

            SqlConnection con = new SqlConnection("con string");
            SqlCommand cmd = new SqlCommand("query here...");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
