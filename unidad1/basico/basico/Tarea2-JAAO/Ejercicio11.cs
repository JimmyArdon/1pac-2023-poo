using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio11
    {
        public Ejercicio11()
        {
            Console.WriteLine("Un programa que muestre la tabla de multiplicar " +
                "del número dado por el usuario hasta el 10. (while)");

            Console.WriteLine("Tabla de Multiplicar.");
            Console.WriteLine("--------------------------\n");
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                i++;
            }
        }
    }
}
