using System.Collections.ObjectModel;

var planetas = new List<string>() { "Mercúrio", "Vênus", "Terra", "Marte" };
var listaPlanetas = new ReadOnlyCollection<string>(planetas);

Console.Write("Planetas não gasosos do sistema solar: ");
foreach(var planet in listaPlanetas)
{
    Console.WriteLine(planet);
}
Console.WriteLine($"Número de planetas na coleção: {listaPlanetas.Count}");

Console.WriteLine($"Índice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

Console.WriteLine("\nModificando lista original...");
planetas.Add("Netuno");
planetas.Add("Saturno");
Console.Write("Planetas não gasosos do sistema solar: ");
foreach (var planet in listaPlanetas)
{
    Console.WriteLine(planet);
}
Console.WriteLine($"Número de planetas na coleção: {listaPlanetas.Count}");

string[] planetasAdicionados = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasAdicionados, 2);
foreach(var i in planetasAdicionados)
{
    Console.WriteLine("Elemento : " + i);
}
Console.Write("Elemento adicionados: ");
