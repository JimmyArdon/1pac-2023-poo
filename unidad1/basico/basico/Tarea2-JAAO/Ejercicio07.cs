using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio07
    {
        public Ejercicio07()
        {
            Console.WriteLine("Un programa que sume los números del 1 al 10 y muestre el resultado en la consola. (for)\r\n");

            int suma = 0;
            for (int i = 1; i < 11; i++)
            {
                suma += i;
                
                Console.WriteLine(suma);
            }
        }
    }
}
