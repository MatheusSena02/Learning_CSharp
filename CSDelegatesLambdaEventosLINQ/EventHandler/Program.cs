var pedido = new Pedido();

//Inscreve os assinantes no evento, ou seja, aquilo que será disparado quando o evento for chamado
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido();

Console.Read();

//Não necessita declarar um delegate

public class Pedido
{
    public event EventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado!!!");
        if (OnCriarPedido != null)   //Verifica se o evento foi criado com sucesso
        {
            // Dispara (invoca) o evento OnCriarPedido, passando o objeto atual (this) como remetente
            // e EventArgs.Empty como argumento padrão (sem dados adicionais).
            // Isso faz com que todos os métodos inscritos no evento sejam executados.
            // No contexto deste código, os métodos Email.Send e SMS.Send serão chamados.
            OnCriarPedido(this, EventArgs.Empty);    //Invoca o evento   
        }
    }
}

public class SMS
{
    // Método estático responsável por enviar um SMS quando o evento é disparado.
    // Parâmetros:
    //   sender: objeto que disparou o evento (neste caso, a instância de Pedido)
    //   e: argumentos do evento (EventArgs.Empty, pois não há dados adicionais)
    public static void Send(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}

public class Email
{
    public static void Send(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um email");
    }

}
