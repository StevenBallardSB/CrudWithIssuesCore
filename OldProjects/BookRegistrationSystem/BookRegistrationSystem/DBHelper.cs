using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class DBHelper
    {
        /// <summary>
        /// Gets a connection to the Book registration database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;";
            return con;
        }
    }
}
