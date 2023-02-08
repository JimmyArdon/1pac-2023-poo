using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Listarnumeros01
    {
        public Listarnumeros01()
        {
            /*Ciclo While
             * 
             * while(cond){...}
             */

            Console.WriteLine("Listar numero hasta");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;

            while (i < limite) ;
            {
                Console.WriteLine("i");
                i++;
            }

        }
    }
    
}
