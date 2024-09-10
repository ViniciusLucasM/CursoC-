using System.Globalization;

namespace Exercicio07_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite dois valores com uma casa decimal (x e y): ");
            string[] input = Console.ReadLine().Split(' ');

            double x = double.Parse(input[0], CultureInfo.InvariantCulture);
            double y = double.Parse(input[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) {
                Console.WriteLine("ORIGEM");
            } else if (x == 0.0) {
                Console.WriteLine("Eixo X");
            } else if (y == 0.0) {
                Console.WriteLine("Eixo Y");
            } else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }
        }
    }
}
