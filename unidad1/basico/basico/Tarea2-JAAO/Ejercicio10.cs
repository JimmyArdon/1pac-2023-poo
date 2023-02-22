using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio10
    {
        public Ejercicio10()
        {
            Console.WriteLine("Un programa que sume los números pares del 1 al 100 " +
                "y muestre el resultado en la consola. (while)\r\n");

            int suma = 0;
            int i = 1;

            Console.WriteLine("Suma de numeros pares de 1 al 100");
            Console.WriteLine("-------------------------------------\n");

            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                i++;
            }

            Console.WriteLine("La suma de los números pares del 1 al 100 es: {0}", suma);
            
        }
    }
}
