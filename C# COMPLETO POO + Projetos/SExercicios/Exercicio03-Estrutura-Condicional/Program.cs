namespace Exercicio03_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite dois valores inteiros: ");
            string[] input = Console.ReadLine().Split(' ');

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("SÃO MULTIPLOS");
            } else {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}
