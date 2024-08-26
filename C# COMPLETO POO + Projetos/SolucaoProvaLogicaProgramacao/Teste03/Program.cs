Console.WriteLine("Digite o código do item e a sua quantidade: ");

string input = Console.ReadLine();

string[] valores = input.Split(' ');

int codItem = int.Parse(valores[0]);
int quantItem = int.Parse(valores[1]);


if (codItem == 1)
{
    double valorTotal1 = 4.00 * quantItem;
    Console.WriteLine($"O valor da sua compra ficou em: R$ {valorTotal1}");
} else if (codItem == 2)
{
    double valorTotal2 = 4.50 * quantItem;
    Console.WriteLine($"O valor da sua compra ficou em: R$ {valorTotal2}");
} else if(codItem == 3)
{
    double valorTotal3 = 5.00 * quantItem;
    Console.WriteLine($"O valor da sua compra ficou em: R$ {valorTotal3}");
} else if (codItem == 4)
{
    double valorTotal4 = 2.00 * quantItem;
    Console.WriteLine($"O valor da sua compra ficou em: R$ {valorTotal4}");
} else if (codItem == 5)
{
    double valorTotal5 = 1.50 * quantItem;
    Console.WriteLine($"O valor da sua compra ficou em: R$ {valorTotal5}");
}

