try
{
    Console.Write("Informe o numerador: ");
    int valor1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o denominador: ");
    int valor2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Resultado da divisão: {valor1/valor2}");

    Console.Read();
}
catch (FormatException) //Tratamento para forma de dados indevida
{
    Console.WriteLine("Informe um valor inteiro");
}
catch (OverflowException)   //Tratamento para tamanho indevido de valor
{
    Console.WriteLine("Informe um valor no tamanho do escopo");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Insira um denominador diferente de 0");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);  //Fornece detalhes sobre a causa da exceção
    Console.WriteLine(ex.Source);   //Obtém ou define o nome do aplicativo ou objeto que causou o erro
    Console.WriteLine(ex.StackTrace);  //Contém um rastreamento de pilha que pode usado para determinar onde ocorreu o erro
}

Console.ReadLine();
