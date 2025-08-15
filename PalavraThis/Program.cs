//Demonstra o uso da palavra-chave this

AlunoComConstrutor alunoMatheus = new AlunoComConstrutor("Matheus", 21, "Masculino", 'S');
alunoMatheus.Exibir();

Console.ReadLine();
public class AlunoComConstrutor
{
    //Uso da palavra-chave 'this' para diferenciar os atributos da classe dos parâmetros do construtor
    public AlunoComConstrutor(string Nome, int Idade, string Sexo, char Aprovado)
    {
        this.Nome = Nome; //O uso do 'this' é necessário para diferenciar o atributo da classe do parâmetro do construtor
        this.Idade = Idade;
        this.Sexo = Sexo;
        this.Aprovado = Aprovado;
    }

    public void PassarDados(AlunoComConstrutor estudante)
    {
        Console.WriteLine(this);
        Console.WriteLine(estudante.Nome);
        Console.WriteLine(estudante.Idade);
        Console.WriteLine(estudante.Sexo);
        Console.WriteLine(estudante.Aprovado);
    }

    public void Exibir()
    {
        PassarDados(this); //O uso do 'this' é necessário para passar o objeto atual como parâmetro
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public char? Aprovado;
}