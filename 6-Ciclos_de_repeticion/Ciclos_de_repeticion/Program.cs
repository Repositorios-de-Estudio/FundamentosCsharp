using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciclos_de_repeticion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ciclos
             *  While, do - while
             *  For, Foreach
             */
             

            // for
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("\n For: {0}", i);
            }

            // while
            int b = 0;
            while (b < 5)
            {
                Console.WriteLine("\n While: {0}", b);
                b++;
            }


            // do-while
            int c = 5;
            do
            {
                Console.WriteLine("\n Do-While: {0}", c);
                c--;
            } while (c > 0);
        }
    }
}
