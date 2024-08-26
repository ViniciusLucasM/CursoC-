Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

//As strings são IMUTÁVEIS
string valor = "Isso é uma string";
valor = "Isso é uma string alterada";
valor = "teste";

//Esse tipo de variável funciona como um coringa. Podendo armazenar todos os tipos de dados
//Esse tipo é util quando não se tem a informação do tipo de variável
object onota = 10; //int
object ovalor1 = 8.55m; //decimal
object onome1 = "Maria"; //string
object oativa = true; //bool
object oletra = 'A'; //char

Console.WriteLine(onota);
Console.WriteLine(ovalor1);
Console.WriteLine(onome1);
Console.WriteLine(oativa);
Console.WriteLine(oletra);

//Nesse caso é util quando precisa usar métodos avançados como Reflection
dynamic dnota = 10; //int
dynamic dvalor1 = 8.55m; //decimal
dynamic dnome1 = "Maria"; //string
dynamic dativa = true; //bool
dynamic dletra = 'A'; //char

Console.WriteLine(dnota);
Console.WriteLine(dvalor1);
Console.WriteLine(dnome1);
Console.WriteLine(dativa);
Console.WriteLine(dletra);

Console.ReadLine();
