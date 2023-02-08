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
