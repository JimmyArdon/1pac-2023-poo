using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Practica
    {
        public Practica()
        {

            Console.WriteLine("Ingrese cuantos numeros quiere generar");
            int size = int.Parse(Console.ReadLine());

            int[] arrayNumeros = new int[size + 1];

            Random random = new Random();
            int suma = 0;
            for (int i = 0; i < arrayNumeros.Length - 1; i++)

            {
                int numerosRandom = random.Next(1, 11);


                bool existeElNumero = arrayNumeros.Contains(numerosRandom);

                while (existeElNumero)
                {
                    numerosRandom = random.Next(1, 11);
                    existeElNumero = arrayNumeros.Contains(numerosRandom);
                }

                arrayNumeros[i] = numerosRandom;

                suma += numerosRandom;
                arrayNumeros[arrayNumeros.Length - 1] = suma;
                Console.WriteLine($"{i + 1}: {arrayNumeros[i]}");

            }
            Console.WriteLine("Suma Total de Array: " + arrayNumeros[arrayNumeros.Length - 1]);
        }
    }
}
