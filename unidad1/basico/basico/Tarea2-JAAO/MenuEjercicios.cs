using basico.Tarea2_JAAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class MenuEjercicios
    {

        public MenuEjercicios()
        {


            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu de Ejercicio.");
                Console.WriteLine("-----------------------\n");

                Console.WriteLine("a) Ejercicion 1");
                Console.WriteLine("b) Ejercicion 2");
                Console.WriteLine("c) Ejercicion 3");
                Console.WriteLine("d) Ejercicion 4");
                Console.WriteLine("e) Ejercicion 5");
                Console.WriteLine("f) Ejercicion 6");
                Console.WriteLine("g) Ejercicion 7");
                Console.WriteLine("h) Ejercicion 8");
                Console.WriteLine("i) Ejercicion 9");
                Console.WriteLine("j) Ejercicion 10");
                Console.WriteLine("k) Ejercicion 11");
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
                    case 'd':
                        Ejercicio04 ejercicio4 = new Ejercicio04();
                        break;
                    case 'e':
                        Ejercicio05 ejercicio5 = new Ejercicio05();
                        break;
                    case 'f':
                        Ejercicio06 ejercicio6 = new Ejercicio06();
                        break;
                    case 'g':
                        Ejercicio07 ejercicio7 = new Ejercicio07();
                        break;
                    case 'h':
                        Ejercicio08 ejercicio8 = new Ejercicio08();
                        break;
                    case 'i':
                        Ejercicio09 ejercicio9 = new Ejercicio09();
                        break;
                    case 'j':
                        Ejercicio10 ejercicio10 = new Ejercicio10();
                        break;
                    case 'k':
                        Ejercicio11 ejercicio11 = new Ejercicio11();
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada es invalida");
                        break;

                }
                Console.WriteLine("Desea continuar S/N");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "S")
                {
                    continuar = false;
                }
            }
            //Console.ReadKey();
            Console.Clear();
        }

    } 
    
}
