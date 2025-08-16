//Estrutura de Controle : Condicional If Else-If

Console.Write("Digite a nota do aluno : ");
var nota = Convert.ToDouble(Console.ReadLine());
if(nota >= 7)
{
    Console.WriteLine("Aluno Aprovado");
}else if(nota < 7 && nota > 5)
{
    Console.WriteLine("Aluno em Recuperação");
}else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.ReadLine();