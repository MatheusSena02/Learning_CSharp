//Passagem de Parâmetros entre Classes

Aluno estudante1 = new Aluno();
estudante1.Nome = Console.ReadLine();
estudante1.Idade = Convert.ToInt32(Console.ReadLine());
estudante1.Sexo = Console.ReadLine();   
estudante1.Aprovado = Convert.ToChar(Console.ReadLine());

Curso resultadoEstudante1 = new();
resultadoEstudante1.Resultado(estudante1.Nome, estudante1.Idade, estudante1.Sexo, estudante1.Aprovado);
Console.ReadLine();

public class Aluno()
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public char Aprovado; 
}

public class Curso()
{
    public void Resultado(string nome, int idade, string sexo, char aprovado)
    {
        Console.WriteLine($"\nO aluno {nome} de {idade} anos do sexo {sexo}");
        if(aprovado == 'S')
        {
            Console.WriteLine("\nFoi aprovado");
        }
        else
        {
            Console.WriteLine("\nFoi reprovado");
        }
    }
}