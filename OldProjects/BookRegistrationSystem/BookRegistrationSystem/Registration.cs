using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class Registration
    {

        /// <summary>
        /// The no arg constructor
        /// </summary>
        public Registration() { }

        /// <summary>
        /// The Unique customer id
        /// </summary>
        public int CustomerId { get; set; }


        /// <summary>
        /// The 13 digit unique book id
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// The date that the book was registered to the customer
        /// </summary>
        public DateTime RegDate { get; set; }
    }
}
