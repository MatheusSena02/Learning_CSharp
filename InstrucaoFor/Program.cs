//Estrutura de Repetição : Loop For

int resultado, numero;
Console.Write("Informe um número inteiro : ");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nTabuada do " + numero);

//Estrutura padrão e uso do for

for(int i = 0; i < 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} * {i} = {resultado}");
}

Console.ReadLine();