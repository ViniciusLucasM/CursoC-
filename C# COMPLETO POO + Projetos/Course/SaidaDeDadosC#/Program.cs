using System.Globalization;

namespace SaidaDeDados {
    class SaidaDeDados {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // Saida de dados com Write e WriteLine
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-------------------------");

            // Saida de dados formatando os números depos do . ou , (Deixando a divisão com o ponto como padrão)
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------");

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais", nome, idade, saldo);
            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F2} reais");
            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");




        }
    }
}
