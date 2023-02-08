using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Vocales
    {
        public Vocales()
        {
            Console.WriteLine("Nombres segun la vocal");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Ingrese una vocal: ");
            char vocal = Console.ReadLine()[0];
            switch (vocal)
            {
                case 'a':
                    Console.WriteLine("Angel, Abel, Ana, Andrea, Antonia");
                    break;
                case 'e':
                    Console.WriteLine("Erick, Esteban, Edgardo, Erika, Esmeralda");
                    break;
                case 'i':
                    Console.WriteLine("Isis, Isabel, Isidoro, Ivan, Iris");
                    break;
                case 'o':
                    Console.WriteLine("Oscar, Osiris, Obeniel, Orlando, Omar");
                    break;
                case 'u':
                    Console.WriteLine("Uriel, Ursula, Ulises, Ubaldo, Uriana");
                    break;
                default:
                    Console.WriteLine("La vocal ingresada no es valida");
                    break;
            }
        }
    }
}
