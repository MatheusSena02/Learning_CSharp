using Exercicio;

List<Pessoa> listaPessoas = new List<Pessoa>();
listaPessoas.Add(new Pessoa("Matheus", 22));
listaPessoas.Add(new Pessoa("Pedro", 45));
listaPessoas.Add(new Pessoa("Lucas", 18));
listaPessoas.Add(new Pessoa("Leandro", 30));
listaPessoas.Add(new Pessoa("Lucas", 20));

Action<Pessoa> exibeLista = x => Console.WriteLine($"{x.Nome} - {x.Idade}");
listaPessoas.ForEach(exibeLista);


Predicate<Pessoa> filter = p => p.Idade > 18;
var listaMaioresDeIdade = listaPessoas.FindAll(filter);

foreach(var pessoa in listaMaioresDeIdade)
{
    Console.WriteLine($"\n{pessoa.Nome} - {pessoa.Idade}");
}

Func<Pessoa, int> pessoaMaisVelha = x => x.Idade;   //Retorna a idade de um pessoa
var listaOrdenada = listaPessoas.OrderBy(i =>  i.Idade);    //Ordena a lista por idade
var MaisVelha = listaOrdenada.Last();

Console.WriteLine($"\nPessoa mais velha : {MaisVelha.Nome} - {MaisVelha.Idade}");


Console.Read();
