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
    public partial class frmBookRegistration : Form
    {
        public frmBookRegistration()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.ShowDialog();
            PopulateCustomers();
        }

        private void FrmBookRegistration_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            PopulateBooks();
            ResetUserInputs();
        }

        private void PopulateBooks()
        {
            List<Book> book = BookDB.GetAllStudents();

            cboxBook.DataSource = book;
            cboxBook.DisplayMember = nameof(Book.Title);
        }

        /// <summary>
        /// Clears all of the users inputs
        /// </summary>
        private void ResetUserInputs()
        {
            cboxCustomer.SelectedIndex = -1;
            cboxBook.SelectedIndex = -1;
            dtpDateRegistered.Value = DateTime.Now;
        }

        /// <summary>
        /// Populates the Customer Combo Box
        /// </summary>
        private void PopulateCustomers()
        {
            List<Customer> customers = CustomerDB.GetAllCustomers();

            cboxCustomer.DataSource = customers;
            cboxCustomer.DisplayMember = nameof(Customer.FullName);
        }

        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            Customer customer = cboxCustomer.SelectedItem as Customer;
            Book book = cboxBook.SelectedItem as Book;

            Registration reg = new Registration()
            {
                CustomerId = customer.CustomerId,
                ISBN = book.ISBN,
                RegDate = dtpDateRegistered.Value
            };
            try
            {
                BookRegistrationDB.RegisterBook(reg);
                MessageBox.Show("Book registered to customer!");
                ResetUserInputs();
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem with the database, try again later");
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook addBookForm = new frmAddBook();
            addBookForm.ShowDialog();
            PopulateBooks();
        }
    }
}
