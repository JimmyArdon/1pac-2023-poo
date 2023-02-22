using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio03
    {
        public Ejercicio03()
        {
            Console.WriteLine("Un programa que pregunte al usuario su género " +
                "y muestre un mensaje en la consola si es hombre o mujer. (if)\r\n");

            char genero;
            Console.Write("Ingrese su genero: ");
            genero = Console.ReadLine()[0];

            if ( genero == 'h' || genero == 'H' ) {
                Console.WriteLine("Su genero es Hombre");
            }
            else
            {
                Console.WriteLine("Su genero es Mujer");
            }
        }
    }
}
