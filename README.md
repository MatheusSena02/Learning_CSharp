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