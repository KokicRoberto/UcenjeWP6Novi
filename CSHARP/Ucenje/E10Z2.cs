using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World");
            int broj = 17;
            bool prim = true;
            for(int i = 2; i < broj; i++)
            {
                if (i % i == 0)
                {
                    prim = false;
                    //break;
                }
            }
            Console.WriteLine(prim ? "da": "ne");
        }
    }
}
