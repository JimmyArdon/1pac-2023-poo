using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo05
    {
       
        public Arreglo05()
        {

            int[,] matriz1 = new int[3,3];
            int[,] matriz2 = new int[3,3];
            int[,] matriz3 = new int[3,3];

            Console.WriteLine("Matriz 1");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i< 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine("Ingrese el numero de la posicion" + "[" + i + "," + j + "]");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz 2");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese el numero de la posicion" + "[" + i + ","+j + "]");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("RESULTADO DE MATRICES");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz3[i, j] + " ");
                }
            }
        }

    }
}
