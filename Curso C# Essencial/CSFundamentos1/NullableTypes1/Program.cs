Console.WriteLine("## Nullable Types ##\n");

//Existe duas formas para utilizar o Nullable, sendo a primeira e a segunda opção
/*
Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;*/

int? i = null;
double? d = null;
bool? b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);


int? a = null;
int c = a ?? 0;

int? j = 1;
int k = j ?? 0;

Console.WriteLine(c);
Console.WriteLine(k);


//Dessa forma o código vai dar um erro, pois não é possível realizar a operação com o Nullable Type da seguinte forma
/*
int? x = 4;
int y = 5;
int z = x * y;*/

//Para ajustar o erro acima você deve seguir o código dessa forma para não ter nenhum erro
int? x = 4;
int? y = 5;
int? z = x * y;

Console.WriteLine(z);


int? s = 100;
if (s.HasValue)
{
    Console.WriteLine($"b = {s.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}




Console.ReadKey();
