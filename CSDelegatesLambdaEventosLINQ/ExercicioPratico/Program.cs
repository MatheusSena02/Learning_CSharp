MensagemBoasVindas impressao = delegate ()
{
    Console.WriteLine("Seja bem-vindo(a)");
};
impressao += () => Console.WriteLine("Welcome");

impressao.Invoke();

Console.Read();

public delegate void MensagemBoasVindas();