using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructurePractice_4A_4B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value 0 to quit.");
            Console.Write("Enter an integer: ");
            int i = Int32.Parse(Console.ReadLine());
            int Total = i;
            int Count = 1;
            while (i != 0)
            {
                
                if (i < 10)
                {
                    Console.WriteLine("This number is too small.");
                }
                else
                {
                    Console.WriteLine("This number is big enough.");
                }
                Console.Write("Enter an integer: ");
                i = Int32.Parse(Console.ReadLine());
                Total += i;
                Count++;
            }
            double Average = (Total * 1.0 / Count * 1.0);
            Console.WriteLine($"The total is {Total}");
            Console.WriteLine($"The average is {Average}");
            Console.ReadKey();
        }
    }
}
