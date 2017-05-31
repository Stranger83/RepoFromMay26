using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                sum += count * price;
                if (count > 1)
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }

            }
            Console.WriteLine($"Subtotal: ${sum:F2}");
            if(sum <= budget)
            {
                Console.WriteLine($"Money left: ${budget - sum:F2}");
            } else
            {
                Console.WriteLine($"Not enough. We need ${sum - budget:F2} more.");
            }
        }
    }
}
