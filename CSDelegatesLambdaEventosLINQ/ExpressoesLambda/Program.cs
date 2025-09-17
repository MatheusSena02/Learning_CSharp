List<string> listaConvidados = new() { "Matheus", "Raíza", "Lucas", "Lima", "Gabriel", "Anderosn" };

var resultado = listaConvidados.Find(nome => nome.Equals("Lucas"));

Console.WriteLine(resultado);

Console.Read();