using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo02
    {
        public Arreglo02()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el numero de arreglos: ");
                int numero = int.Parse(Console.ReadLine());

                Random random = new Random();
                int[] numeros = new int[numero];

                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros[" + i + "] = " + numeros[i]);

                }
                Console.WriteLine("Desea Continuar (S/N) ");
                String  respuesta = Console.ReadLine().ToUpper();

                if (respuesta != "S")
                { 
                  continuar= false;
                    
                }
               
                Console.Clear();
            }
        }
    }
}
