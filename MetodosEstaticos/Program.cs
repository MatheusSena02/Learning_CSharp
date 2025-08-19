using MetodosEstaticos;

var valor = Calculadora.Somar(10, 20);
Console.WriteLine($"A soma é: {valor}");
valor = Calculadora.Subtrair(10, 20);
Console.WriteLine($"A subtração é: {valor}");
valor = Calculadora.Produto(10, 20);
Console.WriteLine($"O produto é: {valor}");
valor = Calculadora.Quociente(10, 20);
Console.WriteLine($"O quociente é: {valor}");
valor = Calculadora.Modul(10, 20);
Console.WriteLine($"O módulo é: {valor}");
