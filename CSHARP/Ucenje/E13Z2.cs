using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {
        public static void Izvedi()
        {
            zad2();
        }


        private static void zad1()
        {
            Console.WriteLine("Dobrodošli u 1. zadatak");
            string ime;
            while (true)
            {
            ime = E12Metode.UcitajString("Unesi ime osobe (-1 za kraj): ");
                if(ime.ToUpper() == "NE")
                {
                    Console.WriteLine("Hvala na korištenju programa 1. zadatak");
                    break;
                }
            Console.WriteLine(ime.Length);
            }
            
        }

              private static void zad2()
        {
            string ime = E12Metode.UcitajString("Unesi ime: ");
            string prezime = E12Metode.UcitajString("Unesi prezime: ");
                Console.WriteLine("{0} {1}", prezime, ime);
        }   


    }
}
