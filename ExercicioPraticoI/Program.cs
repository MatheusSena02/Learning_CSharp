string[] nomes = new string[5];

double[] notas = new double[5];
double media = 0;

for(int i = 0; i <nomes.Length; i++)
{
    nomes[i] = Console.ReadLine();
}

for(int i = 0; i <notas.Length; i++)
{
    notas[i] = Convert.ToDouble(Console.ReadLine());
    media += notas[i];

}

media /= 5;

foreach(string s in nomes)
{
    Console.WriteLine($"Nome do Aluno : {s}");
}

foreach(double n in notas)
{
    Console.WriteLine($"Nota do Aluno : {n}");
}

Console.WriteLine($"Média das notas : {media}");

Console.ReadLine();
