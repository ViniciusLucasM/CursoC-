namespace Exercicio03_Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int difProduto = a * b - c * d;
            Console.WriteLine("Diferença = {0}", difProduto);
        }
    }
}
