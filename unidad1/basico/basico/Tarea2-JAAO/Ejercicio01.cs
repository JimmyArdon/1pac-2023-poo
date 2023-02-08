using basico.estructuras_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio01

    {
        public Ejercicio01()
        {
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0 ) {
            Console.WriteLine("El numero " + numero + " es positivo" );

            }
            else if (numero < 0 ) 
            {
                Console.WriteLine("El numero " + numero + " es negativo");
            }
            else 
            {
                Console.WriteLine("El numero es cero");
            }
            
        }
        
    }
}
