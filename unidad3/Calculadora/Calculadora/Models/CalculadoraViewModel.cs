namespace Calculadora.Models
{
    public class CalculadoraViewModel
    {
        public string Expresion { get; set; }
        public string NotacionPolaca { get; set; }
        public int? Resultado { get; set; }
        public string Error { get; set; }
    }
}
