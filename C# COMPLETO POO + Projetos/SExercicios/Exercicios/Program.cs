using System.Globalization;

namespace exercicio1 {
    class exercicio1 {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:\n{0}, cujo preço é $ {1:F2}\n{2}, cujo preço é $ {3:F2}", produto1, preco1, produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}\nArredondado (Três casas decimais): {1:F3}\nSeparador decimal invariant culture: {2}"
                , medida, medida, medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}