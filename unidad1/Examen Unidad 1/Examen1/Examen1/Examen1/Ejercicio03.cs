using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Examen1
{
    //Jimmy Albert Ardon Orella
    //20182100004

    /*
     Escribir un programa que genere una matriz cuadrada de tamaño N (ingresado por el usuario), donde
     cada elemento de la matriz sea un número aleatorio entre 1 y 100. Luego, el programa deberá imprimir
     en la consola la suma de cada una de las filas y la suma de cada una de las columnas de la matriz.
     */
    internal class Ejercicio03
    {
        

        public Ejercicio03()
        {
            Console.WriteLine("Ingrese el numero de Filas");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Columnas");
            int col = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila+1,col+1];
            Random random= new Random();
            for (int i = 0; i < fila; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Matriz Original");
            Console.WriteLine("------------------------");
            for (int i = 0; i < fila; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matriz[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
            //Sumando las filas
            int [,] sumafila = new int[fila, (col + 1)];
            for (int i = 0; i < fila; i++)
            {
                int suma = 0;
                for (int j = 0; j < (col+1); j++)
                {
                    sumafila[i, j] = matriz[i, j];
                    suma += matriz[i, j];
                }
                sumafila[i, col] = suma;
            }
            //Sumando las columnas
            int[,] sumacol = new int[fila + 1, col];
            for (int i = 0; i < fila + 1; i++)
            {
                int suma = 0;
                for (int j = 0; j < col; j++)
                {
                    sumacol[i,j] = matriz[i,j];
                    suma += matriz[i,j];

                }
               // sumacol[fila, col] = suma;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz Con Suma de Filas");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < (col + 1); j++)
                {
                    Console.Write(sumafila[i, j] + "\t");
                  
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz Con Suma de columnas");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < fila+1 ; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(sumacol[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }
    }
}
