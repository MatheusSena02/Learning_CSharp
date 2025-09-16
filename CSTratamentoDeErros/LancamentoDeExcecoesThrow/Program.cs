Vam                                                                                                                                    ApnA.ProcessarA();
Console.Read();
class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception)
        {
            Console.WriteLine("Tratando a exceção na classe A");
        }
        
    }
}
class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception)
        {
            {
                throw;  //Pula para a próxima iteração da stack trace
                Console.WriteLine("Tratando a exceção na classe B");
            }

        }
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}