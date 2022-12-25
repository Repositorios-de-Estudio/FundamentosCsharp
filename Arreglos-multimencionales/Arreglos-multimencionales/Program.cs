using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglos_multimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arreglo con 3 filas y dos columnas
            int[,] matriz = new int[3, 2] { {0,1 }, {2,3}, {4,5} };

            //mostrar matriz

            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int colum = 0; colum < matriz.GetLength(1); colum++)
                {
                    //Console.WriteLine("For anidado [ {0} , {1} ] : {2} ", fila, colum, matriz[fila,colum]);
                    Console.Write(" {0}", matriz[fila,colum]);
                }

                //salto de linea
                Console.WriteLine();
            }

            foreach (var item in matriz)
            {
                Console.WriteLine("Foreach Matriz [ {0} ]", item);
            }


        }
    }
}
