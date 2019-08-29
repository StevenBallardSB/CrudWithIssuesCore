using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructurePractice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a class to to see the details of in this generic FPS by entering the letter in front of the class.");
            Console.WriteLine("Type in q to quit");
            Console.WriteLine("A. Assault");
            Console.WriteLine("B. Support");
            Console.WriteLine("C. Scout");
            Console.WriteLine("D. Medic");
            string Choice = Console.ReadLine().ToLower();
            while (!Choice.Equals("q"))
            {
                switch (Choice)
                {
                    case "a":
                        Console.WriteLine("The assault class is the class with the most grenades, and is the only class with access to assault rifles.");
                        break;
                    case "b":
                        Console.WriteLine("The support class has ammo crates to help everyone else refill on ammo, and is the only class with access to Light machine guns.");
                        break;
                    case "c":
                        Console.WriteLine("The Scout class is the only class that can carry a sniper rifle. his/her own footstep noises are also reduced.");
                        break;
                    case "d":
                        Console.WriteLine("The medic class has healing supplies to bring team mates back to full health, and is the only class with access to shotguns.");
                        break;
                }
                Console.WriteLine("Choose a class to to see the details of in this generic FPS by entering the letter in front of the class.");
                Console.WriteLine("A. Assault");
                Console.WriteLine("B. Support");
                Console.WriteLine("C. Scout");
                Console.WriteLine("D. Medic");
                Choice = Console.ReadLine().ToLower();
            }
        }
    }
}
