# Delegates, Expressões Lambda, Eventos e LINQ

## Delegates (SingleCast Delegate)

Trata-se de um tipo de dado, assim como `int`, `string`, `bool`, dentre outros, mas `delegates` representam referências a métodos com uma *lista de parâmetros* e um *tipo de retorno*.<br>
Ao instanciar um `delegate`, podemos associar a sua instância a qualquer método com uma **assinatura compatível e tipo de retorno**, podemos invocar o método por meio da instância delegada. <br>

Comumente a declaração de um `delegate` segue a seguinte estrutura :

|modificador de acesso| delegate |tipo de retorno| nome do delegate | (parâmetros)|
|--------------------|---------|---------------|-------------------|---------------|

## Multicast Delegates

Tratam-se de `Delegates` que possuem capacidade de encapsular mais de uma referência de método em um único `Delegate`. <br> Quando invocamos o `multicast delegate`, todos os métodos referenciados pelo delegate serão invocados em ordem. Portanto, todos os métodos atribuídos precisam ter a mesma assinatura. <br> Para adicionar método a um `Delegate`, utilizado-se o nome do `Delegate` em questão, seguido do operador `+=` e o nome do método a ser atribuído. Para retirar, repete-se o processo, mas usando o operador `-=`

### Executar um método em específico usando `Multicast Delegate`

Existem dois principais métodos para acessar métodos individuais dentro de um `Multicast Delegate` : Usando `GetInvocationList()` ou `DynamicInvoke()`.

- `GetInvocationList()` : Retorna a lista de invocação do `Delegate`;
- `DynamicInvoke()` : Invoca um método representado por um `Delegate` em tempo de execução, em vez de tempo de compilação;-

```csharo

foreach(var handler in d.GetInvocationList())
{
	handler.DynamicInvoke();	//Executa um por vez
}

var apenasB = d.GetInvocationList()[1];
apenasB.DynamicInvoke();	//Executa só o método B
```

## Métodos Anônimos 

Trata-se de uma função que não possui nome e que pode ser definida usando a palavra-chave `delegate` e pode ser atribuída a uma variável do tip o`delegate`. <br>
Uma função anônima é uma declaração *in-line* ou expressão que pode ser usada sempre que um tipo de `delegate` for esperado. 

## Expressões Lambda 

Trata-se de uma *função anônima* que pode ser usada para criar `delegates` pu expressões de árvores de expressão; É uma maneira mais curta de representa um *método anônimo* usando uma sintaxe especial, chamada de *sugar sintax*. <br>  Semelhantemente aos métodos anônimos, são usados para escrever métodos *in-line* simples e rápidos

|Parâmetro de entrada)|Operador *Lmabda*|Expressão ou Bloco de Instrução|Resultado|
|---------------------|-----------------|-------------------------------|---------|
|	(string x)        |		= >         |  x * x                        |Retorna x²|

**Na expressão Lambda, o compilador infere o *tipo de parâmetro* e o *tipo de retorno* com base no contexto**

```csharp
lista.FindIndex(nome => nome.Contains("Lucas"));
//O método espera receber um predicado e retornar um bool, como se trata de uma lista de nomes, o compilador já infere o tipo como uma string
```

## Delegates Pré-Definidas

A linguagem C# possui delegates pré-definifos que podem ser utilizados para passar referências a métodos como arugmentos para outros métodos. Funcionam como funções nativas, mas no contexto do `delegate`, são `delegates` nativos que podem ser usados livremente.

#### Predicate < T >

Represente um método que define um conjunto de critérios e determina se o objeto específico satisfaz a condição. <br> Recebe um único argumento de entrada do tipo T e retorna um valor booleano. Comumente utilizado para operações de filtragem de informações.

- Estrutura do Delegate Predicate < T >

|public|delegate|bool|Predicate < T >| (T obj)|
|--------------|---------|---------|-----------|


### Action < T >

Representa um método que não retorna um valor (`void`), mas pode receber até **16 argmentos** de entrada. É útil para representar um método que executa ação, sem retornar nenhum valor.

|public|delegate|void|Action < T >| (T obj)|
|--------------|---------|---------|-----------|

```chsarp
Action<string> imprimir = texto => Console.WriteLine(texto);
imprimir("Hello World");
````

## Delegate Func 

Representa um método que encapsula método que pode possuir de 0 a 16 parâmetros e que tem um tipo de retorno.

|public|delegate|TResult|Func < Tn >| (Tn argn obj)|
|--------------|---------|---------|-----------|
 
 ```csharp
 Func<double, double> quadrado = x => x * 2;
//Recebe um double e retorna um double (int T e out TResult)

double resultado = quadrado(5.0);

Console.WriteLine(resultado) //25;
```

## Eventos

Os eventos permitem que uma classe ou objeto notifique outras classes ou objetos quando algo de interesse ocorrer. A classe que envia (ou gera) o evento é chamada de *publiser* e as classes que recebem (ou manipulam) o evento são chamadas de *subscribers*. <br> Em um aplicativo Web ou Windows Forms em C# típico, você assina eventos gerados por controles como botões e caixas de listagem. 

- O editor determina quando um evento é gerado; os assinantes determinam qual ação é tomada em resposta ao evento.
- Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários publicadores.
- Eventos que não têm assinantes nunca são acionados.
- Os eventos normalmente são usados para sinalizar ações do usuário, como cliques de botão ou seleções de menu em interfaces gráficas do usuário.
- Quando um evento tem vários assinantes, os manipuladores de eventos são invocados de forma síncrona quando um evento é acionado. Para invocar eventos de forma assíncrona, consulte chamando métodos síncronos de forma assíncrona.
- Na biblioteca de classes do .NET, os eventos são baseados no delegado EventHandler e na classe base EventArgs.

**Basicamente, o *publisher* determina quando um evento é acionado. Os *subscribers* determinam a ação que é executada em resposta ao evento**.

## Delegates pré-definidos

### EventHandler

Representa um método que vai manipular um evento que não possui dados, ou seja, o evento não precisa passar dados extras além do rementente (*sender*). 

### EventHandler < TEventArgs >

Representa um método que vai manipular um evento que possui dados, ou seja, o evento pode passar dados extras além do rementente (*sender*). <br> Será necessário definir uma classe que herda da classe `EventArgs` e armazena os dados que desejamos passar na classe.

## Métodos de Extensão

Os membros da extensão permitem que você "adicione" métodos aos tipos existentes sem criar um novo tipo derivado, recompilar ou modificar o tipo original, permitindo com que se estenda a funcionalidade de um tipo existente.<br> Os blocos de extensão dão suporte a vários tipos de membro: métodos, propriedades e operadores. Com blocos de extensão, você pode definir extensões de instância e extensões estáticas. As extensões de instância estendem uma instância do tipo; Extensões estáticas estendem o tipo em si. A forma de métodos de extensão declarada com o modificador this dá suporte a métodos de extensão de instância.

Métodos de extensão são métodos estáticos, mas são chamados como se fossem métodos de instância no tipo estendido.                       

**São muito usados juntamente com a LINQ, pois permite criar métodos que permitem com que determinados tipos, que originalmente não poderiam trabalhar com a LINQ, agora consigam incrementar funcionalidades do tipo**

## LINQ

Language-Integrated Query (LINQ) é o nome de um conjunto de tecnologias com base na integração de recursos de consulta diretamente na linguagem C#. Tradicionalmente, as consultas em relação aos dados são expressas como cadeias de caracteres simples sem verificação de tipo em tempo de compilação ou suporte do IntelliSense. <br> Além disso, a LINQ inibe a necessidade de aprender uma linguagem de consultas diferentes para cada cenário.

- As expressões de consulta consultam e transformam dados de qualquer fonte de dados habilitada para LINQ. Por exemplo, uma única consulta pode recuperar dados de um banco de dados SQL e produzir um fluxo XML como saída. 
- As expressões de consulta usam muitos constructos de linguagem C# familiares, o que os torna fáceis de ler. As variáveis em uma expressão de consulta são todas fortemente tipadas. 
- Uma consulta não é executada até que você itere sobre a variável de consulta, por exemplo, em uma instrução foreach. 
- No tempo de compilação, as expressões de consulta são convertidas em chamadas de método de operador de consulta padrão de acordo com as regras definidas na especificação C#. Qualquer consulta que possa ser expressa usando a sintaxe de consulta também pode ser expressa usando a sintaxe do método. Em alguns casos, a sintaxe de consulta é mais legível e concisa. Em outros, a sintaxe do método é mais legível. Não há diferença semântica ou de desempenho entre as duas formas diferentes. Para obter mais informações, consulte a especificação da linguagem C# e a visão geral dos operadores de consulta Standard. 
- Algumas operações de consulta, como Count ou Max, não têm cláusula de expressão de consulta equivalente e, portanto, devem ser expressas como uma chamada de método. A sintaxe do método pode ser combinada com a sintaxe de consulta de várias maneiras. 
- As expressões de consulta podem ser compiladas para árvores de expressão ou delegados, dependendo do tipo ao qual a consulta é aplicada. As consultas IEnumerable< T > são compiladas para representantes. As consultas IQueryable e IQueryable < T > são compiladas para árvores de expressão. Para obter mais informações, consulte Árvores de expressão.

### Deffered Execution (Execução Adiada)

É o método de execução da consultas LINQ, em que a avaliação de uma expressão é postergada áté que seu valor realizado seja realmente necessário (*foreach*, Count, Sum,...). <br> 
Basicamente, a operação somente ocorrerá quando houver a iteração.

### Esquema básico de consultas

1. Definir a fonte de dados;
2. Definir a consulta LINQ (como filtragem, ordenação, agrupamento, etc);
3. Executar a consulta;

### Implementação da LINQ

As consultas LINQ usam *métodos de extensão* para classes que implementam a interface `Inumerable` ou `IQueryable`, isso permite com que seja possível chamar qualquer método LINQ em qualquer objeto que implemente algum desses dois. <br> As classes e interfaces da LINQ estão presentes no namespace `System.Linq`. 

- `IEnumerable` : Comumente base para coleções que podem ser iteradas/percorridas, como `List<T>`, `ArrayList<T>`, `Dictionary`;
- `IQueryable` : Representa coleções de objetos que podem ser consultados usando fontes de dados externa, como um banco de dados;

## Consultas LINQ

