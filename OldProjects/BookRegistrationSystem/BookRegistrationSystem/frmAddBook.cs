using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationSystem
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                ISBN = txtIsbn.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Title = txtTitle.Text
            };
            try
            {
                BookDB.Add(book);
                MessageBox.Show("Book added!");
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem with the database, try again later");
            }
            
        }
    }
}
