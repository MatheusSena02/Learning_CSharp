# Generics e Cole��es Gen�ricas

## Generics

Generics possibilitam o design de classes e m�todos que adiam a especifica��o de um ou mais par�metros de tipo at� que voc� use a classe ou o m�todo em seu c�digo. Por exemplo, ao usar um par�metro de tipo gen�rico T, voc� pode escrever uma �nica classe que outro c�digo de cliente pode usar sem incorrer o custo ou risco de convers�es de runtime ou opera��es de convers�o boxing. <br>

- Generics permitem a inclus�o de mais de um par�metro de tipos;
- � poss�vel definir restri��es nos tipos gen�ricos, utilizando o operador `where`;


## GetHashCode e Equals

Tratam-se de m�todo da classe `Object` que s�o usadas para comparar se dois objetos s�o iguais. Todos os objetos na linguagem C# herdam de `Object`, assim herdando os m�todos `GetHashCode` e `Equals` <br>
**Nos tipos definidos pelo usu�rio � necess�rio sobrescrever os m�todos `GetHashCode` e `Equals` para garantir a igualdade entre dois objetos do tipo seja avaliada de forma correta.***

### GetHashCode

Retorna um valor inteiro (*c�digo hash*) com base nas informa��es do objeto (*estado do objeto*). <br> Objetos diferentes sempre v�o gerar um n�mero diferente para `GetHashCode`, entretanto, c�digos *hash* iguais **n�o significam que os objetos s�o iguais**, pois podem existir objetos diferentes que podem ter os mesmos c�digos *hash*

### Equals

O m�todo Equals por padr�o verifica a igualdade de refer�ncia, n�o a igualdade de conte�do. Isso significa que ele compara se duas vari�veis de refer�ncia apontam para o mesmo objeto na mem�ria. <br>
Basicamente, ele retorna `true` caso as vari�veis apontem para **A MESMA REFER�NCIA DO OBJETO**, n�o necessariamente se forem objetos do mesmo tipo.

### Estrat�gia de compara��o entre os objetos

1. Utiliza o m�todo `GetHashCode` para localizar os objetos e verificar se possuem o mesmo c�digo hash, em fun��o do m�todo `GetHashCode` ser mais r�pido que o `Equals`
2. Confirmar a igualdade dos objetos usando o m�todo `Equals`

## Cole��oes Gen�ricas e N�o Gen�ricas

### N�o Gen�ricas 

- As classes das cole��es n�o gen�ricas armazenam os dados do tipo `Object`;
- Fazem a convers�o impl�cita dos tipos de dados para `Object`;
- Realizam as opera��es de `boxing` ao incluir e `unboxing` ao retirar um elemento da cole��o;
- S�o mais suscet�veis a exce��es em tempo de execu��o devido a incompatibilidade entre tipos;

### Gen�ricas

- S�o fortemente tipadas (*armazenam apenas um tipo de objeto*), evitando erros de incompatibilidade de tipo;
- N�o realizam as opera��es de `boxing` e `unboxing` oferecendo um melhor desempenho;
- Facilitam a reutiliza��o de c�digo;


## Dictionary<TKey, TValue>

O `Dictionary<TKey, TValue>` � uma cole��o gen�rica presente no namespace `System.Collections.Generic` que armazena pares de chave/valor.  
Cada **chave** (`TKey`) deve ser �nica, e � usada para acessar rapidamente o **valor** (`TValue`) correspondente.  
Internamente, o `Dictionary` � implementado como uma **tabela hash**, garantindo buscas e inser��es r�pidas (O(1) em m�dia).

---

### Principais M�todos e Propriedades

| M�todo/Propriedade | Descri��o |
|---------------------|-----------|
| `Add(TKey key, TValue value)` | Adiciona um novo par chave/valor ao dicion�rio. Lan�a exce��o se a chave j� existir. |
| `TryAdd(TKey key, TValue value)` | Tenta adicionar um par chave/valor. Retorna `true` se conseguir, `false` se a chave j� existir (sem exce��o). |
| `Remove(TKey key)` | Remove o elemento com a chave especificada. Retorna `true` se conseguiu remover. |
| `Clear()` | Remove todos os pares chave/valor do dicion�rio. |
| `ContainsKey(TKey key)` | Verifica se o dicion�rio cont�m a chave especificada. |
| `ContainsValue(TValue value)` | Verifica se existe um valor espec�fico no dicion�rio. |
| `TryGetValue(TKey key, out TValue value)` | Tenta obter o valor associado a uma chave sem lan�ar exce��o caso ela n�o exista. |
| `Keys` | Propriedade que retorna uma cole��o (`KeyCollection`) com todas as chaves. |
| `Values` | Propriedade que retorna uma cole��o (`ValueCollection`) com todos os valores. |
| `Count` | Retorna o n�mero total de pares armazenados. |
| `Item[TKey key]` (indexador) | Permite acessar ou definir o valor associado a uma chave, usando `dict[key]`. |
| `EnsureCapacity(int capacity)` | Garante que o dicion�rio possa armazenar pelo menos a capacidade especificada sem redimensionar. |
| `TrimExcess()` | Reduz a capacidade interna do dicion�rio para o n�mero real de elementos armazenados. |
| `CopyTo(KeyValuePair<TKey,TValue>[] array, int index)` | Copia os elementos do dicion�rio para um array de `KeyValuePair` a partir de um �ndice. |
| `GetEnumerator()` | Retorna um enumerador que itera pelos pares chave/valor do dicion�rio. |

## SortedDictionary < TKey, TValue >

� semelhante � cole��o `Dictionary < T >`, sendo uma cole��o gen�rica que armazena seus dados no formato `chave/valor`, mas fazendo isso de forma ordenada pelas suas chaves. <br>
Em suma, assemelha-se � classe `Dictionary < T >`, com a diferen�a de que ocorre a ordena��o dos valores pela sua chave nas listas.

## Cole��es Set

### HashSet 

� uma cole��o gen�rica **n�o ordenada** que implementa a interface `ISet<T>` e representa um conjunto de itens exclusivos (*n�o permite a inclus�o de elementos duplicados*). <br> Funciona semelhantemente � uma tabela *hash*, mas n�o se trata de uma cole��o do tipo `chave/valor`, pois a chave � atribu�da ao elemento pelo pr�prio compilador. E a ordem dos elementos pode mudar a depender das opera��es realizadas.

|M�todo|Defini��o|
|-------|--------|
|Count|Retorna o n�mero de elementos no HashSet|
|Comparer|Retorna o objeto `IEqualityComparer<T>` que � usado para determinar a igualdade dos elementos no HashSet|

#### HashSet < T > (Inumerable < T >) 

� poss�vel passar listas e cole��es como argumento durante a cria��o de uma cole��o `HashSet`, consequentemente os elementos da cole��o passadas no argumento ser�o alocadas na nova tabela `HashSet`.

### SortedSet

Comporta-se de maneira semelhante � HashSet, mas com a principal diferen�a de que trata-se de uma cole��o gen�ricas **ordenada**, pois a classe implementa a interface `IComparer<T>` que garante que todos os elementos no objeto estejam na ordem correta.

|M�todo|Defini��o|
|-------|--------|
|Count|Retorna o n�mero de elementos no HashSet|
|Comparer|Retorna o objeto `IEqualityComparer<T>` que � usado para determinar a igualdade dos elementos no HashSet|
|Min|Obt�m o valor m�nino no `SortedSet<T>`, conforme definido pelo compilador|
|Max|Obt�m o valor m�ximo no `SortedSet<T>`, conforme definido pelo compilador|

## Cole��es ReadOnly

S�o estruturas de dados que permite que os dados sejam acessados, mas n�o modificados. Existem diversas classes do tipo `ReadOnly`, que limitam o acesso das cole��es para apenas leituras, podendo ler `cole��es/arrays`, `List<T>`, `Dictionary<T>`, entre outros.

### ReadOnlyCollection< T >

Fornece a classe base para uma cole��o somente leitura gen�rica, sendo criada a partir de uma cole��o mut�vel, como `Array` e `List`.

|M�todos|Defini��o|
|---------|-------|
|Contains (T item)| Determina se um elemento est� na cole��o|
|CopyTo(T[] array, int arrayIndex)|Copia os elementos da cole��o para um Array unidimensional compat�vel, come�ando no �ndoce espec�fico do array de destino|
|GetEnumerator()| Retorna um enumerador que itera pela cole��o|
|IndexOf(T item)| Pesquisa o objeto especificado e retorna o �ndice baseado em zero da primeira ocorr�ncia em toda a cole��o|

#### M�todos de convers�o ReadOnly

- `Construtor` :
```csharp
var planetas = new List<string>() {"Merc�rio, "V�nus", "Terra", "Marte"};
var listaPlanetas = new ReadOnlycollection<string>(planetas);
### Passa uma lista, que � convertida para ReadOnlyCollection
```

- `.AsReadOnly()`: Retorna um inv�lucro `ReadOnlyCollection<T>` somente leitura para a cole��o atual.
```csharp
var planetas = new List<string>() {"Merc�rio, "V�nus", "Terra", "Marte"};
var novaLista = planetas.AsReadOnly();
```