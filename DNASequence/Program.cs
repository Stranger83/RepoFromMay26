using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        sum = i + j + k;
                        if (sum >= matchSum)
                        {
                            Console.Write($"O{i}{j}{k}O ".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));
                        }
                        else
                        {
                            Console.Write($"X{i}{j}{k}X ".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));
                        }
                        counter++;
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
