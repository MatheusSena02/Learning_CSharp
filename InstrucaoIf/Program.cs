//Estruturas de Controle : Instrução If

Console.WriteLine("Cliente Especial ? (S / N)");
var resposta = Convert.ToChar(Console.ReadLine());
//Declaração comum de um condicional if 
//resposta == 'S' = true -> executa o comando
if (resposta == 'S')
{
    Console.WriteLine("Desconto de 10%");
}

Console.Write("Informe o valor de X : ");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("\nInforme o valor de Y : ");
var y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine("X é maior que Y");
}
if (x < y)
{
    Console.WriteLine("X é menor que Y");
}
if (x == y)
{
    Console.WriteLine("X e Y possuem valores iguais");
}

Console.ReadLine();