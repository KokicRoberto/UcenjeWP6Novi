using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class DomacaZadaca
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Broj redova: 7 ");
            int brojred1 = 7;
            Console.WriteLine("Broj stupaca: 7");
            int brojstup1 = 7;
            int[,] cTablica1 = new int[brojred1, brojstup1];

            {
                for (int i = 1; i < brojred1; i++)
                    for (int j = 0; j < brojstup1; j++)
                    {
                        cTablica1[i, j] = i * brojred1 + j;
                    }
            }

           
           
        }
    }
}