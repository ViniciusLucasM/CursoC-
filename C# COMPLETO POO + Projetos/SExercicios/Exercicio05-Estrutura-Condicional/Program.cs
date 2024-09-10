using System.Globalization;

namespace Exercicio05_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o código do Item e a quantidade de Item: ");
            string[] input = Console.ReadLine().Split(' ');

            int codItem = int.Parse(input[0]);
            int qntItem = int.Parse(input[1]);
            double qntPagar;

            if (codItem == 1) {
                qntPagar = 4.00 * qntItem;
            } else if (codItem == 2) {
                qntPagar = 4.50 * qntItem;
            } else if (codItem == 3) {
                qntPagar = 5.00 * qntItem;
            } else if (codItem == 4) {
                qntPagar = 2.00 * qntItem;
            } else {
                qntPagar = 1.50 * qntItem;
            }

            Console.WriteLine("Total: R$ " + qntPagar.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
