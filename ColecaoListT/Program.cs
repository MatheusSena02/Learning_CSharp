List<string> listaConvidados = new();

do
{
    Console.Write("Deseja adicionar um convidado (S / N) ? ");
    char resposta = Convert.ToChar(Console.ReadLine());
    if(resposta == 'S' || resposta == 's')
    {
        Console.Write("\nDigite o nome:  ");
        string convidado = Console.ReadLine();
        listaConvidados.Add(convidado);
    }
    else
    {
        break;
    }
}while(true);

Console.Write("Lista de convidados atual: ");
foreach(string n in listaConvidados)
{
    Console.Write($"{n}, ");
}

do
{
    Console.Write("\nDeseja remover um convidado (S / N) ? ");
    char resposta = Convert.ToChar(Console.ReadLine());
    if (resposta == 'S' || resposta == 's')
    {
        Console.Write("\nDigite o nome:  ");
        string convidado = Console.ReadLine();
        listaConvidados.Remove(convidado);
    }
    else
    {
        break;
    }
} while (true);

Console.Write("Lista de convidados atual: ");
foreach (string n in listaConvidados)
{
    Console.Write($"{n}, ");
}

do
{
    Console.Write("\nDeseja adicionar um convidado vip (S / N) ? ");
    char resposta = Convert.ToChar(Console.ReadLine());
    if (resposta == 'S' || resposta == 's')
    {
        Console.Write("\nDigite o nome:  ");
        string convidado = Console.ReadLine();
        listaConvidados.Insert(0, convidado);
    }
    else
    {
        break;
    }
} while (true);

Console.Write("Lista de convidados atual: ");
foreach (string n in listaConvidados)
{
    Console.Write($"{n}, ");
}

Console.Read();

