﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E07");

            // 10 puta jedno ispod drugog ispišite Osijek
            // ovo je rješenje ali nije dobra praksa
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            // unaprijed
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Osijek iz petlje", i);
            }

            //unazad
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);
            }

            //ugnježđena petlja
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0,1}", i * j);
                }
                Console.WriteLine();
            }

            // DZ lipo formatirati brojeve prema desno


            // koliko je zbroj prvih 100 brojeva?
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i; //postojećoj sumi dodajem vrijednost i
            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine((x + 1) * x / 2);


            // Ispiši sve parne brojeve od 1 do 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    if (i < 20)
                    {
                        //Console.WriteLine(i);
                        Console.Write("{0},", i);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // DZ: Maknuti zadnji zarez

            Console.WriteLine();
            int idiOd = 12; //ovo može unijeti korisnik
            int idiDo = 34;

            // ovako u konačnici mora izgledati kod: bez fiksnih vrijednosti
            for (int i = idiOd; i <= idiDo; i++)
            {
                Console.WriteLine(i);
            }


            int[] brojevi = { 1, 2, 3, 3, 2, 3, 3, 3, 4, 3, 3 };

            //ispisati sve brojeve iz niza
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }


            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            for (int i = 0; i < tablica.GetLength(0); i++) // X dimenzija GetLength(0)
            {
                for (int j = 0; j < tablica.GetLength(1); j++) // Y dimenzija GetLength(1)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine(i);
            }

            for(int i = 0; i < 10; i++)
            {
                if ( i== 3)
                {
                    continue;
                }

                if ( i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //DZ: saznati kako prekinuti ugnježđenu petlju (iz najduble vanjksu)

            // kako postići beskonačnu petlju

            for(int i = 0; i >= 0; i++)
            {
                Console.WriteLine(i);
                break;
            }

            for (; ; )
            {
                Console.WriteLine(new Random().NextInt64() + "" + new Random().NextInt64() + "" + new Random().NextInt64());
                break; //ovo maknuti ako hoćemo beskonačni prikaz brojeva



            }    

        }

    }
}












