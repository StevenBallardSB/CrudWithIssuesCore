using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter age:");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out byte age))
                {
                    Console.WriteLine("Thanks!");
                    break;
                }
            } while (true);

            Console.ReadKey();
            foreach (string currName in args)
            {
                Console.WriteLine(currName);
            }



            for (int name = 0;name  < args.Length; name++)
            {
                Console.WriteLine(args[name]);
            }

            Console.ReadKey();

            for (int currNum = 1; currNum < 10; currNum++)
            {
                Console.WriteLine(currNum);
            }

            Console.ReadKey();

            bool validAge = false;
            do
            {
                Console.WriteLine("Please enter your age:");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out byte age))
                {
                    validAge = true;
                    Console.WriteLine("Thanks!");
                }
            } while (!validAge);


            int count = 0;
            while (count < 10)
            {
                count++;
                Console.WriteLine(count);
            }
            Console.Read();
        }
    }
}
