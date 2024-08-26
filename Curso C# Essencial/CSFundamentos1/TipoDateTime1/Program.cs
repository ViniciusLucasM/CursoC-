Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//Criar data especifica usa o formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2024, 08, 02);
Console.WriteLine(dataHoje);

//Definir as horas
DateTime dataHoraHoje = new DateTime(2024, 08, 02, 21,10,30);
Console.WriteLine(dataHoraHoje);


Console.ReadKey();
