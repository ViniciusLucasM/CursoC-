namespace Exercicio02_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
