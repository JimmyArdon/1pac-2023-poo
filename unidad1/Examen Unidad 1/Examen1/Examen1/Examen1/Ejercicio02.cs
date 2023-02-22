using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Examen1
{
    //Jimmy Albert Ardon Orella
    //20182100004
    /*
     Escribir un programa que solicite al usuario una lista de números enteros y encuentre el número más
     común en la lista.
     */
    internal class Ejercicio02
    {
        public Ejercicio02()
        {
            Console.WriteLine("Ingrese el numero de arreglos: ");
            int numero = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] numeros = new int[numero];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1,50);
                Console.WriteLine("numeros[" + i + "] = " + numeros[i]);

            }
            if (numero == numero)
            {
                Console.WriteLine("El numero mas comun es :" + numero);
            }
        }   
        
    }
}
