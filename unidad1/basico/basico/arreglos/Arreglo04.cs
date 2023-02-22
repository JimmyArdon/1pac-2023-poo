using basico.estructuras_control;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo04
    {
      
        public Arreglo04()
        {

            Console.WriteLine("Cuantos Alumnos desea ingresar: ");
            int F = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas Notas desea ingresar: ");
            int C = int.Parse(Console.ReadLine());

            int[,] nota = new int[F,C];
            

            for (int fila = 0; fila < F; fila++)
            {

                Console.WriteLine("Ingrese el nombre del Alumno " + (fila+1));
                String alumno = Console.ReadLine();

                for (int columna = 0; columna < C; columna++)
                {
                    Console.WriteLine("Ingrese la nota " + (columna+1) );
                   nota[fila,columna] = int.Parse(Console.ReadLine());
                }
            }

            

            for (int fila = 0; fila < F; fila++)
            {
                int suma = 0;
                Console.Write("\n");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Alumno " + (fila+1));
                Console.WriteLine("Nota1\t Nota2\t Nota3");

                for (int columna = 0; columna < C; columna++)
                {
                    suma += nota[fila,columna];


                    Console.Write("  {0}\t", nota[fila, columna]) ;
                    
                }
                int promedio =  suma / C;
                Console.WriteLine("\n");
                Console.WriteLine("El promedio de notas del Alumno " + (fila + 1) + " es: " + promedio);
                
            }

        }
    }
}
