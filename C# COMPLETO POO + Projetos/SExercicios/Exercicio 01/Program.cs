using System.Globalization;

namespace Exercicio_01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o primeiro número: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
