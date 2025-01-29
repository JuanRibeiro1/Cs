using System;

namespace Else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            Console.WriteLine(total);

            if ((roll1 == roll2) || (roll2 == roll3) || roll1 == roll3)
            {

                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled a triple, +6 bonus total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled a doubles! +2 bonus total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }

            else if (total >= 10)
            {
                Console.WriteLine("You a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a cat!");
            }

        }
    }
}
