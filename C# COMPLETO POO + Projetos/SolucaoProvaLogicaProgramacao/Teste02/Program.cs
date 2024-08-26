using System.Transactions;

Console.WriteLine("Digite o Raio do Circulo: ");

string input = Console.ReadLine();
double raio = double.Parse(input);
double pi = 3.14159;
double expoente = 2.0;
double calcElevado = Math.Pow(raio, expoente);

double total = pi * calcElevado;
Console.WriteLine($"O valor do circulo é: {total:F4}");
