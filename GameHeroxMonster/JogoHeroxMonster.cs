using System;

namespace ConsoleApp1
{
        internal class Program
        {
            static void Main(string[] args)
            {

                Random random = new Random();


                int heroLife = 10;
                int monsterLife = 10;

                do
                {
                    int damage = random.Next(1, 10);

                    monsterLife -= damage;

                    Console.WriteLine($"Monster levou {damage} de dano, resta {monsterLife} de vida.");

                    if (monsterLife <= 0) continue;

                    damage = random.Next(1, 10);

                    heroLife -= damage;

                    Console.WriteLine($"Hero levou {damage} de dano, resta {heroLife} de vida.");
                }
                while (heroLife > 0 && monsterLife > 0);

                Console.WriteLine(heroLife > monsterLife ? "Hero ganhou!" : "Monster ganhou!");


            }
        }
}
