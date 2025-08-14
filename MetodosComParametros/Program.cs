//Declaração de Métodos que utilizam parâmetros 

MinhaClasse usuario = new MinhaClasse();
usuario.Saudacao("Matheus", DateTime.Now.ToString()); //Método "estático"

//Método "dinâmico"
Console.Write("Digite seu nome : ");
string nome = Console.ReadLine();
string data = DateTime.Now.ToShortDateString();
usuario.Saudacao(nome, data);
//Se passa os parâmetros no momento em que se chama o método desejado

Console.ReadLine(); 
public class MinhaClasse
{
    //Declara-se os parâmetros com o tipo de dado + o nome do parâmetro
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine($"Olá, {nome}");
        Console.WriteLine($"Você está acessando no dia {data}");
    }
}

