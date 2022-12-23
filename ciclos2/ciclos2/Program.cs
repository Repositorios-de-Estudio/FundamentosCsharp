using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciclos2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ciclos 2
             * Break: rompe ejecucion
             * Continue: salta las linea a continuacion y continua a la siguiente iteracion
             */

            // uso de Break
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("for {0}", i);

                if (i == 5)
                {
                    Console.WriteLine("for {0} BREAK", i);
                    break;
                }
            }


            // uso de Continue
            int a = 0;
            while (a < 10)
            {

                // si es impar lo salta 
                if (a%2!=0)
                {
                    a++;
                    continue;
                }


                Console.WriteLine("While PAR {0}", a);
                a++;
            }



        }
    }
}
