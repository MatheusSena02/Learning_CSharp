using System;

var caminhoOrigem = @"C:\Users\matheus.sena\Documents\arquivo1.txt";
var caminhoDestino = @"C:\Users\matheus.sena\Documents\caminho\arquivo1.txt";
var caminhoCopia = @"C:\Users\matheus.sena\Documents\copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);
Console.WriteLine($"Nome do arquivo: {arquivoOrigem.Name}");
Console.WriteLine($"Caminho do arquivo: {arquivoOrigem.FullName}");
Console.WriteLine($"Instância do arquivo: {arquivoOrigem.IsReadOnly}");

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine($"Diretório do arquivo: {diretorioPai.Name}");
Console.WriteLine($"Tamanho do arquivo: {arquivoOrigem.Length} bytes");
Console.WriteLine($"Última gravação do arquivo: {arquivoOrigem.LastWriteTime}");

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"Copiando o arquivo {caminhoOrigem} para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    throw new FileNotFoundException("Arquivo não encontrado");
}

Console.WriteLine($"\nMovendo {arquivoOrigem} para {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino); 


Console.ReadLine();