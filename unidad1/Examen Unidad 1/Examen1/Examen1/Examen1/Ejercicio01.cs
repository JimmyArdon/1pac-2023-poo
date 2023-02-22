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
     Dada una matriz de números enteros, encontrar el número menor y el número mayor
     */
    internal class Ejercicio01
    {
        public Ejercicio01()
        {


            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese el [" + i+ ","+ j +"]" + " numero");
                    int numero  = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }

           
        }
    }
}
