string[,] alunos = new string[2, 5];

for(int i = 0; i < alunos.GetLength(0); i++)
{
    for(int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"Informe o nome do aluno da linha {i} e coluna {j} : ");
        alunos[i, j] = Console.ReadLine();
    }
}

foreach(var nome in alunos)
{
    Console.Write($"{nome}, ");
}


Console.ReadLine();