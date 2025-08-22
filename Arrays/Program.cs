//Declaração padrão de array
int[] array1 = new int[10];
//Alocando memória para este array

//Declaração padrão e definição de valores de array
int[] array2 = new int[5] { 0, 1, 2, 3, 4 };

int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

string [] listaCliente = new string[] { "Matheus", "Maria", "Eduardo", "Helena", "Sérgio" };

//Acessando elemento de uma array
Console.WriteLine($"Valor na posição 3 da array2 : {array2[3]}\n");

for(int i = 0; i < listaCliente.Length; i++)
{
    Console.WriteLine($"Cliente n° {i+1} : {listaCliente[i]}");
}

Console.WriteLine();

//Acessando elementos de um array usando foreach

//O laço forearch permite executar uma instrução ou um bloco de instrução para cada elemento presente em uma coleção
foreach(int valor in numeros)
{
    Console.WriteLine($"Valor padrão : {valor}\tValor dobrado : {valor*2}");
}


Console.Read();