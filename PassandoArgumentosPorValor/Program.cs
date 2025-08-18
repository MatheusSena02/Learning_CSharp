using Calculo;

int x = 10;
Console.WriteLine($"Valor de X antes da Operação : {x}");
Calculadora calc = new Calculadora(x);
Console.WriteLine($"Valor de X após a Operação : {x}");
Console.WriteLine("Percebe-se que o valor base de x permanece inalterado");
Console.ReadLine();