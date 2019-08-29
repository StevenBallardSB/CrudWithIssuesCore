using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    /// <summary>
    /// An individual customer
    /// </summary>
    class Customer
    {
        //No-args constructor
        public Customer(){}

        /// <summary>
        /// The first name of the customer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the customer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The customer's ID
        /// Auto incremented value
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The customer's official date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The customer's title Ex(Miss, Mr, Mrs, Dr)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A read-only property that returns the customer's full legal name (first + last)
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
