using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z1
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dobrodosli vjezbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na korištenju, doviđenja");
        }
        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. Parnost broja");
            Console.WriteLine("2. Tablica množenja");
            Console.WriteLine("3. Jedinica vrjednosti");
            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ", 0, 3))
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
                case 3:
                    JedinicnaVrijednost();
                    Izbornik();
                    break;
            }
        }

        private static void JedinicnaVrijednost()
        {
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj između 20 i 50: ", 20, 50);
            {
                Console.WriteLine(broj % 10);
            }
        }

        private static void TablicaMnozenja()
        {
            NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
            int redak = E12Metode.UcitajCijeliBroj("Unesi broj redaka: ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);
            for (int i = 1; i <= redak; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}", i + j);
                }
                Console.WriteLine();
            }


        }

        private static void ParnostBroja()
        {

            NaslovPrograma("Program koji provjerava da li je uneseni broj paran ili ne");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            if (broj % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je PARAN", broj);
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je NEPARAN", broj);
            }

        }
        private static void NaslovPrograma(string naslov)
        {
            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }
        private static void NaglasiNaslov(int komada)
        {
            return;
            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
 