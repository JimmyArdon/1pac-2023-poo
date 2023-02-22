using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class MatrizPares
    {
        public MatrizPares()
        {
            int[,] matriz = new int[4, 4];

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    matriz[i, j] = random.Next(1, 100);
                }
            }

            int[,] matrizpar = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        matrizpar[i, j] = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz Pares");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizpar[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
