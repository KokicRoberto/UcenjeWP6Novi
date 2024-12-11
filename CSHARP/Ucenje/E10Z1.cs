using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World");

            Console.WriteLine("Unesi Izraz: ");
            string izraz = Console.ReadLine();
            Console.WriteLine(izraz);
            if (izraz.Length % 2 == 0)
            {
                Console.WriteLine("parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    for (int j = izraz.Length - 1; i > izraz.Length / 2; j--)
                    {
                        if (izraz[i] != izraz[izraz.Length - 1 - i])
                        {
                            palindrom = false;
                            break;
                        }
                    }
                    Console.WriteLine(palindrom ? "da" : "ne");

                }else
                {
                    Console.WriteLine("neparno");

                }
                


            }

        }
    }
}
