//Estrutura de Controle : Condicional If-Else

Console.Write("É um cliente especial (S / N) : ");
var resposta = Convert.ToChar(Console.ReadLine());

//Estrutura de padrão comum do if-esle
if (resposta == 'S')
{
    Console.WriteLine("Desconto de 10%");
}
else
{
    Console.WriteLine("Não possuí desconto. Valor inteiro");

}

Console.Write("Informe a nota do aluno : ");
var nota = Convert.ToDouble(Console.ReadLine());
if (nota >= 7)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.ReadLine();
