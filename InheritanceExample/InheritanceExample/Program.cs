using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("stevenballard");
            p1.Attack = 100;
            p1.Health = 20.75;
            p1.Stamina = 30.13;

            Item tooth = new Item()
            {
                ItemId = 1000,
                Name = "Shark Tooth - Large",
                MonetaryValue = 1500
            };

            Item fin = new Item()
            {
                ItemId = 500,
                Name = "Shark Fin - Large",
                MonetaryValue = 1000
            };

            Enemy e = new Enemy("Megaladon");
            e.ItemDrops.Add(tooth);
            e.ItemDrops.Add(fin);
            e.EnemyId = 1;
            e.Defence = 100;
            // 5.5 hours to respawn
            e.RespawnRate = new TimeSpan(5, 30, 0);

            Creature c = new Player("Mabaleen");

            List<Creature> allCreatures = new List<Creature>()
            {
                p1, e, c
            };

            foreach (Creature entity in allCreatures)
            {
                DisplayCreature(entity);
            }
            //DisplayCreature(p1);
            //DisplayCreature(e);
            //DisplayCreature(c);

            Console.ReadKey();
        }

        static void DisplayCreature(Creature c)
        {
            if(c is Enemy)
            {
                Enemy currEnemy = c as Enemy;
                Console.WriteLine("Id: " + currEnemy.EnemyId);
                Console.WriteLine("Enemy stats hidden");
            }
            else
            {
                Console.WriteLine(c.GetDisplayText("\n"));
            }
            
        }
        
    }
}
