﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            //Console.WriteLine(3);

            Console.WriteLine("Unesi cijeli broj: ");

            int broj1 = int.Parse(Console.ReadLine());

            int broj2 = int.Parse(Console.ReadLine());

            int broj3 = int.Parse(Console.ReadLine());

            if (broj1 < broj2 && broj1 < broj3)
            {
                Console.WriteLine(broj1);
            }
            else if (broj2 < broj1 && broj1 < broj3)
            {
                Console.WriteLine(broj2);
            }
            else
            {
                Console.WriteLine(broj3);
            }


        }     
    }
}
