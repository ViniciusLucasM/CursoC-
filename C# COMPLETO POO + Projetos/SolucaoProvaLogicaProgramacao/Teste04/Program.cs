Console.WriteLine("Digite o valor dos coeficientes: ");

string input = Console.ReadLine();
string[] valores = input.Split(' ');

double coA = double.Parse(valores[0]);
double coB = double.Parse(valores[1]);
double coC = double.Parse(valores[2]);

double delta = Math.Pow(coB, 2) - (4 * coA * coC);

if (delta >= 0)
{
    double raiz1 = (-coB + Math.Sqrt(delta)) / (2 * coA);
    double raiz2 = (-coB - Math.Sqrt(delta)) / (2 * coA);

    Console.WriteLine($"As raízes da equação é: x1 = {raiz1:F5} e x2 = {raiz2:F5}");
} else
{
    Console.WriteLine("Impossível Calcular");
}


