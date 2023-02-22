using basico.estructuras_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglos03
    {
        public Arreglos03()
        {
            int[,] numero = new int[3,3];

            //[{0,0},{0,1},{0,2}]
            //[{1,0},{1,1},{1,2}] Matriz.
            //[{2,0},{2,1},{2,2}]

            //numero[0,0] = 34;
            //numero[0,1] = 12; ejemplo.
            //numero[0,2] = 32;

            for (int f = 0; f < 3; f++)
            {               
                for (int c = 0; c < 3; c++)
                {
                    numero[f,c] = f + c;
                    Console.WriteLine("La posicion " +f+ "," +c+ "es : " +numero[f,c]);
                }
            }
            

        }
    }
}
