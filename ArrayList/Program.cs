using System.Collections;

string[] nomesFamiliares = { "Ana", "Carlos", "Maria", "João" };

var listaFamiliares = new ArrayList()
{
    "Joana", "Teresa", "Marcos",
};

Console.Write("\nLista default: ");
foreach (var familiar in listaFamiliares)
{

    Console.Write($"|{familiar}|");
}

Console.WriteLine();

listaFamiliares.AddRange(nomesFamiliares);

Console.WriteLine("\nLista com nomes adicionados: ");
foreach (var membro in listaFamiliares)
{
    Console.Write($"|{membro}|");
}

Console.WriteLine("\n");

Console.WriteLine("Lista removendo membros:");
listaFamiliares.RemoveRange(0, 2);
foreach (var membro in listaFamiliares)
{
    Console.Write($"|{membro}|");
}

Console.WriteLine("\n");

Console.Write("Maria foi removida da lista ?  ");
if (listaFamiliares.Contains("Maria"))
{
    Console.WriteLine("Não");
}
else
{
       Console.WriteLine("Sim");
}
Console.WriteLine(listaFamiliares.Contains("Maria"));
Console.Read();