using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTexting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string msg = "";

            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();

                if (letter == "0")
                {
                    msg += " ";
                }
                else
                {
                    int mainDigit = (int)Char.GetNumericValue(letter[0]);
                    int numberOfDigits = letter.Length;
                    int offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    int letterIndex = offset + numberOfDigits - 1;

                    char currentLetter = (char)(letterIndex + 97);
                    msg += currentLetter;
                }
            }
            Console.WriteLine(msg);
        }
    }
}


