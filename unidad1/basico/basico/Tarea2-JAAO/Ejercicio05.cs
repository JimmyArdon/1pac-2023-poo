using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio05
    {
        public Ejercicio05()
        {

            Console.WriteLine("Menu de Comida");
            Console.WriteLine("------------------------\n");

            Console.WriteLine(" a) Hamburguesa");
            Console.WriteLine(" b) Ensalada");
            Console.WriteLine(" c) Pizza");

            Console.WriteLine("Ingrese la comida que desea comprar.");
            char opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case'a':
                    Console.WriteLine("El precio de la Hamburgesa es de Lps. 150");
                    break;
                case 'b':
                    Console.WriteLine("El precio de la Ensalada es de Lps. 120");
                    break;
                case 'c':
                    Console.WriteLine("El precio de la Pizza es de Lps. 129");
                    break;
                default: Console.WriteLine("La opcion ingresada es invalida");
                    break;
            }
        }
    }
}
