using Examen1.Examen1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu de Ejercicio.");
                Console.WriteLine("-----------------------\n");

                Console.WriteLine("a) Ejercicion 1");
                Console.WriteLine("b) Ejercicion 2");
                Console.WriteLine("c) Ejercicion 3");

                Console.WriteLine("\n\n");

                Console.WriteLine("Seleccione el ejercicio que desea visualizar.");
                char opcion = Console.ReadLine()[0];

                switch (opcion)
                {
                    case 'a':
                        Ejercicio01 ejercicio01 = new Ejercicio01();
                        break;
                    case 'b':
                        Ejercicio02 ejercicio2 = new Ejercicio02();
                        break;
                    case 'c':
                        Ejercicio03 ejercicio3 = new Ejercicio03();
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada invalida");
                        break;

                }
                Console.WriteLine("Desea Continuar (S/N) ");
                String respuesta = Console.ReadLine().ToUpper();

                if (respuesta != "S")
                {
                    continuar = false;

                }

                Console.Clear();
            }

        }
        }
    }


    

