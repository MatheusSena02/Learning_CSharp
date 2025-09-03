using ExercicioInterfaces;

SalvarJson arquivoJson = new();
arquivoJson.Nome("ENF_livro");
arquivoJson.Salvar();
// Converte a instância para a interface ISave para acessar o método Compactar
((ISave)arquivoJson).Compactar();

Console.WriteLine("\n");

SalvarXml arquivoXml = new();
arquivoXml.Nome("recibo");
arquivoXml.Salvar();
((ISave)arquivoXml).Compactar();


Console.Read();