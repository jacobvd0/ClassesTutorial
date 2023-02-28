using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    internal class Monster
    {
        public string name = "Monster";
        public int health;
        public int attackDamage;

        public Monster() // Default stats if none are specified
        {
            health = 100;
            attackDamage = 2;
        }

        public Monster(string _name, int _health, int _attackDamage) // Allows custom name, health, and attack damage to be specified when calling the class
        {
            name = _name;
            health = _health;
            attackDamage = _attackDamage;
        }

        public void attack() // Attacks for the amount specified in attackDamage
        {
            Console.WriteLine($"{name} attacked for {attackDamage}");
        }

        public void TakeDamage(int damage) // Takes damage for the amount specified then prints the amount of damage taken & how much health is left
        {
            health -= damage;
            Console.WriteLine($"{name} was hit for {damage}");
            Console.WriteLine($"{name} has {health} health left");
        }
    }
}
