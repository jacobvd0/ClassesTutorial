using System;

namespace ClassesTutorial // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monsterOne = new Monster(); // Call the Monster class located in Monster.cs
            monsterOne.health = 100; // Set the health the monster has
            monsterOne.attackDamage = 2; // Set the amount of damage the monster deals

            monsterOne.attack(); // Make the monster attack
            monsterOne.TakeDamage(20); // Make the monster take 20 damage

            Console.ReadKey();
        }
    }
}