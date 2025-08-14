//Passagem de Parâmetros entre Classes

Aluno estudante1 = new Aluno();
estudante1.Nome = Console.ReadLine();
estudante1.Idade = Convert.ToInt32(Console.ReadLine());
estudante1.Sexo = Console.ReadLine();   
estudante1.Aprovado = Convert.ToChar(Console.ReadLine());

Curso resultadoEstudante1 = new();
resultadoEstudante1.Resultado(estudante1);
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
    public void Resultado(Aluno estudante)  //O método espera receber como parâmetro um objeto do tipo Aluno
    {
        //Essa tática evita a estação prolonga da lista de parâmetros no método
        Console.WriteLine($"\nO aluno {estudante.Nome} de {estudante.Idade} anos do sexo {estudante.Sexo}"); //A operação acesso os atributos do objeto definido no parâmetro do método
        if(estudante.Aprovado == 'S')
        {
            Console.WriteLine("\nFoi aprovado");
        }
        else
        {
            Console.WriteLine("\nFoi reprovado");
        }
    }
}