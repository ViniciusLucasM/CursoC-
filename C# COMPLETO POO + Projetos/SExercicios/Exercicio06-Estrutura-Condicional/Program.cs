using System.Globalization;

namespace Exercicio06_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um valor: ");

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0) {
                Console.WriteLine("Fora do intervalo");
            } else if (valor <= 25.0) {
                Console.WriteLine("Intervalo [0, 25]");

            } else if (valor <= 50) {
                Console.WriteLine("Intervalo [25, 50]");

            } else if (valor <= 75) {
                Console.WriteLine("Intervalo [50, 75]");

            } else {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
    }
}
