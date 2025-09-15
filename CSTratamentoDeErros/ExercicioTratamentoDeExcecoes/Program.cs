try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");
    Console.Write("Informe o nome do arquivo: ");
    string? arquivo = Console.ReadLine();
    Console.Write("Informe a URL do site: ");
    string? url = Console.ReadLine();
    Console.WriteLine("Aguarde...");
    
    HttpClient client = new HttpClient();
    HttpResponseMessage responde = client.GetAsync(url + arquivo).Result;

    if (responde.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso");
        Console.WriteLine("Código de status:  " + responde.StatusCode);
    }
    else
    {
        throw new HttpRequestException($"Erro: {(int)responde.StatusCode}");
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");  
}

Console.Read();