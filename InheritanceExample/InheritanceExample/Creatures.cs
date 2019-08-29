using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    /// <summary>
    /// A base class to represent human and AI controlled characters
    /// </summary>
    abstract class Creature
    {
        public Creature(String name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public double Health { get; set; }
        public int Defence { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public string Race { get; set; }
        
       /// <summary>
       /// Returns a basic sring representation of the creature
       /// </summary>
       /// <param name="sep">Separator to place between each piece of data</param>
       /// <returns></returns>
       public virtual string GetDisplayText(string sep)
       {
            return $"{Name}{sep}{Health}{sep}{Race}";
       }

        public abstract string Speak();
    }

    class Player : Creature
    {
        public Player(string playerName) : base(playerName)
        {
        }


        /// <summary>
        /// Stamina is used when running or performing physical actions
        /// </summary>
        public double Stamina { get; set; }

        /// <summary>
        /// These are the magic points for the character
        /// Spells use mana to execute
        /// </summary>
        public double Mana { get; set; }

        public override string GetDisplayText(string sep)
        {
            return "Player:" + base.GetDisplayText(sep) + sep + Stamina;
        }

        public override string Speak() {
            return $"Hey, my name is {Name}";
        }
    }

    [DebuggerDisplay("EnemyId: {EnemyId}")]
    class Enemy : Creature
    {
        public Enemy(string enemyName) : base(enemyName)
        {
            ItemDrops = new List<Item>();
        }

        public int EnemyId { get; set; }

        /// <summary>
        /// How long the enemy takes to respawn after they are defeated. If the enemy does not have a respawn rate
        /// once they are defeated they never respawn
        /// </summary>
        public TimeSpan? RespawnRate { get; set; }

        //The number of experience points a player gains from defeating this enemy
        public int ExperienceDropRate { get; set; }

        public List<Item> ItemDrops { get; set; }

        public override string Speak()
        {
            return $"You will never get my {ItemDrops}";
        }
    }
}
