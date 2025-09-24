var caminhoDiretorio = @"C:\Users\matheus.sena\Documents";

var dirOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine($"Nome do diretório: {dirOrigem.Name}");
Console.WriteLine($"Caminho do diretório: {dirOrigem.FullName}");
Console.WriteLine($"Data de criação do diretório: {dirOrigem.CreationTime}");
Console.WriteLine($"Último acesso do diretório: {dirOrigem.LastAccessTime}");
Console.WriteLine($"Última modificação do diretório: {dirOrigem.LastWriteTime}");
Console.WriteLine($"Atributos: {dirOrigem.Attributes}");

//Criação de um novo diretório 

var novoDiretorio = new DirectoryInfo(@"C:\Users\matheus.sena\Documents\MeuDiretorio");

try
{
    if(!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
    }
    else
    {
        throw new Exception("Diretório já existente");
    }
}catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Deleção do Diretório
try
{
    if (!novoDiretorio.Exists)
    {
        throw new Exception("Diretório não existente");
    }
    else
    {
        novoDiretorio.Delete();
        Console.WriteLine("Diretório excluído com sucesso");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Obtendo subdiretórios
Console.WriteLine("\nObtendo os subdiretórios do diretórios: ");
try
{
    foreach(var sub in dirOrigem.GetDirectories())
    {
        Console.WriteLine(sub.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//Obtendo os arquivos
Console.WriteLine("\nObtendo os arquivos do diretórios: ");
try
{
    foreach (var arq in dirOrigem.GetFiles())
    {
        Console.WriteLine(arq.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();