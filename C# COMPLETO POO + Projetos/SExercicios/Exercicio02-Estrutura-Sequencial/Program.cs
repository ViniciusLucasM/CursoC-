using System.Globalization;

namespace Exercicio02_Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            double raio = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2));

            Console.WriteLine("A = {0:F4}", area);
        }
    }
}
