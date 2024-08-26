int senha = 2002;
bool senhaCerta = false;

while (!senhaCerta)
{
    Console.WriteLine("Digite a sua senha: ");
    string input = Console.ReadLine();

    if (int.Parse(input) == senha)
    {
        senhaCerta = true;
        Console.WriteLine("Acesso Permitido");
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }
}


