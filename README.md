# Array, ArrayList e List

## Passagem de Arrays como Argumento 

Quando surge a necessidade de passar uma grande quantidade de dados para um método, pode-se utilizar um array. <br>
Para isso, bastaria indicar a espera de um array como parâmetro do método.

```csharp

int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine($"Método sem params : {resultado}");

public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach(int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

### Modificadores params

O modificador `params` permite que você passe um número variável de argumentos para um método, sem a necessidade de criar um array explicitamente, mas listando os valores a serem passados de maneira semelhante à uma array. Isso é útil quando você não sabe quantos argumentos serão passados para o método. O parâmetro `params` deve ser o último parâmetro do método, podendo ser usado apenas e pode ser usado com arrays ou tipos primitivos.
```csharp
public static int Soma(params double[] numeros)
    {
        //O método params permite que se passe um lista de valores no argumento, com formatação semelhante à de uma array
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

## Arrays Multidimensionais

Arrays multidimensionais são arrays que possuem mais de uma dimensão, permitindo armazenar dados em uma estrutura de tabela ou matriz. Em C#, você pode criar arrays multidimensionais adicionando vírgulas entre os colchetes, equivalente ao número de dimensões que você deseja adicionar.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
int[,,] cubo = new int[3, 3, 3]; // Cria um array tridimensional 3x3x3
```

### Função GetLength(n)

A função `GetLength(n)` retorna o tamanho da dimensão especificada do array. O parâmetro `n` é um índice baseado em zero que indica qual dimensão você deseja obter o tamanho. <br>
Se n for '0', a função retornará o tamanho da primeira dimensão; se n for '1', retornará o tamanho da segunda dimensão, e assim por diante.


### Arrays Bidimensionais

Os arrays bidimensionais são uma forma de armazenar dados em uma tabela com linhas e colunas. Em C#, você pode acessar os elementos de um array bidimensional usando dois índices: um para a linha e outro para a coluna.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 4;
matriz[1, 1] = 5;
matriz[1, 2] = 6;
matriz[2, 0] = 7;
matriz[2, 1] = 8;
matriz[2, 2] = 9;
```


## ArrayList

A classe `ArrayList` é uma coleção cuja o tamanho pode ser alterado dinamicamente e que pode armazenar elementos de qualquer tipo, pois armazena os elementos como objetos do tipo `object`. Isso significa que você pode adicionar diferentes tipos de dados em um único `ArrayList` e que o tamanho do `ArrayList` pode crescer ou diminuir conforme a adição ou retirada de elementos.

|Métodos|Definição|
|-------|----------|
|`Count`| Propriedade que retorna o número atual de elementos na coleção|
|`Capacity`| Propriedade que retorna ou define a capacidade atual do ArrayList.|
|`Add(object value)`| Método que adiciona um elemento ao final do ArrayList.|
|`Remove(object value)`| Método que remove a primeira ocorrência de um elemento específico do ArrayList.|
|`Insert(int index, object value)`| Método que insere um elemento em uma posição específica do ArrayList.|
|`Clear()`| Método que remove todos os elementos do ArrayList.|
|`Contains(object value)`| Método que verifica se um elemento específico está presente no ArrayList.|
|`IndexOf(object value)`| Método que retorna o índice da primeira ocorrência de um elemento específico no ArrayList.|
|`Sort()`| Método que ordena os elementos do ArrayList em ordem crescente.|
|`ToArray()`| Método que converte o ArrayList em um array.|
|`TrimToSize()`| Método que ajusta a capacidade do ArrayList para o número atual de elementos, liberando memória não utilizada.|
|`Clone()`| Método que cria uma cópia superficial do ArrayList.|
|`GetRange(int index, int count)`| Método que retorna uma sublista do ArrayList, começando no índice especificado e contendo o número especificado de elementos.|
|`Reverse()`| Método que inverte a ordem dos elementos no ArrayList.|

```csharp
//Método usando inicialização de coleção (Collection Initializer)
var lista = new ArrayList() 
{
    "Paulo", 4.5, 10, true, 'A', "Texto"
};

//Método usando Add()
ArrayList lista = new ArrayList(); //Count = 0 e Capacity = 0
lista.Add("Texto"); //Count = 1 e Capacity = 4
lista.Add(123); //Count = 2 e Capacity = 4
lista.Add(true); //Count = 3 e Capacity = 4
```

#### Construtores ArrayList 

- `ArrayList()`: Cria um ArrayList vazio com capacidade inicial padrão;
- `ArrayList(int capacidadeInicial)`: Cria um ArrayList vazio com a capacidade inicial especificada;
- `ArrayList(ICollection colecao)`: Cria um ArrayList que contém os elementos da coleção especificada.

### Adição de Elementos

|Método|Definição|
|-------|----------|
|`Add(object value)`| Adiciona um elemento ao final do ArrayList.|
|`AddRange(ICollection c)`| Adiciona os elementos de uma coleção ao final do Arra yList.|
|`Insert(int index, object value)`| Insere um elemento em uma posição específica do ArrayList.|
|`InsertRange(int index, ICollection c)`| Insere os elementos de uma coleção em uma posição específica do ArrayList.|

### Remoção de Elementos

|Método|Definição|
|-------|----------|
|`Remove(object value)`| Remove a primeira ocorrência de um elemento específico do ArrayList.|
|`RemoveAt(int index)`| Remove o elemento na posição especificada do ArrayList.|
|`RemoveRange(int index, int count)`| Remove um intervalo de elementos do ArrayList, começando no índice especificado e removendo o número especificado de elementos.|
|`Clear()`| Remove todos os elementos do ArrayList. Sem alterar sua capacidade (Count - 0)|

### Acesso e Pesquisa de Elementos

|Método|Definição|
|-------|----------|
|`Contains(object value)`| Verifica se um elemento específico está presente no ArrayList.|
|`IndexOf(object value)`| Retorna o índice da primeira ocorrência de um elemento específico no ArrayList.|
|`LastIndexOf(object value)`| Retorna o índice da última ocorrência de um elemento específico no ArrayList.|
|`GetRange(int index, int count)`| Retorna uma sublista do ArrayList, começando no índice especificado e contendo o número especificado de elementos.|
|`ToArray()`| Converte o ArrayList em um array.|
|`ToArray(Type tipo)`| Converte o ArrayList em um array do tipo especificado.|
|`Clone()`| Cria uma cópia superficial do ArrayList.|

### Ordenação e Manipulação

|Método|Definição|
|-------|----------|
|`Sort()`| Ordena os elementos do ArrayList em ordem crescente (desde que os elementos sejam do mesmo tipo).|
|`Reverse()`| Inverte a ordem dos elementos no ArrayList.|
|`TrimToSize()`| Ajusta a capacidade do ArrayList para o número atual de elementos, liberando memória não utilizada.|
|`SetRange(int index, ICollection c)`| Substitui um intervalo de elementos no ArrayList, começando no índice especificado, pelos elementos da coleção especificada.|
|`BinarySearch(object value)`| Realiza uma busca binária por um elemento específico no ArrayList. O ArrayList deve estar ordenado para que a busca funcione corretamente.|

## Coleção List < T >

A classe `List<T>` é uma coleção genérica que armazena elementos de um tipo específico, definido pelo parâmetro de tipo `T`. Diferente do `ArrayList`, que armazena elementos como objetos do tipo `object`, o `List<T>` oferece melhor desempenho e segurança de tipo, pois todos os elementos na lista são do mesmo tipo. Além disso, o `List<T>` também permite que você defina a capacidade inicial da lista e pode crescer dinamicamente conforme você adiciona mais elementos.

### Por que usar List<T> ao invés de ArrayList?

- **Segurança de Tipo**: Com `List<T>`, você especifica o tipo de elementos que a lista pode conter, o que ajuda a evitar erros de tempo de execução relacionados a tipos incompatíveis. Com `ArrayList`, você pode adicionar qualquer tipo de objeto, o que pode levar a erros se você tentar acessar um elemento como um tipo diferente do que ele realmente é.
- **Desempenho**: `List<T>` geralmente oferece melhor desempenho do que `ArrayList`, especialmente quando se trata de operações que envolvem muitos elementos, porque evita a necessidade de conversões de tipo (boxing e unboxing) que ocorrem com `ArrayList`.

### Métodos de List < T >

Os métodos disponíveis na classe `List<T>` são semelhantes aos do `ArrayList`, mas com a vantagem de serem fortemente tipados. Por exemplo : 

|Método|Definição|
|-------|----------|
|`Add(T item)`| Adiciona um elemento do tipo T ao final da lista.|
|`AddRange(IEnumerable<T> collection)`| Adiciona os elementos de uma coleção ao final da lista.|
|`Insert(int index, T item)`| Insere um elemento do tipo T em uma posição específica da lista.|
|`InsertRange(int index, IEnumerable<T> collection)`| Insere os elementos de uma coleção em uma posição específica da lista.|
|`Remove(T item)`| Remove a primeira ocorrência de um elemento específico do tipo T da lista.|
|`RemoveAt(int index)`| Remove o elemento na posição especificada da lista.|
|`RemoveRange(int index, int count)`| Remove um intervalo de elementos da lista, começando no índice especificado e removendo o número especificado de elementos.|
|`Clear()`| Remove todos os elementos da lista.|
|`Contains(T item)`| Verifica se um elemento específico do tipo T está presente na lista.| 

### Métodos Find da List < T >

*Predicate < T >* é um delegado que representa um método que define um conjunto de critérios e determina se o objeto especificado atende a esses critérios. Ele é frequentemente usado em métodos de pesquisa e filtragem em coleções, como `List<T>`, para encontrar elementos que correspondem a certas condições. <br>
Normalmente utiliza-se uma expressão lambda para definir o critério de pesquisa.

|Método|Definição|
|-------|----------|
|`Find(Predicate<T> match)`| Retorna o primeiro elemento que corresponde às condições definidas pelo predicado especificado.|
|`FindAll(Predicate<T> match)`| Retorna todos os elementos que correspondem às condições definidas pelo predicado especificado.|
|`FindIndex(Predicate<T> match)`| Retorna o índice do primeiro elemento que corresponde às condições definidas pelo predicado especificado.|
|`FindLast(Predicate<T> match)`| Retorna o último elemento que corresponde às condições definidas pelo predicado especificado.|
|`FindLastIndex(Predicate<T> match)`| Retorna o índice do último elemento que corresponde às condições definidas pelo predicado especificado.|

### Exemplo de Uso do List < T >
```csharp
List<string> listaConvidados = new();

do
{
    Console.Write("Deseja adicionar um convidado (S / N) ? ");
    string resposta = Console.ReadLine();
    if (resposta?.ToUpper() == "S")
    {
        Console.Write("Nome do convidado: ");
        string nome = Console.ReadLine();
        listaConvidados.Add(nome);
    }
} while (resposta?.ToUpper() != "N");

Console.WriteLine("\nLista de Convidados:");
foreach (string convidado in listaConvidados)
{
    Console.WriteLine($" - {convidado}");
}
```