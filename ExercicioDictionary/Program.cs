using Class1;

Dictionary<int, Aluno> listaAlunoNota = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 7)},
    {2, new Aluno("Eric", 8)},
    {3, new Aluno("Ana", 9)},
    {4, new Aluno("Alex", 6)},
    {5,  new Aluno("Diná", 5)}
};

foreach(var item in listaAlunoNota)
{
    item.Value.ExibeNotaAluno();
}

Console.WriteLine(Aluno.BuscaAluno(listaAlunoNota, "Maria"));



Console.Read();