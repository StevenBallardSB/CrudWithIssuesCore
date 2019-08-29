using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationSystem
{
    class Book
    {
        //This is a No-Arg constructor
        public Book(){}

        /// <summary>
        /// The ID for an individual book
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// The price for an individual book
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The title or name of an individual book
        /// </summary>
        public string Title { get; set; }
    }
}
