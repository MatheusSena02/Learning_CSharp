//Tipos de dados não numéricos : Bool e Char 
bool valorBooleano = true;
char valorChar = 'A'; //Declaração em aspas simples 
char valorCharUnicode = '\u0041';  //Valor do caractere 'A' na tabela Unicode
//O tipo bool pode ser obtido através de operações lógicas, como comparações
Console.WriteLine($"Comparação entre 10 e 10 = {10 == 10}"); //Saída = True
Console.WriteLine($"Comparação entre 10 e o valor de char = {valorChar == 10}"); //Saída = False
Console.WriteLine($"Comparação entre valor char e o valor de char em Unicode = {valorChar == valorCharUnicode}"); //Saída = False
if (valorChar == 'A')
{
    Console.WriteLine(valorBooleano);
}

Console.ReadLine();

