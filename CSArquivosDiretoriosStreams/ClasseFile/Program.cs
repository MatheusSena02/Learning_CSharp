
string caminhoOrigem = @"C:\Users\matheus.sena\Documents\arquivo1.txt";
//Uso do caractere verbatim para evitar erro do compilador e ler de maneira literal o caminho

//Criação de arquivo
//try
//{
//    File.Create(caminhoOrigem);

//}catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

if (File.Exists(caminhoOrigem))
{
    File.WriteAllText(caminhoOrigem, "Fernando Pessoa \r\nAutor");  //Se o arquivo não existe o WirteAllText cria o arquivo, já com o conteúdo preenchido
    //\r\n = Forma de incluir caracteres Unicode 

    string poema = "\r\nO poeta é fingidor" + Environment.NewLine + "Finge tão completamente \r\n" + "Que chega a fingir que é dor \r\n" + "A dor que deveras sente \r\n";
                                       //Pula para uma nova linha

    File.AppendAllText(caminhoOrigem, poema);
    Console.WriteLine("Conteúdo do arquivo : ");
    string conteudo = File.ReadAllText(caminhoOrigem);
    Console.WriteLine(conteudo);

    Console.WriteLine($"Última modificação feita no arquivo : {File.GetLastWriteTime(caminhoOrigem)}");     //Informa o momento da última modificação feita
    Console.WriteLine($"Último acesso feita no arquivo : {File.GetLastAccessTime(caminhoOrigem)}");         //Informa o momento do último acesso feito
    string[] linhas = File.ReadAllLines(caminhoOrigem);

    for(int i = 0; i < linhas.Length; i++)  //Captura cada linha do texto e armazena em um vetor de string
    {
        Console.WriteLine($"Linha {i+1}: {linhas[i]}");
    }
}
else
{
    Console.WriteLine("Nâo foi possível criar o arquivo");
}



    Console.Read();
