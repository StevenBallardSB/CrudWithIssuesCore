using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class BookRegistrationDB
    {
        public static void RegisterBook(Registration r)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText =
                "INSERT INTO Registration(CustomerID, ISBN, RegDate) " +
                "VALUES (@cId, @isbn, @regDate)";
            addCmd.Parameters.AddWithValue("@cId", r.CustomerId);
            addCmd.Parameters.AddWithValue("@isbn", r.ISBN);
            addCmd.Parameters.AddWithValue("@regDate", r.RegDate);

            try
            {
                con.Open();
                addCmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
