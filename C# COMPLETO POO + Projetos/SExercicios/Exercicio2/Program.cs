using System.Globalization;

namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine().Replace(',','.'), CultureInfo.InvariantCulture);

            Console.WriteLine("\nO seu nome completo é: " + nome);
            Console.WriteLine("Sua casa tem {0} quartos", quartos);
            Console.WriteLine("O preço do produto é R$ {0:F2} reais\n", preco);


            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2].Replace(',','.'), CultureInfo.InvariantCulture);


            Console.WriteLine("\nO seu último nome é {0}, sua idade é {1} e sua altura é {2}", nome2, idade, altura);
        }
    }
}
