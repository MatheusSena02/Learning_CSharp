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