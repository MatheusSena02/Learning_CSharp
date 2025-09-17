Impressao impressaoMensagem = (string message) => Metodo1(message);
impressaoMensagem += Metodo2;

impressaoMensagem.Invoke("Hello World!");

var metodoB = impressaoMensagem.GetInvocationList()[1];
metodoB.DynamicInvoke("Mensagem diferente"); 

Console.Read();

static void Metodo1(string message)
{
    Console.WriteLine(message);
}

static void Metodo2(string message)
{
    Console.WriteLine($"Messagem 2 : {message}");
}

public delegate void Impressao(string messagem);