using Programas;

Carro tCroos = new(0);

tCroos.Dirigir();
Console.WriteLine($"Quantidade de Gasolina: {tCroos.ExibirGasolina()}");

LivroFotos livroPadrao = new();
Console.WriteLine($"Quantidade de páginas: {livroPadrao.ExibeNumeroPaginas()}");

LivroFotos livroModificado = new(24);
Console.WriteLine($"Quantidade de páginas: {livroModificado.ExibeNumeroPaginas()}");

SuperLivroFotos livroAumentado = new();
Console.WriteLine($"Quantidade de páginas: {livroAumentado.ExibirNumeroPaginas()}");

Pessoa[] alunoProfessor = new Pessoa[3] { new Professor("Ronaldo"), new Aluno("Matheus"), new Aluno("Lima") };
alunoProfessor[0].Explicar();
alunoProfessor[1].Estudar();
alunoProfessor[2].Estudar();

Pessoas[] listaPessoas = new Pessoas[3]
{
    new Pessoas(),
    new Pessoas(),
    new Pessoas()
};

Pessoas.ExibirNomes(listaPessoas);

Console.Read();
