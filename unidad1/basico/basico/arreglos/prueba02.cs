using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class prueba02
    {
        public prueba02()
        {
            int[,] matrizA = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrizB = new int[3,3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] matrizSuma = new int[3,3];
            int[,] matrizResta = new int[3,3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    matrizSuma[i,j] = matrizA[i,j] + matrizB[i,j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizResta[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            Console.WriteLine("Resultado Suma");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizSuma[i, j] + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Resultado Resta");
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizResta[i, j] + " ");
                }
            }

        }
    }
}
