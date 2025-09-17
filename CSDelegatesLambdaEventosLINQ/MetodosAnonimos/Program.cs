Imprimir impressao = delegate (int valor)
{
    Console.Write($"Valor escolhido pelo usuário: {valor}" );
};

impressao(10);

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Gabriel");
nomes.Add("Lucas");
nomes.Add("Matheus");

// Usamos o método Find para procurar um elemento dentro da lista
// O Find recebe como argumento um "Predicate<T>", ou seja,uma função que recebe um item da lista e retorna true ou false.
// Essa função é passada aqui como um delegate anônimo:
string? resultado = nomes.Find(delegate (string nome)
{
    // Para cada elemento da lista, o método Find vai chamar essa função,
    // passando o elemento atual como argumento do parâmetro "nome".

    // Se "nome" for igual a "\nPedro", retornamos true.
    // Isso não significa que "\nPedro" será retornado aqui!
    // Apenas sinalizamos para o Find que encontramos o item procurado.
    return nome.Equals("Pedro");
});

// Internamente, o Find funciona mais ou menos assim:
//
// foreach (string item in nomes)
// {
//     if (match(item))   // se o delegate (a função anônima) retorna true
//         return item;   // o próprio elemento da lista é retornado
// }
// return default; // se nada for encontrado, retorna null (para referência)

// Ou seja:
// - "Ana" é testado -> delegate retorna false
// - "João" é testado -> delegate retorna false
// - "\nPedro" é testado -> delegate retorna true -> Find retorna esse valor
// - A iteração para aqui, sem precisar olhar "Maria"

Console.WriteLine("\n" +resultado);

Console.Read();

public delegate void Imprimir(int valor);

