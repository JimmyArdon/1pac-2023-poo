using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio08
    {
        public Ejercicio08()
        {
            Console.WriteLine("Un programa que calcule el factorial de un número dado por el usuario. (for)\r\n");
            int num;
            int factorial = 1;
            Console.WriteLine("Ingrese el numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
                
                
            }
            Console.WriteLine("El factorial del " + num + " es " + factorial);
        }
    }
}
