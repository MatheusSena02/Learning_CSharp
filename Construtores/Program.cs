//Construtores 

AlunoSemConstrutor estudante = new();
Console.WriteLine(estudante.Nome == null ? "null" : estudante.Nome);
Console.WriteLine(estudante.Idade);
Console.WriteLine(estudante.Sexo == null ? "null" : estudante.Sexo);
Console.WriteLine(estudante.Aprovado == null ? "null" : estudante.Aprovado); 

AlunoComConstrutor estudante2 = new AlunoComConstrutor("Cassiopéia", 20, "Masculino", 'S');
//Nesse caso, ao criar um objeto do tipo AlunoComConstrutor, é necessário passar os parâmetros para o construtor
Console.WriteLine(estudante2.Nome);
Console.WriteLine(estudante2.Idade);
Console.WriteLine(estudante2.Sexo);
Console.WriteLine(estudante2.Aprovado);

AlunoComConstrutor estudante3 = new AlunoComConstrutor("Matheus");
Console.WriteLine(estudante3.Nome);

Console.ReadLine(); 

public class AlunoSemConstrutor() 
{
    //O construtor padrão inicializa todos os atributos da classe com valores padrão.
    public string? Nome;    //valor null ao inicializar 
    public int Idade;       //valor 0 ao inicializar 
    public string? Sexo;    //valor null ao inicializar 
    public char? Aprovado;   //valor null ao inicializar 
}

public class AlunoComConstrutor
{
    //Construtor que recebe parâmetros para inicializar os atributos da classe
    public AlunoComConstrutor(string nome, int idade, string sexo, char aprovado):this(nome)
    //Nesse caso, o atributo nome no construtor é buscado ao chamar o outro construtor utilizando operador 'this'
    //Basicamente, quando o atributo nome é evocado, ele vai ser jogado para outro construtor, onde será atribuído
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public AlunoComConstrutor(string nome)=>
        Nome = nome;
    //Sintaxe compacta na declaração de métodos

    public string? Nome;    
    public int Idade;       
    public string? Sexo;        
    public char? Aprovado;
}