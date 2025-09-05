using GetHashCode;

int valor1 = 10;
int valor2 = 20;

//Comparativo entre tipos primitivos
Class1 comparador = new();
Console.WriteLine($"Resultado da comparação entre valor1 e valor2: {comparador.Comparar(valor1, valor2)}");

//Comparativo entre tipos definidos pelo usuário 
var pessoa1 = new Pessoa(1, "Ana");
var pessoa2 = new Pessoa(1, "Ana");
Console.WriteLine($"Resultado da comparação de pessoa1 e pessoa2: {pessoa1.Equals(pessoa2)}");
//Saída : false

pessoa1 = pessoa2;
Console.WriteLine($"Resultado da comparação de pessoa1 e pessoa2: {pessoa1.Equals(pessoa2)}");
//Saíde : true (apontam para a mesma referência)

var pessoa3 = new Pessoa(1, "Matheus");
Console.WriteLine($"Resultado da comparação de pessoa1 e pessoa3: {pessoa1.Equals(pessoa3)}");
//Saída : True (pois ambos possuem o mesmo ID)

var pessoa4 = new Pessoa(2, "Matheus");
Console.WriteLine($"Resultado da comparação de pessoa3 e pessoa4: {pessoa3.Equals(pessoa4)}");
//Saída : False (pois ambos possuem diferentes ID)

Console.Read();