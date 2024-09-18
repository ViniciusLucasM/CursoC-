namespace Exercicio03_Estrutura_While {
    internal class Program {
        static void Main(string[] args) {

            int cod = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (cod != 4) {
                if (cod == 1) {
                    alcool = alcool + 1;
                } else if (cod == 2) {
                    gasolina = gasolina + 1;
                } else if (cod == 3) {
                    diesel = diesel + 1;
                }
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
