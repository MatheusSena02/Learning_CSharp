# Delegates, Express�es Lambda, Eventos e LINQ

## Delegates (SingleCast Delegate)

Trata-se de um tipo de dado, assim como `int`, `string`, `bool`, dentre outros, mas `delegates` representam refer�ncias a m�todos com uma *lista de par�metros* e um *tipo de retorno*.<br>
Ao instanciar um `delegate`, podemos associar a sua inst�ncia a qualquer m�todo com uma **assinatura compat�vel e tipo de retorno**, podemos invocar o m�todo por meio da inst�ncia delegada. <br>

Comumente a declara��o de um `delegate` segue a seguinte estrutura :

|modificador de acesso| delegate |tipo de retorno| nome do delegate | (par�metros)|
|--------------------|---------|---------------|-------------------|---------------|

## Multicast Delegates

Tratam-se de `Delegates` que possuem capacidade de encapsular mais de uma refer�ncia de m�todo em um �nico `Delegate`. <br> Quando invocamos o `multicast delegate`, todos os m�todos referenciados pelo delegate ser�o invocados em ordem. Portanto, todos os m�todos atribu�dos precisam ter a mesma assinatura. <br> Para adicionar m�todo a um `Delegate`, utilizado-se o nome do `Delegate` em quest�o, seguido do operador `+=` e o nome do m�todo a ser atribu�do. Para retirar, repete-se o processo, mas usando o operador `-=`

### Executar um m�todo em espec�fico usando `Multicast Delegate`

Existem dois principais m�todos para acessar m�todos individuais dentro de um `Multicast Delegate` : Usando `GetInvocationList()` ou `DynamicInvoke()`.

- `GetInvocationList()` : Retorna a lista de invoca��o do `Delegate`;
- `DynamicInvoke()` : Invoca um m�todo representado por um `Delegate` em tempo de execu��o, em vez de tempo de compila��o;-

```csharo

foreach(var handler in d.GetInvocationList())
{
	handler.DynamicInvoke();	//Executa um por vez
}

var apenasB = d.GetInvocationList()[1];
apenasB.DynamicInvoke();	//Executa s� o m�todo B
```

## M�todos An�nimos 

Trata-se de uma fun��o que n�o possui nome e que pode ser definida usando a palavra-chave `delegate` e pode ser atribu�da a uma vari�vel do tip o`delegate`. <br>
Uma fun��o an�nima � uma declara��o *in-line* ou express�o que pode ser usada sempre que um tipo de `delegate` for esperado. 

## Express�es Lambda 

Trata-se de uma *fun��o an�nima* que pode ser usada para criar `delegates` pu express�es de �rvores de express�o; � uma maneira mais curta de representa um *m�todo an�nimo* usando uma sintaxe especial, chamada de *sugar sintax*. <br>  Semelhantemente aos m�todos an�nimos, s�o usados para escrever m�todos *in-line* simples e r�pidos

|Par�metro de entrada)|Operador *Lmabda*|Express�o ou Bloco de Instru��o|Resultado|
|---------------------|-----------------|-------------------------------|---------|
|	(string x)        |		= >         |  x * x                        |Retorna x�|

**Na express�o Lambda, o compilador infere o *tipo de par�metro* e o *tipo de retorno* com base no contexto**

```csharp
lista.FindIndex(nome => nome.Contains("Lucas"));
//O m�todo espera receber um predicado e retornar um bool, como se trata de uma lista de nomes, o compilador j� infere o tipo como uma string
```

## Delegates Pr�-Definidas

A linguagem C# possui delegates pr�-definifos que podem ser utilizados para passar refer�ncias a m�todos como arugmentos para outros m�todos. Funcionam como fun��es nativas, mas no contexto do `delegate`, s�o `delegates` nativos que podem ser usados livremente.

#### Predicate < T >

Represente um m�todo que define um conjunto de crit�rios e determina se o objeto espec�fico satisfaz a condi��o. <br> Recebe um �nico argumento de entrada do tipo T e retorna um valor booleano. Comumente utilizado para opera��es de filtragem de informa��es.

- Estrutura do Delegate Predicate < T >

|public|delegate|bool|Predicate < T >| (T obj)|
|--------------|---------|---------|-----------|


### Action < T >

Representa um m�todo que n�o retorna um valor (`void`), mas pode receber at� **16 argmentos** de entrada. � �til para representar um m�todo que executa a��o, sem retornar nenhum valor.

|public|delegate|void|Action < T >| (T obj)|
|--------------|---------|---------|-----------|

```chsarp
Action<string> imprimir = texto => Console.WriteLine(texto);
imprimir("Hello World");
````

## Delegate Func 

Representa um m�todo que encapsula m�todo que pode possuir de 0 a 16 par�metros e que tem um tipo de retorno.

|public|delegate|TResult|Func < Tn >| (Tn argn obj)|
|--------------|---------|---------|-----------|
 
 ```csharp
 Func<double, double> quadrado = x => x * 2;
//Recebe um double e retorna um double (int T e out TResult)

double resultado = quadrado(5.0);

Console.WriteLine(resultado) //25;
```

## Eventos

Os eventos permitem que uma classe ou objeto notifique outras classes ou objetos quando algo de interesse ocorrer. A classe que envia (ou gera) o evento � chamada de *publiser* e as classes que recebem (ou manipulam) o evento s�o chamadas de *subscribers*. <br> Em um aplicativo Web ou Windows Forms em C# t�pico, voc� assina eventos gerados por controles como bot�es e caixas de listagem. 

- O editor determina quando um evento � gerado; os assinantes determinam qual a��o � tomada em resposta ao evento.
- Um evento pode ter v�rios assinantes. Um assinante pode manipular v�rios eventos de v�rios publicadores.
- Eventos que n�o t�m assinantes nunca s�o acionados.
- Os eventos normalmente s�o usados para sinalizar a��es do usu�rio, como cliques de bot�o ou sele��es de menu em interfaces gr�ficas do usu�rio.
- Quando um evento tem v�rios assinantes, os manipuladores de eventos s�o invocados de forma s�ncrona quando um evento � acionado. Para invocar eventos de forma ass�ncrona, consulte chamando m�todos s�ncronos de forma ass�ncrona.
- Na biblioteca de classes do .NET, os eventos s�o baseados no delegado EventHandler e na classe base EventArgs.

**Basicamente, o *publisher* determina quando um evento � acionado. Os *subscribers* determinam a a��o que � executada em resposta ao evento**.

## Delegates pr�-definidos

### EventHandler

Representa um m�todo que vai manipular um evento que n�o possui dados, ou seja, o evento n�o precisa passar dados extras al�m do rementente (*sender*). 

### EventHandler < TEventArgs >

Representa um m�todo que vai manipular um evento que possui dados, ou seja, o evento pode passar dados extras al�m do rementente (*sender*). <br> Ser� necess�rio definir uma classe que herda da classe `EventArgs` e armazena os dados que desejamos passar na classe.

## M�todos de Extens�o

Os membros da extens�o permitem que voc� "adicione" m�todos aos tipos existentes sem criar um novo tipo derivado, recompilar ou modificar o tipo original, permitindo com que se estenda a funcionalidade de um tipo existente.<br> Os blocos de extens�o d�o suporte a v�rios tipos de membro: m�todos, propriedades e operadores. Com blocos de extens�o, voc� pode definir extens�es de inst�ncia e extens�es est�ticas. As extens�es de inst�ncia estendem uma inst�ncia do tipo; Extens�es est�ticas estendem o tipo em si. A forma de m�todos de extens�o declarada com o modificador this d� suporte a m�todos de extens�o de inst�ncia.

M�todos de extens�o s�o m�todos est�ticos, mas s�o chamados como se fossem m�todos de inst�ncia no tipo estendido.                       

**S�o muito usados juntamente com a LINQ, pois permite criar m�todos que permitem com que determinados tipos, que originalmente n�o poderiam trabalhar com a LINQ, agora consigam incrementar funcionalidades do tipo**