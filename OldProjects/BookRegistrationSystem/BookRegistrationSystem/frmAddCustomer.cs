using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationSystem
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Title = txtTitle.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDOB.Value
            };
            try
            {
                CustomerDB.Add(customer);
                MessageBox.Show("Customer added!");
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem with the database, try again later");
            }
        }
    }
}
