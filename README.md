# Generics e Coleções Genéricas

## Generics

Generics possibilitam o design de classes e métodos que adiam a especificação de um ou mais parâmetros de tipo até que você use a classe ou o método em seu código. Por exemplo, ao usar um parâmetro de tipo genérico T, você pode escrever uma única classe que outro código de cliente pode usar sem incorrer o custo ou risco de conversões de runtime ou operações de conversão boxing. <br>

- Generics permitem a inclusão de mais de um parâmetro de tipos;
- É possível definir restrições nos tipos genéricos, utilizando o operador `where`;


## GetHashCode e Equals

Tratam-se de método da classe `Object` que são usadas para comparar se dois objetos são iguais. Todos os objetos na linguagem C# herdam de `Object`, assim herdando os métodos `GetHashCode` e `Equals` <br>
**Nos tipos definidos pelo usuário é necessário sobrescrever os métodos `GetHashCode` e `Equals` para garantir a igualdade entre dois objetos do tipo seja avaliada de forma correta.***

### GetHashCode

Retorna um valor inteiro (*código hash*) com base nas informações do objeto (*estado do objeto*). <br> Objetos diferentes sempre vão gerar um número diferente para `GetHashCode`, entretanto, códigos *hash* iguais **não significam que os objetos são iguais**, pois podem existir objetos diferentes que podem ter os mesmos códigos *hash*

### Equals

O método Equals por padrão verifica a igualdade de referência, não a igualdade de conteúdo. Isso significa que ele compara se duas variáveis de referência apontam para o mesmo objeto na memória. <br>
Basicamente, ele retorna `true` caso as variáveis apontem para **A MESMA REFERÊNCIA DO OBJETO**, não necessariamente se forem objetos do mesmo tipo.

### Estratégia de comparação entre os objetos

1. Utiliza o método `GetHashCode` para localizar os objetos e verificar se possuem o mesmo código hash, em função do método `GetHashCode` ser mais rápido que o `Equals`
2. Confirmar a igualdade dos objetos usando o método `Equals`

## Coleçãoes Genéricas e Não Genéricas

### Não Genéricas 

- As classes das coleções não genéricas armazenam os dados do tipo `Object`;
- Fazem a conversão implícita dos tipos de dados para `Object`;
- Realizam as operações de `boxing` ao incluir e `unboxing` ao retirar um elemento da coleção;
- São mais suscetíveis a exceções em tempo de execução devido a incompatibilidade entre tipos;

### Genéricas

- São fortemente tipadas (*armazenam apenas um tipo de objeto*), evitando erros de incompatibilidade de tipo;
- Não realizam as operações de `boxing` e `unboxing` oferecendo um melhor desempenho;
- Facilitam a reutilização de código;


## Dictionary<TKey, TValue>

O `Dictionary<TKey, TValue>` é uma coleção genérica presente no namespace `System.Collections.Generic` que armazena pares de chave/valor.  
Cada **chave** (`TKey`) deve ser única, e é usada para acessar rapidamente o **valor** (`TValue`) correspondente.  
Internamente, o `Dictionary` é implementado como uma **tabela hash**, garantindo buscas e inserções rápidas (O(1) em média).

---

### Principais Métodos e Propriedades

| Método/Propriedade | Descrição |
|---------------------|-----------|
| `Add(TKey key, TValue value)` | Adiciona um novo par chave/valor ao dicionário. Lança exceção se a chave já existir. |
| `TryAdd(TKey key, TValue value)` | Tenta adicionar um par chave/valor. Retorna `true` se conseguir, `false` se a chave já existir (sem exceção). |
| `Remove(TKey key)` | Remove o elemento com a chave especificada. Retorna `true` se conseguiu remover. |
| `Clear()` | Remove todos os pares chave/valor do dicionário. |
| `ContainsKey(TKey key)` | Verifica se o dicionário contém a chave especificada. |
| `ContainsValue(TValue value)` | Verifica se existe um valor específico no dicionário. |
| `TryGetValue(TKey key, out TValue value)` | Tenta obter o valor associado a uma chave sem lançar exceção caso ela não exista. |
| `Keys` | Propriedade que retorna uma coleção (`KeyCollection`) com todas as chaves. |
| `Values` | Propriedade que retorna uma coleção (`ValueCollection`) com todos os valores. |
| `Count` | Retorna o número total de pares armazenados. |
| `Item[TKey key]` (indexador) | Permite acessar ou definir o valor associado a uma chave, usando `dict[key]`. |
| `EnsureCapacity(int capacity)` | Garante que o dicionário possa armazenar pelo menos a capacidade especificada sem redimensionar. |
| `TrimExcess()` | Reduz a capacidade interna do dicionário para o número real de elementos armazenados. |
| `CopyTo(KeyValuePair<TKey,TValue>[] array, int index)` | Copia os elementos do dicionário para um array de `KeyValuePair` a partir de um índice. |
| `GetEnumerator()` | Retorna um enumerador que itera pelos pares chave/valor do dicionário. |

## SortedDictionary < TKey, TValue >

É semelhante à coleção `Dictionary < T >`, sendo uma coleção genérica que armazena seus dados no formato `chave/valor`, mas fazendo isso de forma ordenada pelas suas chaves. <br>
Em suma, assemelha-se à classe `Dictionary < T >`, com a diferença de que ocorre a ordenação dos valores pela sua chave nas listas.

## Coleções Set

### HashSet 

É uma coleção genérica **não ordenada** que implementa a interface `ISet<T>` e representa um conjunto de itens exclusivos (*não permite a inclusão de elementos duplicados*). <br> Funciona semelhantemente à uma tabela *hash*, mas não se trata de uma coleção do tipo `chave/valor`, pois a chave é atribuída ao elemento pelo próprio compilador. E a ordem dos elementos pode mudar a depender das operações realizadas.

|Método|Definição|
|-------|--------|
|Count|Retorna o número de elementos no HashSet|
|Comparer|Retorna o objeto `IEqualityComparer<T>` que é usado para determinar a igualdade dos elementos no HashSet|

#### HashSet < T > (Inumerable < T >) 

É possível passar listas e coleções como argumento durante a criação de uma coleção `HashSet`, consequentemente os elementos da coleção passadas no argumento serão alocadas na nova tabela `HashSet`.

### SortedSet

Comporta-se de maneira semelhante à HashSet, mas com a principal diferença de que trata-se de uma coleção genéricas **ordenada**, pois a classe implementa a interface `IComparer<T>` que garante que todos os elementos no objeto estejam na ordem correta.

|Método|Definição|
|-------|--------|
|Count|Retorna o número de elementos no HashSet|
|Comparer|Retorna o objeto `IEqualityComparer<T>` que é usado para determinar a igualdade dos elementos no HashSet|
|Min|Obtém o valor mínino no `SortedSet<T>`, conforme definido pelo compilador|
|Max|Obtém o valor máximo no `SortedSet<T>`, conforme definido pelo compilador|

## Coleções ReadOnly

São estruturas de dados que permite que os dados sejam acessados, mas não modificados. Existem diversas classes do tipo `ReadOnly`, que limitam o acesso das coleções para apenas leituras, podendo ler `coleções/arrays`, `List<T>`, `Dictionary<T>`, entre outros.

### ReadOnlyCollection< T >

Fornece a classe base para uma coleção somente leitura genérica, sendo criada a partir de uma coleção mutável, como `Array` e `List`.

|Métodos|Definição|
|---------|-------|
|Contains (T item)| Determina se um elemento está na coleção|
|CopyTo(T[] array, int arrayIndex)|Copia os elementos da coleção para um Array unidimensional compatível, começando no índoce específico do array de destino|
|GetEnumerator()| Retorna um enumerador que itera pela coleção|
|IndexOf(T item)| Pesquisa o objeto especificado e retorna o índice baseado em zero da primeira ocorrência em toda a coleção|

#### Métodos de conversão ReadOnly

- `Construtor` :
```csharp
var planetas = new List<string>() {"Mercúrio, "Vênus", "Terra", "Marte"};
var listaPlanetas = new ReadOnlycollection<string>(planetas);
### Passa uma lista, que é convertida para ReadOnlyCollection
```

- `.AsReadOnly()`: Retorna um invólucro `ReadOnlyCollection<T>` somente leitura para a coleção atual.
```csharp
var planetas = new List<string>() {"Mercúrio, "Vênus", "Terra", "Marte"};
var novaLista = planetas.AsReadOnly();
```