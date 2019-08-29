using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            APEntities context = new APEntities();
            context.Database.Log = Console.WriteLine;

            Vendor ibm =
                (from v in context.Vendors
                 where v.VendorName == "IBM"
                 select v).SingleOrDefault();
            if(ibm != null)
            {
                Console.WriteLine(ibm.VendorID);
            }

            int numVendors =
                (from v in context.Vendors
                 select v).Count();
            Console.WriteLine("Count is : " + numVendors);

            // Get all vendors
            List < Vendor > allCAVendors =
                (from v in context.Vendors
                 where v.VendorState == "CA"
                 orderby v.VendorName ascending
                 select v).ToList();

            //foreach (Vendor currVendor in allCAVendors)
            //{
            //    Console.WriteLine(currVendor.VendorName);
            //}

            //Get VendorNames and location
            // Name, City, State
            var vendorLocations =
                (from v in context.Vendors
                 select new { v.VendorName, v.VendorState, v.VendorCity }).ToList();

            //foreach (var venLoc in vendorLocations)
            //{
            //    Console.WriteLine($"{venLoc.VendorName} is at \n{venLoc.VendorCity} {venLoc.VendorState}\n\n");
            //}

            // Get all Vendors and their Invoices
            List<Vendor> vendors =
                (from v in context.Vendors.Include(nameof(Vendor.Invoices))
                 select v).ToList();
            foreach (Vendor v in vendors)
            {
                Console.WriteLine(v.VendorName);
                foreach (Invoice inv in v.Invoices)
                {
                    Console.WriteLine($"\t{inv.InvoiceNumber}");
                }
            }

            Console.ReadKey();
        }
    }
}
