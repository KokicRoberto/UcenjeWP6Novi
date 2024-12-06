using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E06");
            int[] tem = new int[12];

            tem[0] = 2;
            tem[11] = 4;
            Console.WriteLine(tem);
            Console.WriteLine(string.Join(",",tem));

            int[,] tablica =
            {
               {1,2,3 },
               {4,5,6 },
               {7,8,9 }
            };

            Console.WriteLine(tablica[1,2]);

            int[,,] kocka = { };

            int[,,,] tesaarect = { };

            int[,,,,,,] multiverse = { };

             

        }
    }
}
