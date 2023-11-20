using Microsoft.AspNetCore.Mvc;
using System.Text;
namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(string expresion)
        {
            try
            {
                if (string.IsNullOrEmpty(expresion))
                    throw new ArgumentException("La expresión no puede estar vacía.");

                bool esNotacionPolaca = ValidarNotacionPolaca(expresion);
                if (!esNotacionPolaca)
                    throw new ArgumentException("La expresión ingresada no está en notación polaca inversa.");

                int resultado = EvaluarNotacionPolaca(expresion);

                ViewBag.NotacionPolaca = expresion;
                ViewBag.Resultado = resultado;
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View("Index");
        }

        public bool ValidarNotacionPolaca(string expresion)
        {
            
            string[] elementos = expresion.Split(' ');

            
            int contadorOperandos = 0;
            int contadorOperadores = 0;

            foreach (string elemento in elementos)
            {
                if (EsOperando(elemento))
                {
                    contadorOperandos++;
                }
                else if (EsOperador(elemento))
                {
                    contadorOperadores++;
                }
                else
                {
                    
                    return false;
                }
            }

           
            return contadorOperandos == contadorOperadores + 1;
        }

        public bool EsOperando(string elemento)
        {
            int numero;
            return int.TryParse(elemento, out numero);
        }

        public bool EsOperador(string elemento)
        {
            return elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/";
        }

        public int EvaluarNotacionPolaca(string notacionPolaca)
        {
            Stack<int> pila = new Stack<int>();
            string[] elementos = notacionPolaca.Split(' ');

            foreach (string elemento in elementos)
            {
                if (int.TryParse(elemento, out int numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    int operando2 = pila.Pop();
                    int operando1 = pila.Pop();

                    int resultado;
                    switch (elemento)
                    {
                        case "+":
                            resultado = operando1 + operando2;
                            break;
                        case "-":
                            resultado = operando1 - operando2;
                            break;
                        case "*":
                            resultado = operando1 * operando2;
                            break;
                        case "/":
                            resultado = operando1 / operando2;
                            break;
                        default:
                            throw new ArgumentException("Operador inválido: " + elemento);
                    }

                    pila.Push(resultado);
                }
            }

            return pila.Pop();
        }
    }
}
