using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            SqlConnection con = DBHelper.GetConnection();

            //Set up query
            string query =
                "SELECT CustomerID, DateOfBirth, FirstName, LastName, Title " +
                "FROM Customer";
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = query;

            //Openconnection to DB
            con.Open();

            //Execute query
            SqlDataReader rdr = selCmd.ExecuteReader();

            //Do something with results
            List<Customer> customerList = new List<Customer>();
            while (rdr.Read())
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                tempCustomer.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                tempCustomer.FirstName = Convert.ToString(rdr["FirstName"]);
                tempCustomer.LastName = Convert.ToString(rdr["LastName"]);
                tempCustomer.Title = Convert.ToString(rdr["Title"]);
                customerList.Add(tempCustomer);
            }

            //Close connection
            con.Close();

            return customerList;
        }

        /// <summary>
        /// Adds a Customer to the database
        /// </summary>
        /// <param name="c">The customer to be added</param>
        /// <exception cref="SqlException"></exception>
        public static void Add(Customer c)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText =
                "INSERT INTO Customer(DateOfBirth, FirstName, LastName, Title) " +
                "VALUES (@dob, @fName, @lName, @title)";
            //Add values into parameters
            addCmd.Parameters.AddWithValue("@dob", c.DateOfBirth);
            addCmd.Parameters.AddWithValue("@fName", c.FirstName);
            addCmd.Parameters.AddWithValue("@lName", c.LastName);
            addCmd.Parameters.AddWithValue("@title", c.Title);

            try
            {
                con.Open();
                addCmd.ExecuteNonQuery();
                //This will insert correctly Or throw a SQLException
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
