Console.Write("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
  
Action<int> dobra = x => Console.Write($"Resultado: {x* 2}\n");
//delegate void Action <int T> (T obj)

dobra(numero);

Action dobraPadrao = Duplicar;
dobraPadrao.Invoke(5);

Console.Read();

static void Duplicar(int num)
{
    int resultado = num * 2;
    Console.Write($"Resultado: {resultado}");
}

public delegate void Action(int numero);