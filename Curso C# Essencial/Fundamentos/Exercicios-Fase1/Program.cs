using System.IO.Pipes;

Console.WriteLine("## EXERCICIO 1 ##");
Console.WriteLine("Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.");
Console.WriteLine();

int idade = 35;
Console.WriteLine($"A idade é: {idade}");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 2 ##");
Console.WriteLine("Crie uma variável chamada nome e atribua o valor \"Maria\" e exiba o seu valor.");
Console.WriteLine();

string nome = "Maria";
Console.WriteLine($"O nome é: {nome}");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 3 ##");
Console.WriteLine("Crie uma variável chamada altura e atribua a ela o valor 3.45.");
Console.WriteLine();

double altura = 3.45;
Console.WriteLine($"A altura é: {altura}");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 4 ##");
Console.WriteLine("Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor");
Console.WriteLine();

DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"A data é: {data}");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 5 ##");
Console.WriteLine("Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;");
Console.WriteLine();

const int ano = 12;
Console.WriteLine($"O ano é: {ano}");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 6 ##");
Console.WriteLine("Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o\r\nvalor 7.80 e exiba o seu valor.");
Console.WriteLine();

double? nota = 7.80;
Console.WriteLine($"A nota é: {nota}");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 7 ##");
Console.WriteLine("Quais as diferenças entre os tipos por valor e os tipos por referência ?");
Console.WriteLine();

Console.WriteLine("A diferença entre os dois é que o tipo por valor armazena diretamente os seus\r\ndados e cada variável tem sua propria cópia dos dados - ARMAZENADOS NA MEMÓRIA STACK ");
Console.WriteLine("Enquanto a tipo de referência, não armazenam os dados diretamente e cada\r\nvariável contém uma referência ao local da memória onde os dados estão armazenados - ARMAZENADOS NA MEMORIA HEAP");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 8 ##");
Console.WriteLine("Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:");
Console.WriteLine();

int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string nome1 = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;

Console.WriteLine(x);
Console.WriteLine(numero);
Console.WriteLine(letra);
Console.WriteLine(temperatura);
Console.WriteLine(ativo);
Console.WriteLine(nome1);
Console.WriteLine(salario);
Console.WriteLine(hoje);
Console.WriteLine();


Console.WriteLine("## EXERCICIO 9 ##");
Console.WriteLine("Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :");
Console.WriteLine();

Console.WriteLine("( V )int n = 1;\r\n( R )string titulo = \"A vida\";\r\n( V )float f = 12.45f;\r\n( V )double d = 5.45;\r\n( V )decimal valor = 10.99m;\r\n( V )char sexo = 'M';\r\n( R )object o = null;");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 10 ##");
Console.WriteLine("O que é um nullable type e qual a sua utilidade ?");
Console.WriteLine();

Console.WriteLine("Os Nullable Types ou Tipos Anuláveis permitem atribuir um valor null a um tipo de valor");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 11 ##");
Console.WriteLine("O que é Camel Case ? Dê um exemplo de sua aplicação.");
Console.WriteLine();

Console.WriteLine("Inicia o começo da variável com letra minúscula e a seguinte palavra tem a primeira letra maiúscula");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 12 ##");
Console.WriteLine("O que é Pascal Case ? Dê um exemplo de sua aplicação.");
Console.WriteLine();

Console.WriteLine("A primeira letra de cada palavra é iniciada com maiúscula");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 13 ##");
Console.WriteLine("Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a\r\nseguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a\r\noperação de soma)");
Console.WriteLine();

int x1 = 77;
int y = 66;

Console.WriteLine($"O valor da soma de X e Y é: {x1 + y}");
Console.WriteLine();

Console.WriteLine("## EXERCICIO 14 ##");
Console.WriteLine("Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e\r\nstring.");
Console.WriteLine();

Console.WriteLine("bool = false;\r\nchar = '\0';\r\nint = 0;\r\ndouble = 0;\r\nfloat = 0;\r\ndecimal = 0;\r\nstring = null;");
Console.WriteLine();


Console.WriteLine("## EXERCICIO 15 ##");
Console.WriteLine("- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis\r\nconsiderando a nomenclatura usada:");
Console.WriteLine();

Console.WriteLine("( F ) double 1valor = 12.45;\r\n( F ) string #nome = \"Pedro\";\r\n( V ) float _temperatura = 12.45f;\r\n( F ) double int = 5;\r\n( F ) decimal renda extra = 91.45m;\r\n( F ) bool status$conta = false;\r\n( V ) string titulo3 = \"Tópico 1\";\r\n( V ) float salario_mensal = 1999.55f;\r\n( V ) int percentualValorDesconto = 5;\r\n( V ) const bool MENSALIDADE_EM_DIA = true;");
Console.WriteLine();


Console.ReadLine();