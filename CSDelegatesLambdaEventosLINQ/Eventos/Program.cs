var pedido = new Pedido();

//Inscreve os assinantes no evento, ou seja, aquilo que será disparado quando o evento for chamado
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido();

Console.Read();

// Tornar o delegate público para corresponder à acessibilidade do evento
public delegate void PedidoEventHandler();

public class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado!!!");
        if(OnCriarPedido != null)   //Verifica se o evento foi criado com sucesso
        {
            OnCriarPedido();    //Invoca o evento   
        }
    }
}

public class SMS
{
    public static void Send()
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}

public class Email
{
    public static void Send()
    {
        Console.WriteLine("\nEnviando um email");
    }
    
}
