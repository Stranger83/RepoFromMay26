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
                char button = letter[0];
                switch (button)
                {
                    case '0':
                        msg += " ";
                        break;
                    case '2':
                       //letter.Length-3 = 'a';
                        msg += "a";
                        break;
                    case '3':
                        msg += "";
                        break;
                    case '4':
                        msg += "";
                        break;
                    case '5':
                        msg += "";
                        break;
                    case '6':
                        msg += "";
                        break;
                    case '7':
                        msg += "";
                        break;
                    case '8':
                        msg += "";
                        break;
                    case '9':
                        msg += "";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(msg);
        }
    }
}
