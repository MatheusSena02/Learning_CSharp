using ConsultasLINQ;
//Principais formas de consultas LINQ

//Filtrando Dados

var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos Eletrônicos: ");
var produtosEletronicos = listaProdutos.Where(p => p.Categoria == "Eletrônico").OrderBy(n => n.Nome);  //Filtra os produtos por categoria e os ordena a partir do nome
foreach (var p in produtosEletronicos)
{
    Console.WriteLine($"- {p.Nome} : RS {p.Preco}");
}

Console.WriteLine("\nListagem dos produtos ordenados: ");

var nomesDosProdutos = listaProdutos.Select(p => p.Nome).OrderBy(n => n); //O Select retorna uma IOrderedIEnumerable do tipo string
foreach (var p in nomesDosProdutos)
{
    Console.WriteLine(p);
}

//Select : Projeta cada elemento de uma sequência em um novo formulário. Permite que você crie tipos anônimos
var produtosAumentados = listaProdutos.Where(p => p.Preco < 50).OrderBy(n => n.Nome)
                                                                           .Select(a => new
                                                                           {
                                                                               NomeProdutoAumentado = a.Nome.ToUpper(),
                                                                               PrecoAumentado = a.Preco * 1.1
                                                                           });
foreach(var produto in produtosAumentados)
{
    Console.WriteLine($"\n{produto.NomeProdutoAumentado} \t Preço com aumento: {produto.PrecoAumentado:C}");
}
Console.Read();

