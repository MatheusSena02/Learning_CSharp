string[] nomes = { "Ana", "Maria", "Sérgio", "Pedro" };
Console.WriteLine("Array original... ");

foreach(string s in nomes)
{
    Console.WriteLine(s);
}

Array.Reverse(nomes);

Console.WriteLine("Ordem invertida...");


Console.WriteLine();

foreach (string s in nomes)
{
    Console.WriteLine(s);
}

Console.WriteLine();

Console.WriteLine("Ordenado...");
Array.Sort(nomes);

foreach (string s in nomes)
{
    Console.WriteLine(s);
}

Console.WriteLine("Localizando itens no array...");

var indice = Array.BinarySearch(nomes, "Ana");

Console.WriteLine("Ana está nessa posiçao na lista : " + indice);
Console.Read();