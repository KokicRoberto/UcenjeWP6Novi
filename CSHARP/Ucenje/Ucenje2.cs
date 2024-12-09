using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Ucenje2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello");

            int i = 1;
            bool uvjet = i > 0;

            if (uvjet)
            {
                Console.WriteLine("veće od 0");
            }
            if (i > 0)
            {
                Console.WriteLine("veće od 0");
            }
            if (uvjet)
            {
                Console.WriteLine("veće od 0");
            }
            else if (i == -1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("Nije veći od 0");
            }
            if (i > 0)
            {
                int p = -2;
                if (p < 0)
                {
                    Console.WriteLine("Osijek");
                }
            }

            }
        }
    }

