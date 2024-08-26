// Teste 01

Console.WriteLine("Digite o valor do codPeca1, numPeca1, uniPeca1, codPeca2, numPeca2, uniPeca2. Dividindo os valores por espaços: ");
string input = Console.ReadLine();

string[] valores = input.Split(' ');

int codPeca1 = int.Parse(valores[0]);
int numPeca1 = int.Parse(valores[1]);
float uniPeca1 = float.Parse(valores[2]);
int codPeca2 = int.Parse(valores[3]);
int numPeca2 = int.Parse(valores[4]);
float uniPeca2 = float.Parse(valores[5]);

float total = numPeca1 * uniPeca1 + numPeca2 * uniPeca2; 

Console.WriteLine($"VALOR A PAGAR: R$ {total}");

