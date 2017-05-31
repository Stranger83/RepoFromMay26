using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var startBalance = balance;

            while (balance > 0)
            {

                var command = Console.ReadLine();

                switch (command)
                {
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }

                        break;
                    case "CS: OG":
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }

                        break;
                    case "Zplinter Zell":
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }

                        break;
                    case "Honored 2":
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }

                        break;
                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }

                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${startBalance - balance:F2}. Remaining: ${balance:F2}");
                        return;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

            }
            Console.WriteLine("Out of money!");
        }
    }
}

