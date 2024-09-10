namespace EscopoEInicializacao {
    internal class Program {
        static void Main(string[] args) {
            
            //Sendo que aqui a variável "Preço" pertence ao escopo do programa principal
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            /*
            //Nesse caso a variável "Desconto" pertence somente ao escopo do "IF"
            if (preco > 100) {
                double desconto = preco * 0.1;
            }
            */

            if (preco > 100) {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
