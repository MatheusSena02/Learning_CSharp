using ExemploPraticoIII;

List<Aluno> listaAlunos = FonteDados.GetAlunos(); //Preencho a variável listaAlunos com a lista retornada pelo método GetAlunos()
FonteDados.ExibeAlunos(listaAlunos);
FonteDados.AdicionaAluno(listaAlunos);
FonteDados.AdicionaAluno(listaAlunos);
FonteDados.ExibeAlunos(listaAlunos);
FonteDados.BuscaAluno(listaAlunos);
FonteDados.ExibeAlunos(listaAlunos);

var listaOrdenada = listaAlunos.OrderBy(n => n.Nome).ToList();
/*Por se tratar de uma lista com elementos complexos, o método Sort() não consegue ordenar
Em função disso, usamos o OrderBy(), que retorna um IEnurerable ordenado pelo nome. Posteriormente convertemos de volta para uma lista */
Console.WriteLine("Lista de Alunos Ordenados : ");
FonteDados.ExibeAlunos(listaOrdenada);
FonteDados.AnalisaNotas(listaAlunos);


Console.Read();