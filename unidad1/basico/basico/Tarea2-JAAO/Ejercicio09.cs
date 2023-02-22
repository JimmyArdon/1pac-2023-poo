using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.Tarea2_JAAO
{
    internal class Ejercicio09
    {
        public Ejercicio09()
        {
            Console.WriteLine("Un programa que pregunte al usuario si quiere continuar " +
                "y muestre un mensaje en la consola hasta que responda \"no\". (while)");

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Listar numero hasta");
                int limite = int.Parse(Console.ReadLine());
                int i = 1;

                while (i <= limite) 
                {
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Desea continuar S/N");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S")
                {
                    continuar = false;

                    
                }
            }
        }
    }
}
