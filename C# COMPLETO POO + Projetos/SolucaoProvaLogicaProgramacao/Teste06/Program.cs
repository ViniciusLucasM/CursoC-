Console.WriteLine("Digite a quantidade de números que serão lidos: ");
int qntNum = int.Parse(Console.ReadLine());

int qntIn = 0;
int qntOut = 0;


for (int i = 0; i < qntNum; i++)
{
    Console.WriteLine("Digite um valor inteiro: ");
    int valor = int.Parse(Console.ReadLine());

    if (valor >= 10 && valor <= 20)
    {
        qntIn++;
    }
    else
    {
        qntOut++;
    }
}

Console.WriteLine($"In {qntIn}\nOut {qntOut}");
