using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class SmsDB
    {
        /// <summary>
        /// Gets a connection to the student managment system database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(); 
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=SMS;Integrated Security=True";
            return con;

            //var con2 = new SqlConnection("con string here...");
            //return con2;

            //return new SqlConnection("con string here...")
        }
    }
}
