using basico.estructuras_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio02
    {
        public Ejercicio02()
        {
            int num1, num2;
            Console.WriteLine("Ingrese el primer numero: ");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
        }
    }
}
