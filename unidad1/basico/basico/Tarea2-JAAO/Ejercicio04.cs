using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio04
    {
        public Ejercicio04()
        {
            Console.WriteLine("Dias segun su numero.");
            Console.WriteLine("------------------------\n");

            
            Console.WriteLine("Ingrese un numero: ");
            char dia = Console.ReadLine()[0];

            switch (dia)
            {
                case '1':
                    Console.WriteLine("Domingo");
                    break;
                case '2':
                    Console.WriteLine("Lunes");
                    break;
                case '3':
                    Console.WriteLine("Martes");
                    break;
                case '4':
                    Console.WriteLine("Miercoles");
                    break;
                case '5':
                    Console.WriteLine("Jueves");
                    break;
                case '6':
                    Console.WriteLine("Viernes");
                    break;
                case '7':
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no es valido");
                    break;
            }
        }
    }
}
