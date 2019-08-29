using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] test = new string[3]
            {
                "first", "second", "third"
            };

            string[] testTwo = new string[test.Length];
            Array.Copy(test, 0, testTwo, 0, test.Length);
            testTwo[0] = "Some data...";



            string[] months =
            {
                "J", "F", "M", "A"
            };

            const int MaxNumNames = 3;
            string[] nameList = new string[MaxNumNames];
            nameList[0] = "Joe";
            nameList[1] = "was";
            nameList[2] = "here";
            //nameList[3000] = "nope";

            //string display = nameList[0] + nameList[1] + nameList[2];
            //string display = $"{nameList[0]} {nameList[1]} {nameList[2]}";
            string display = string.Join(" ", nameList);
            Console.WriteLine(display);
            Console.ReadKey();
        }
    }
}
