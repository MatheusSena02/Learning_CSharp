# Array, ArrayList e List

## Passagem de Arrays como Argumento 

Quando surge a necessidade de passar uma grande quantidade de dados para um m�todo, pode-se utilizar um array. <br>
Para isso, bastaria indicar a espera de um array como par�metro do m�todo.

```csharp

int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine($"M�todo sem params : {resultado}");

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

O modificador `params` permite que voc� passe um n�mero vari�vel de argumentos para um m�todo, sem a necessidade de criar um array explicitamente, mas listando os valores a serem passados de maneira semelhante � uma array. Isso � �til quando voc� n�o sabe quantos argumentos ser�o passados para o m�todo. O par�metro `params` deve ser o �ltimo par�metro do m�todo, podendo ser usado apenas e pode ser usado com arrays ou tipos primitivos.
```csharp
public static int Soma(params double[] numeros)
    {
        //O m�todo params permite que se passe um lista de valores no argumento, com formata��o semelhante � de uma array
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

## Arrays Multidimensionais

Arrays multidimensionais s�o arrays que possuem mais de uma dimens�o, permitindo armazenar dados em uma estrutura de tabela ou matriz. Em C#, voc� pode criar arrays multidimensionais adicionando v�rgulas entre os colchetes, equivalente ao n�mero de dimens�es que voc� deseja adicionar.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
int[,,] cubo = new int[3, 3, 3]; // Cria um array tridimensional 3x3x3
```

### Fun��o GetLength(n)

A fun��o `GetLength(n)` retorna o tamanho da dimens�o especificada do array. O par�metro `n` � um �ndice baseado em zero que indica qual dimens�o voc� deseja obter o tamanho. <br>
Se n for '0', a fun��o retornar� o tamanho da primeira dimens�o; se n for '1', retornar� o tamanho da segunda dimens�o, e assim por diante.


### Arrays Bidimensionais

Os arrays bidimensionais s�o uma forma de armazenar dados em uma tabela com linhas e colunas. Em C#, voc� pode acessar os elementos de um array bidimensional usando dois �ndices: um para a linha e outro para a coluna.

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

A classe `ArrayList` � uma cole��o cuja o tamanho pode ser alterado dinamicamente e que pode armazenar elementos de qualquer tipo, pois armazena os elementos como objetos do tipo `object`. Isso significa que voc� pode adicionar diferentes tipos de dados em um �nico `ArrayList` e que o tamanho do `ArrayList` pode crescer ou diminuir conforme a adi��o ou retirada de elementos.

|M�todos|Defini��o|
|-------|----------|
|`Count`| Propriedade que retorna o n�mero atual de elementos na cole��o|
|`Capacity`| Propriedade que retorna ou define a capacidade atual do ArrayList.|
|`Add(object value)`| M�todo que adiciona um elemento ao final do ArrayList.|
|`Remove(object value)`| M�todo que remove a primeira ocorr�ncia de um elemento espec�fico do ArrayList.|
|`Insert(int index, object value)`| M�todo que insere um elemento em uma posi��o espec�fica do ArrayList.|
|`Clear()`| M�todo que remove todos os elementos do ArrayList.|
|`Contains(object value)`| M�todo que verifica se um elemento espec�fico est� presente no ArrayList.|
|`IndexOf(object value)`| M�todo que retorna o �ndice da primeira ocorr�ncia de um elemento espec�fico no ArrayList.|
|`Sort()`| M�todo que ordena os elementos do ArrayList em ordem crescente.|
|`ToArray()`| M�todo que converte o ArrayList em um array.|
|`TrimToSize()`| M�todo que ajusta a capacidade do ArrayList para o n�mero atual de elementos, liberando mem�ria n�o utilizada.|
|`Clone()`| M�todo que cria uma c�pia superficial do ArrayList.|
|`GetRange(int index, int count)`| M�todo que retorna uma sublista do ArrayList, come�ando no �ndice especificado e contendo o n�mero especificado de elementos.|
|`Reverse()`| M�todo que inverte a ordem dos elementos no ArrayList.|

```csharp
//M�todo usando inicializa��o de cole��o (Collection Initializer)
var lista = new ArrayList() 
{
    "Paulo", 4.5, 10, true, 'A', "Texto"
};

//M�todo usando Add()
ArrayList lista = new ArrayList(); //Count = 0 e Capacity = 0
lista.Add("Texto"); //Count = 1 e Capacity = 4
lista.Add(123); //Count = 2 e Capacity = 4
lista.Add(true); //Count = 3 e Capacity = 4
```

#### Construtores ArrayList 

- `ArrayList()`: Cria um ArrayList vazio com capacidade inicial padr�o;
- `ArrayList(int capacidadeInicial)`: Cria um ArrayList vazio com a capacidade inicial especificada;
- `ArrayList(ICollection colecao)`: Cria um ArrayList que cont�m os elementos da cole��o especificada.

### Adi��o de Elementos

|M�todo|Defini��o|
|-------|----------|
|`Add(object value)`| Adiciona um elemento ao final do ArrayList.|
|`AddRange(ICollection c)`| Adiciona os elementos de uma cole��o ao final do Arra yList.|
|`Insert(int index, object value)`| Insere um elemento em uma posi��o espec�fica do ArrayList.|
|`InsertRange(int index, ICollection c)`| Insere os elementos de uma cole��o em uma posi��o espec�fica do ArrayList.|

### Remo��o de Elementos

|M�todo|Defini��o|
|-------|----------|
|`Remove(object value)`| Remove a primeira ocorr�ncia de um elemento espec�fico do ArrayList.|
|`RemoveAt(int index)`| Remove o elemento na posi��o especificada do ArrayList.|
|`RemoveRange(int index, int count)`| Remove um intervalo de elementos do ArrayList, come�ando no �ndice especificado e removendo o n�mero especificado de elementos.|
|`Clear()`| Remove todos os elementos do ArrayList. Sem alterar sua capacidade (Count - 0)|

### Acesso e Pesquisa de Elementos

|M�todo|Defini��o|
|-------|----------|
|`Contains(object value)`| Verifica se um elemento espec�fico est� presente no ArrayList.|
|`IndexOf(object value)`| Retorna o �ndice da primeira ocorr�ncia de um elemento espec�fico no ArrayList.|
|`LastIndexOf(object value)`| Retorna o �ndice da �ltima ocorr�ncia de um elemento espec�fico no ArrayList.|
|`GetRange(int index, int count)`| Retorna uma sublista do ArrayList, come�ando no �ndice especificado e contendo o n�mero especificado de elementos.|
|`ToArray()`| Converte o ArrayList em um array.|
|`ToArray(Type tipo)`| Converte o ArrayList em um array do tipo especificado.|
|`Clone()`| Cria uma c�pia superficial do ArrayList.|

### Ordena��o e Manipula��o

|M�todo|Defini��o|
|-------|----------|
|`Sort()`| Ordena os elementos do ArrayList em ordem crescente (desde que os elementos sejam do mesmo tipo).|
|`Reverse()`| Inverte a ordem dos elementos no ArrayList.|
|`TrimToSize()`| Ajusta a capacidade do ArrayList para o n�mero atual de elementos, liberando mem�ria n�o utilizada.|
|`SetRange(int index, ICollection c)`| Substitui um intervalo de elementos no ArrayList, come�ando no �ndice especificado, pelos elementos da cole��o especificada.|
|`BinarySearch(object value)`| Realiza uma busca bin�ria por um elemento espec�fico no ArrayList. O ArrayList deve estar ordenado para que a busca funcione corretamente.|

## Cole��o List < T >

A classe `List<T>` � uma cole��o gen�rica que armazena elementos de um tipo espec�fico, definido pelo par�metro de tipo `T`. Diferente do `ArrayList`, que armazena elementos como objetos do tipo `object`, o `List<T>` oferece melhor desempenho e seguran�a de tipo, pois todos os elementos na lista s�o do mesmo tipo. Al�m disso, o `List<T>` tamb�m permite que voc� defina a capacidade inicial da lista e pode crescer dinamicamente conforme voc� adiciona mais elementos.

### Por que usar List<T> ao inv�s de ArrayList?

- **Seguran�a de Tipo**: Com `List<T>`, voc� especifica o tipo de elementos que a lista pode conter, o que ajuda a evitar erros de tempo de execu��o relacionados a tipos incompat�veis. Com `ArrayList`, voc� pode adicionar qualquer tipo de objeto, o que pode levar a erros se voc� tentar acessar um elemento como um tipo diferente do que ele realmente �.
- **Desempenho**: `List<T>` geralmente oferece melhor desempenho do que `ArrayList`, especialmente quando se trata de opera��es que envolvem muitos elementos, porque evita a necessidade de convers�es de tipo (boxing e unboxing) que ocorrem com `ArrayList`.

### M�todos de List < T >

Os m�todos dispon�veis na classe `List<T>` s�o semelhantes aos do `ArrayList`, mas com a vantagem de serem fortemente tipados. Por exemplo : 

|M�todo|Defini��o|
|-------|----------|
|`Add(T item)`| Adiciona um elemento do tipo T ao final da lista.|
|`AddRange(IEnumerable<T> collection)`| Adiciona os elementos de uma cole��o ao final da lista.|
|`Insert(int index, T item)`| Insere um elemento do tipo T em uma posi��o espec�fica da lista.|
|`InsertRange(int index, IEnumerable<T> collection)`| Insere os elementos de uma cole��o em uma posi��o espec�fica da lista.|
|`Remove(T item)`| Remove a primeira ocorr�ncia de um elemento espec�fico do tipo T da lista.|
|`RemoveAt(int index)`| Remove o elemento na posi��o especificada da lista.|
|`RemoveRange(int index, int count)`| Remove um intervalo de elementos da lista, come�ando no �ndice especificado e removendo o n�mero especificado de elementos.|
|`Clear()`| Remove todos os elementos da lista.|
|`Contains(T item)`| Verifica se um elemento espec�fico do tipo T est� presente na lista.| 

### M�todos Find da List < T >

*Predicate < T >* � um delegado que representa um m�todo que define um conjunto de crit�rios e determina se o objeto especificado atende a esses crit�rios. Ele � frequentemente usado em m�todos de pesquisa e filtragem em cole��es, como `List<T>`, para encontrar elementos que correspondem a certas condi��es. <br>
Normalmente utiliza-se uma express�o lambda para definir o crit�rio de pesquisa.

|M�todo|Defini��o|
|-------|----------|
|`Find(Predicate<T> match)`| Retorna o primeiro elemento que corresponde �s condi��es definidas pelo predicado especificado.|
|`FindAll(Predicate<T> match)`| Retorna todos os elementos que correspondem �s condi��es definidas pelo predicado especificado.|
|`FindIndex(Predicate<T> match)`| Retorna o �ndice do primeiro elemento que corresponde �s condi��es definidas pelo predicado especificado.|
|`FindLast(Predicate<T> match)`| Retorna o �ltimo elemento que corresponde �s condi��es definidas pelo predicado especificado.|
|`FindLastIndex(Predicate<T> match)`| Retorna o �ndice do �ltimo elemento que corresponde �s condi��es definidas pelo predicado especificado.|

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

## IEnumerable   

IEnumerable � uma interface que define um m�todo para iterar sobre uma cole��o de um tipo espec�fico, permitindo a apenas leitura ("read-only") sequencial dos elementos. <br> IEnumerable possui um m�todo para retornar o pr�ximo item na cole��o, permitindo a execu��o sem a necessidade de ter toda a cole��o em mem�ria ou saber quantos itens h� nela. Ao usar IEnumerable, adiamos a execu��o das opera��es at� que sejam necess�rias. Isso significa que consultas ou opera��es de filtragem usando IEnumerable s� s�o executadas quando os resultados s�o acessados 

```csharp
// Suponha que temos uma cole��o de milh�es de itens
var numerosGrandes = ObterNumerosDoBancoDeDados(); // Retorna IEnumerable

// LINQ encadeado, mas NADA foi executado ainda!
var numerosPares = numerosGrandes.Where(n => n % 2 == 0);

// As opera��es (Where) s� s�o executadas AQUI, quando o foreach come�a.
foreach (var numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

- `var numerosGrandes = ObterNumerosDoBancoDeDados();` : Nesse ponto, o m�todo ObterNumerosDoBancoDeDados() n�o carrega todos os milh�es de n�meros na mem�ria de uma vez. Ele provavelmente retorna um IEnumerable que representa uma consulta ao banco de dados. <br> A "conex�o" ou a "instru��o" para buscar os dados � criada, mas a execu��o da busca ainda n�o come�ou.
- `var numerosPares = numerosGrandes.Where(n => n % 2 == 0);` : Aqui, a consulta LINQ � definida para filtrar os n�meros pares. No entanto, essa consulta ainda n�o foi executada. O que foi criado � uma express�o que descreve como obter os n�meros pares quando necess�rio.
- `foreach (var numero in numerosPares)` : A execu��o real da consulta ocorre quando o foreach come�a a iterar sobre numerosPares. Nesse momento, o LINQ executa a consulta no banco de dados, recupera os n�meros e aplica o filtro para obter apenas os n�meros pares. <br> Isso significa que os dados s�o processados "sob demanda", economizando mem�ria e melhorando o desempenho, especialmente quando se lida com grandes conjuntos de dados.



### List < T > e Principais m�todos de consultas LINQ

|M�todo|Defini��o|
|-------|----------|
|`Where(Func<T, bool> predicate)`| Filtra uma sequ�ncia de valores com base em um predicado.|
|`Any(Func<T, bool> predicate)`| Determina se qualquer elemento de uma sequ�ncia satisfaz uma condi��o.|
|`OrderBy<TKey>(Func<T, TKey> keySelector)`| Classifica os elementos de uma sequ�ncia em ordem crescente com base em uma chave.|
|`ToList()`| Converte uma sequ�ncia em uma lista.|
|`FirstOrDefault(Func<T, bool> predicate)`| Retorna o primeiro elemento de uma sequ�ncia que satisfaz uma condi��o ou um valor padr�o se nenhum elemento for encontrado.|

## Indexadores

Indexadores permitem que uma classe ou struct seja indexada como um array. Eles s�o definidos usando a palavra-chave `this` seguida por um ou mais par�metros entre colchetes. Indexadores s�o �teis quando voc� deseja fornecer acesso a elementos de uma cole��o interna de uma maneira semelhante � de um array, mas com a flexibilidade de encapsular a l�gica de acesso. <br>
O indexador � como um "atalho" que voc� programa para permitir que um �nico objeto se comporte como se fosse uma lista ou um dicion�rio.

## Classe Random

A classe `Random` em C# � usada para gerar n�meros pseudoaleat�rios. Ela faz parte do namespace `System` e oferece m�todos para gerar n�meros inteiros, n�meros de ponto flutuante e bytes aleat�rios. A gera��o de n�meros pseudoaleat�rios significa que os n�meros s�o gerados de maneira determin�stica com base em um valor inicial chamado semente (seed). Se voc� iniciar a classe `Random` com a mesma semente, ela gerar� a mesma sequ�ncia de n�meros aleat�rios.

|M�todo|Defini��o|
|-------|----------|    
|`Next()`| Retorna um n�mero inteiro aleat�rio n�o negativo.|
|`Next(int maxValue)`| Retorna um n�mero inteiro aleat�rio que � menor que o valor m�ximo especificado.|
|`Next(int minValue, int maxValue)`| Retorna um n�mero inteiro aleat�rio dentro de um intervalo especificado.|
|`NextDouble()`| Retorna um n�mero de ponto flutuante aleat�rio entre 0.0 e 1.0.|
|`NextBytes(byte[] buffer)`| Preenche um array de bytes com n�meros aleat�rios.|

|Metodo|Defini��o|
|-------|----------|
|`Random()`| Construtor que inicializa uma nova inst�ncia da classe Random usando uma semente baseada no rel�gio do sistema.|
|`Random(int seed)`| Construtor que inicializa uma nova inst�ncia da classe Random usando a semente especificada.|

```csharp
Random random = new Random(); // Inicializa com uma semente baseada no rel�gio do sistema
int numeroAleatorio = random.Next(1, 100); // Gera um n�mero aleat�rio entre 1 e 99
Console.WriteLine($"N�mero aleat�rio: {numeroAleatorio}");
```
