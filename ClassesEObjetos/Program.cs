//Definição de uma classe chamada DadosPessoa

class DadosPessoa
{
    //Definição de atributos
    public string? nome;
    public int idade;
    public string? sexo;
}

class Program
{
    static void Main()
    {
        DadosPessoa primeiraPessoa = new(); //Instanciação de um objeto da classe DadosPessoa
        primeiraPessoa.nome = "João"; //Atribuição de valor ao atributo nome
        primeiraPessoa.idade = 30; //Atribuição de valor ao atributo idade
        primeiraPessoa.sexo = "Masculino"; //Atribuição de valor ao atributo sexo

        DadosPessoa dadosPessoa = new();
        dadosPessoa.nome = "Maria"; //Atribuição de valor ao atributo nome
        dadosPessoa.idade = 25; //Atribuição de valor ao atributo idade
        dadosPessoa.sexo = "Feminino"; //Atribuição de valor ao atributo sexo
    }
}




