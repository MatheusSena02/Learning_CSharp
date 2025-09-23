//Exemplo de Query Sintax ou Sintaxe de Consulta

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "João", "Larissa", "Pedro"
};

//var resultado = Pois a consulta LINQ comporta variáveis implícita, evitando imcompatibilidade dos dados
var resultado = from nome in nomes  //Define a fonta de dados = nome -> aliás e nomes -> fonte de dados
                where nome.Contains('a')   //Projeção, o filtro para busca do tipo de dados que contém o caractere 'a'. Usando a sintaxe comum de consulta de banco de dados
                select nome;    //Seleção, os valores que serão armazenados na variável

foreach (var item in resultado)
{
    Console.WriteLine(item);
}

//Exemplo de Method Sintax ou Sintaxe de Método

List<double> notas = new()
{
    8.5, 7.9, 10, 15, 27, 52, 0.25
};

var resultado2 = notas.Where(nota => nota < 10);    //Nesse, essa sintaxe utilizada os MÉTODOS DE EXTENSÃO do IEnumerable

foreach(var item in resultado2)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nOs resultados expressos são do tipo IEnumerable, somente leitura e iterável"); 



Console.Read();