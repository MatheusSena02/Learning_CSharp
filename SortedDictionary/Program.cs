var brics = new SortedDictionary<int, string>()
{
    {20, "Rússia" },
    {10, "Brasil" },
    {30, "China" }
};

//Melhor método de adição de elemento
if (brics.ContainsKey(1))    //Verifica-se se determinada chave já está em uso
{
    Console.WriteLine("Chave já em uso");
}
else
{
    brics.Add(1, "África do Sul");
}


Console.WriteLine($"Número de pares de chaves (elementos): {brics.Count}");

foreach (var b in brics)
{
    Console.WriteLine(b);
}

//Método de busca de valores na lista
if(brics.TryGetValue(30, out string? valor)) //Se a chave 30 estiver sendo usada, retorna o valor por referência e exibe o valor
{
    Console.WriteLine($"Valor da chave 30: {valor}");
}
else
{
    Console.WriteLine("Chave não existe");
}

    Console.Read();