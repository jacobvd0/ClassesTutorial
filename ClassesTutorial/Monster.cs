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


        public void attack()
        {
            Console.WriteLine($"{name} attacked for {attackDamage}");
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"{name} was hit for {damage}");
            Console.WriteLine($"{name} has {health} health left");
        }
    }
}
