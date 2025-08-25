//Declaração de um array bidimensional 

int[,] array1 = new int[2, 3]; //Um array bidimensional com 2 linhas e 3 colunas
//array1 é um array bidimensional com 2 elementos e cada elemento é um array unidimensional com 3 elementos

for (int i = 0; i < array1.GetLength(0); i++) //GetLength(0) retorna o número de linhas do array (Primeira dimensão)
{
    for(int j = 0; j < array1.GetLength(1); j++) //GetLength(1) retorna o número de colunas do array (Segunda dimensão)
    {
        array1[i, j] = 1;
    }
}

foreach(int n in array1)
{
    Console.Write("|" + n + "|" + "\t\n");
}


string[,] nomeProfissao = new string[4, 2] {
    {"Ana", "Desenvolvedora"},
    {"Anderson", "DBA"},
    {"Carlos", "Gerente de Projetos"},
    {"Daniel", "Desenvolvedor"}
};

foreach(string n in nomeProfissao) 
{
    Console.Write($"|{n}|");

}
Console.Read();