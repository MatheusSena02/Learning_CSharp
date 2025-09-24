var caminhoDiretorio = @"C:\Users\matheus.sena\Documents\diretorio_learningcsharp";


//Criação de repositório

try     //Recomenda-se utilizar o bloco try-catch ao criar diretórios
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine("Diretório criado com sucesso");
    }
    else
    {
        throw new Exception("Diretório já existente");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); 
}

//Deleção do diretório

try    
{
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Delete(caminhoDiretorio);
        Console.WriteLine("Diretório deletado com sucesso");
    }
    else
    {
        throw new Exception("Diretório não existente");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.Read();