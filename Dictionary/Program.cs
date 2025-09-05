Dictionary <int, int> dict1 = new Dictionary<int, int>();
//Key = int, Value = int

var dict2 = new Dictionary<int, int>();

dict1.Add(1, 2);
dict2.Add(2, 3);
dict1.Add(3, 4);

var dict3 = new Dictionary<int, int>()
{
    {1, 500},
    {5, 1000},
    {2, 500},
    {3, 1000}
};

try
{
    dict3.Add(3, 33);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Chave já utilizada");
}

var resultado = dict3.TryAdd(3, 300);
Console.WriteLine($"O elemento foi incluído ? {resultado}");

if (!dict3.ContainsKey(3))  //Averigua se a chave 3 está sendo utilizada no Dictionary
{
    dict3.Add(3, 850);
    Console.WriteLine($"Elemento incluido: {dict3[3]}");
}
else
{
    Console.WriteLine("Chave já utilizada");
}

var dic3Ordenado = dict3.OrderBy(x => x.Key); //Ordena o dicionário dict3 a partir das chaves do dicionário
foreach(var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key}.{item.Value}");
}
Console.Read();