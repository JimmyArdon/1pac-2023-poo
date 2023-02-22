using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros05
    {
        public ListarNumeros05()
        {

            //Random  random = new Random();
            //for (int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 100));
            //}

            
            HashSet<int> numeros = new HashSet<int>();
            Random random = new Random();

            while (numeros.Count < 10)
            {
                int numrand = random.Next(1, 15);
                if (!numeros.Contains(numrand))
                {
                    numeros.Add(numrand);
                    Console.WriteLine(numrand);
                }
            }

        }
    }
}
