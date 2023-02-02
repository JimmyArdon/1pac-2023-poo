using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Promedio
    {
        public Promedio() {

            /*
             * menos de 70 punto => reprobado
             * mas de 70 punto => aprobado
             * mas de 80 punto => bueno
             * mas de 90 punto => sobresaliente
             */
            int prom;

            Console.WriteLine("Ingrese nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("CALCULO DE PROMEDIO");
            Console.WriteLine("-------------------------");

            prom = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Su promedio es: " + prom);

            if (prom < 70) {

                Console.WriteLine("Reprobado.");
            
            }
            if (prom >= 70 )
            {
                Console.WriteLine("Aprobado.");
            }
            if (prom >= 80)
            {
                Console.WriteLine("Bueno.");

            }
            if (prom >=90)
            {
                Console.WriteLine("Sobresaliente.");
            }

        }
    }
}
