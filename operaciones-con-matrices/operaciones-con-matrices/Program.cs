using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operaciones_con_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 filas x 2 columnas
            double[,] mA = { {1.1,0.3 },{5.5,8 } };
            double[,] mB = { {6,-2.1 },{0,10.5 } };

            // 4 filas x 3 columnas
            double[,] mC = { {6, -2.1, 11.11 }, { 0.0, 10.5, 11.12}, { 0.3, 0.4, 11.13}, { 0.4, 0.5, 11.14} };


            MostrarMatriz(mA);

            MostrarMatriz(mB);

            MostrarMatriz(mC);

            MostrarMatriz(sumarMatricesCuadradas(mA, mB));

        }


        private static double[,] sumarMatricesCuadradas(double[,] m1, double[,] m2)
        {

            double[,] sumaM = new double[2, 2];

            for (int i = 0; i < m1.GetLength(0); i++)
            {

                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    sumaM[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return sumaM;
        }

        private static void MostrarMatriz(double[,] matriz)
        {
            // filas
            int n = matriz.GetLength(0);
            // columnas
            int m = matriz.GetLength(1);

            Console.WriteLine(nameof(matriz));
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0:00.#0} ", matriz[i,j]);
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
