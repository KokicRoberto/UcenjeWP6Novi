

namespace Ucenje
{
    internal class Zadatak
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World");

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
            else
            {
                Console.WriteLine("NIJE veće od 0");
            }

            if (uvjet)
            {
                Console.WriteLine("Veće od 0");
            }
            else if (i == -1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("Nije veće od 0");
            }


            if (i > 0)
            {
                int p = -2;
                if (p < 0)
                {
                    Console.WriteLine("Osijek");
                }
            }

            if (i > 0)
            {
                Console.WriteLine("veće od 0");
            }
            else
            {
                Console.WriteLine("NIJE veće od 0");
            }

            Console.WriteLine(i > 0 ? "veće od 0" : "NIJE veće od 0");

            int x = 1, y = 0;

            if (x != 1 & y > 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x != 1 && y > 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x == 1 | y == 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x == 1 || y == 0)
            {
                Console.WriteLine("Osijek");
            }


            












        }
    }
}

