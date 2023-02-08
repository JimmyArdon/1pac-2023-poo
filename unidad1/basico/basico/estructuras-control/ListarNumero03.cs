using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumero03
    {
      public ListarNumero03()
        {
            Console.WriteLine("Listar numero hasta");
           int limite = int.Parse(Console.ReadLine());
           int i = 1;
            do
            {
               
                Console.WriteLine(i);
                    i++;
                
            } while (i <= limite);
        }
    }
}
