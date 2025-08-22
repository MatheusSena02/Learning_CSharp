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

Console.WriteLine("Localizando itens no array (Binary Search)...");

var indice = Array.BinarySearch(nomes, "Sérgio");
//Array desejado e o item que deseja procurar no array 

Console.WriteLine("Sérgio está nessa posiçao na lista : " + indice);
Console.Read();