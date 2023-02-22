using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class MatrizTranspuesta
    {
        public MatrizTranspuesta()
        {
            int[,] matriz = new int [3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Matriz Original");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] matrizTranspuesta = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizTranspuesta[i, j] = matriz[j, i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz Transpuesta");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizTranspuesta[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
