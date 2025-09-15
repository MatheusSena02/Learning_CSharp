try
{
    Console.Write("Informe o numerador: ");
    int valor1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o denominador: ");
    int valor2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Resultado da divisão: {valor1 / valor2}");

    Console.Read();
}
catch (Exception ex) when (ex.Message.Contains("format")) //Lança a exceção se a mensagem de exceção conter a palavra "format"
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("Erro de formatação");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();
