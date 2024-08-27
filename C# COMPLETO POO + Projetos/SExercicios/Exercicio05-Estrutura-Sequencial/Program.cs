using System.Globalization;

namespace Exercicio05_Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {
            
            int codPeca1, codPeca2, numPeca1, numPeca2;
            double uniPeca1, uniPeca2;

            Console.WriteLine("Digite os códigos das peças: ");
            codPeca1 = int.Parse(Console.ReadLine());
            codPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças: ");
            numPeca1 = int.Parse(Console.ReadLine());
            numPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário de cada peça: ");
            uniPeca1 = double.Parse(Console.ReadLine().Replace(',','.'), CultureInfo.InvariantCulture);
            uniPeca2 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

            double valorPagar = (uniPeca1 * numPeca1) + (uniPeca2 * numPeca2);

            Console.WriteLine("Valor a pagar: R$ {0}", valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
