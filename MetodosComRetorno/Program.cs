//Demonstração de Métodos com Retorno
using MetodosComRetorno;

var cal = new Calculadora();

int valorUm = cal.Somar(10, 10);
Console.WriteLine($"Valor Um : {valorUm}");
valorUm = cal.Subtrair(10, 5);
Console.WriteLine($"Valor Um : {valorUm}");
Console.WriteLine(cal.Produto(2, 5));
Console.WriteLine(cal.Quociente(2, 5));
Console.ReadLine();