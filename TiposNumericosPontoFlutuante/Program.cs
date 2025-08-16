//Declaração de variáveis numéricas ponto flutuante em C#

float valorFloat = 1f / 3f;
double valorDouble = 1.0 / 3.0;
decimal valorDecimal = 1m / 3m;

Console.WriteLine($"Grau de precisão do tipo float: {valorFloat}");
Console.WriteLine($"Grau de precisão do tipo double: {valorDouble}");
Console.WriteLine($"Grau de precisão do tipo decimal: {valorDecimal}");

/* 
Tabela de tipos numéricos de ponto flutuante em C#: 

float : Precisão de 6 a 9 dígitos decimais (F ou f como sufixo)
double (padrão) : Precisão de 15 a 17 dígitos decimais (D ou d como sufixo)
decimal : Precisão de 28 a 29 dígitos decimais (M ou m como sufixo)
*/