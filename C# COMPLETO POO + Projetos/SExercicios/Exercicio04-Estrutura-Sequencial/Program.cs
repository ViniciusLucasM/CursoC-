using System.Globalization;

namespace Exercicio04_Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o número do funcionário: ");
            int funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quanto ele recebe por hora: ");
            double horaSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcSalario = horaSalario * horasTrabalhadas;
            Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1}", funcionario, calcSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
