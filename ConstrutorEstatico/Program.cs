using DadosPessoais;

Pessoa p1 = new(nome: "Matheus", idade: 20);
Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine("Idade Mínima : " + Pessoa.IdadeMinima);

Console.Read(); 