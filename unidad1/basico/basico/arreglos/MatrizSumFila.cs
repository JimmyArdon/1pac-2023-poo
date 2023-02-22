using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class MatrizSumFila
    {
        public MatrizSumFila()
        {
            int[,] matriz = new int[3, 4] { { 1, 2, 3 ,10}, { 4, 5, 6,11 }, { 7, 8, 9,12 } };

            Console.WriteLine("Matriz Original");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] matrizSum = new int[3,4 + 1];
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;
                for (int j = 0; j < 4; j++)
                {
                    matrizSum[i, j] = matriz[i, j];
                    suma += matriz[i, j];
                }
                matrizSum[i, 4] = suma;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz Con Suma de Filas");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4 +1 ; j++)
                {
                    Console.Write(matrizSum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
