namespace EstruturaCondicional_if_else_ {
    internal class Program {
        static void Main(string[] args) {

            int x = 10;

            Console.WriteLine("Bom Dia");

            if (x > 5) {
                Console.WriteLine("Boa Tarde");
            }

            Console.WriteLine("Boa Noite");

            Console.WriteLine("---------------------");

            Console.WriteLine("\nDigite um número inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0) {
                Console.WriteLine("Esse número é PAR");
            } else {
                Console.WriteLine("Esse número é IMPAR");
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("\nQual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            } else if (hora <= 12 || hora < 18) {
                Console.WriteLine("Boa tarde!");
            } else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
