using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Matrizprimos
    {
        public Matrizprimos() {
            int rows = 3; // número de filas de la matriz
            int cols = 3; // número de columnas de la matriz
            int[,] matrix = new int[rows, cols]; // matriz de números aleatorios

            // Generar números aleatorios en la matriz
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101); // generar números aleatorios entre 1 y 100
                }
            }

            // Imprimir matriz original
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Crear matriz de números primos
            int[,] primeMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (EsPrimo(matrix[i, j]))
                    { // si es primo, agregar a la matriz de números primos
                        primeMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            // Imprimir matriz de números primos
            Console.WriteLine("Matriz de números primos:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(primeMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Función para verificar si un número es primo
        bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }

    }
