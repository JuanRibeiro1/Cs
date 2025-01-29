using System;

namespace Renovacao_assinatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            daysUntilExpiration = 0;
            Console.WriteLine(daysUntilExpiration);

            if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
            {
                Console.WriteLine("Your subsciption expire soon, renew now!");
            }

            else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
                Console.WriteLine("Renew now and save 10%");
            }

            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine("Renew now and save 20%");
            }

            else if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired");
            }
        }
    }
}
