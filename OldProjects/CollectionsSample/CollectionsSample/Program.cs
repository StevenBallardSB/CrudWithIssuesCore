using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FILO - First in last out
            Stack<int> stackNums = new Stack<int>();
            stackNums.Push(1);
            stackNums.Push(2);
            stackNums.Push(3);
            while (stackNums.Count > 0)
            {
                Console.WriteLine(stackNums.Pop());
                Thread.Sleep(5000);
            }

            //FIFO - First In First Out
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Joe");
            customers.Enqueue("Jim");
            customers.Enqueue("Pam");

            while(customers.Count > 0)
            {
                string nextCustomer = customers.Dequeue();
                Console.WriteLine($"Now serving {nextCustomer}");
                Thread.Sleep(3000);
            }

            List<int> numbers = new List<int>();
            GetNumbersFromUser(numbers);

            int sum = numbers.Sum();
            //foreach (int currNum in numbers)
            //{
            //    sum += currNum;
            //}
            Console.WriteLine(sum);
            Console.ReadKey();

            var names = new List<string>();
            names.Add("Joe");
            names.Add("Pam");
            names.Add("Jim");
            names.Add("Mike");
            names.Add("John");

            //Do not use old collection
        }

        private static void GetNumbersFromUser(List<int> numbers)
        {
            do
            {
                Console.WriteLine("Enter a number. Q to quit");
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("NO! I sad number");
                }
            } while (true);
        }
    }
}
