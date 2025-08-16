//Declaração padrão de Nullable Types

Nullable<int> nullInt = null;
Nullable<double> nullDouble = null;
Nullable<bool> nullBool = null;

Console.WriteLine($"Nullable Int: {nullInt}");
Console.WriteLine($"Nullable Double: {nullDouble}");
Console.WriteLine($"Nullable Bool: {nullBool}");


//Declaração implícita de Nullable Types

int ? nullImplicitInt = null;
double ? nullImplicitDouble = null;
bool ? nullImplicitBool = null;

//Atribuição de valoes entre diferentes tipos de dados

nullInt = null; 
int nulo = nullInt ?? 0; // Usando o operador de coalescência nula
//Como o valor da esquerda é null, ele retorna o valor da direita
//Cason contrário, ele retornaria o valor da esquerda
Console.WriteLine($"Nulo Int: {nulo}");
//Saída esperada: 0

//Trabalhando com operador com operadores de consciência nula

int a = 4;
int b = (nullInt ?? 10) * a; // Se nullInt for null, usa 10 
if (nullInt.HasValue)
{
    Console.WriteLine($"nullInt tem valor: {nullInt.Value}");
}
else
{
    Console.WriteLine("nullInt é null, usando valor padrão de 10.");
}
    Console.WriteLine($"Resultado de b: {b}");  



Console.ReadKey();