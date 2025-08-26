using System.Collections.Generic;
using System.Linq;

var limiteCredito = new List<Limite>();

for (int i = 0; i < 10; i++)
{
    limiteCredito.Add(new Limite { Numero = i});
}

var limitesComRestricao = limiteCredito.Where(l => l.AnalisaLimite());
//Nesse caso, a saída será apenas a mensagem "Fim do processo..."
Console.WriteLine("\nFim do processo...");

var primeiroLimiteComRestricao = limiteCredito.FirstOrDefault();
//Nesse caso, a saída será a mensagem "Executa análise de limite de Crédito para o limite X" apenas uma vez, inibindo as demais execuções
Console.WriteLine($"\nPrimeiro limite com restrição: {primeiroLimiteComRestricao?.Numero}");

var limitesComRestricao = limiteCredito.Where(l => l.AnalisaLimite()).ToList();
//Nesse caso, a saída será a mensagem "Executa análise de limite de Crédito para o limite X" 10 vezes
Console.WriteLine("\nFim do processo...");


Console.Read();

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero}");
        return isRestricao;
    }
}
