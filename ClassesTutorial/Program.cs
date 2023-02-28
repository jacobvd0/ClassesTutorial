using System;

namespace ClassesTutorial // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monsterOne = new Monster(); // Call the Monster class located in Monster.cs
            Monster monsterTwo = new Monster("Bob", 50, 3); // Calls the Monster class and spcifies custom stats

            monsterOne.attack(); // Make the monster attack
            monsterOne.TakeDamage(20); // Make the monster take 20 damage
            monsterTwo.attack(); // Makes monster number 2 attack

            Console.ReadKey();
        }
    }
}