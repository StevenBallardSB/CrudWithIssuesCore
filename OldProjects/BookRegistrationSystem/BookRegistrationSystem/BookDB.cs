using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class BookDB
    {
        public static List<Book> GetAllStudents()
        {
            SqlConnection con = DBHelper.GetConnection();

            //Set up query
            string query =
                "SELECT ISBN, Price, Title " +
                "FROM Book";
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = query;

            //Open connection to DB
            con.Open();

            //Execute query
            SqlDataReader rdr = selCmd.ExecuteReader();

            //Do something with results
            List<Book> bookList = new List<Book>();
            while (rdr.Read())
            {
                Book tempBook = new Book();
                tempBook.ISBN = Convert.ToString(rdr["ISBN"]);
                tempBook.Price = Convert.ToDouble(rdr["Price"]);
                tempBook.Title = Convert.ToString(rdr["Title"]);
                bookList.Add(tempBook);
            }

            //Close connection
            con.Close();

            return bookList;
        }

        public static void Add(Book b)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;

            addCmd.CommandText =
                "INSERT INTO Book(ISBN, Price, Title)" +
                "VALUES (@isbn, @price, @title)";

            addCmd.Parameters.AddWithValue("@isbn", b.ISBN);
            addCmd.Parameters.AddWithValue("@price", b.Price);
            addCmd.Parameters.AddWithValue("@title", b.Title);

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
