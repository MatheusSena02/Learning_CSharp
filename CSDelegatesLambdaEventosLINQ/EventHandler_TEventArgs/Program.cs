var pedido = new Pedido();

//Inscreve os assinantes no evento, ou seja, aquilo que será disparado quando o evento for chamado
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido("matheus@gmail.com", "(71) 9 98756324");

Console.Read();

//Não necessita declarar um delegate



//Criar a classe que herda de EventArgs e armazenará os dados que desejamos obter
public class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

public class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;

    public void CriarPedido(string email, string fone)
    {
        Console.WriteLine("\nPedido criado!!!");
        if (OnCriarPedido != null)   //Verifica se o evento foi criado com sucesso
        {
            // Dispara (invoca) o evento OnCriarPedido, passando o objeto atual (this) como remetente
            // e EventArgs.Empty como argumento padrão (sem dados adicionais).
            // Isso faz com que todos os métodos inscritos no evento sejam executados.
            // No contexto deste código, os métodos Email.Send e SMS.Send serão chamados.
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = fone});    //Invoca o evento   
        }
    }
}

public class SMS
{
    // Método estático responsável por enviar um SMS quando o evento é disparado.
    // Parâmetros:
    //   sender: objeto que disparou o evento (neste caso, a instância de Pedido)
    //   e: argumentos do evento (EventArgs.Empty, pois não há dados adicionais)
    public static void Send(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um SMS para o número: {e.Telefone}");
    }
}

public class Email
{
    public static void Send(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um email para : {e.Email}");
    }

}
