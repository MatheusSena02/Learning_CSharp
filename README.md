# Tratamento de Erros

## Tratamento de Excess�es

Consiste na adequa��o do c�digo para lidar com erros ou comportamentos inesperados dentro do c�digo; <br> Quando ocorre uma exce��o , ela � lan�ada da �rea do c�digo onde ocorreu o problema e passada para cima na *pilha de chamadas de m�todo*, quase como se retornasse para o m�todo anterior onde ocorreu o erro, repetindo esse comportamento at� ser tratada ou o programa ser encerrado. <br>
Os erros e exce��es na linguagem C# s�o derivadas da Classe `Exception`.

### `try-catch`

- O bloco `try` cont�m o c�digo que **pode lan�ar uma exce��o**.  
- O bloco `catch` cont�m o c�digo que **trata a exce��o** caso ela ocorra.

### Exemplo
```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numeros = { 1, 2, 3 };
            Console.WriteLine(numeros[5]); // �ndice inv�lido
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Erro: Tentativa de acessar posi��o inexistente no array.");
            Console.WriteLine($"Detalhes: {ex.Message}");
        }
    }
}
```

### `try-catch-fianally`

O bloco finally � opcional.

Ele � executado sempre, mesmo que:

- Uma exce��o tenha sido lan�ada e capturada;

- Nenhuma exce��o tenha ocorrido;

- Uma exce��o tenha sido lan�ada mas n�o capturada.

#### Quando usar o `finally` ? 

O finally � ideal para liberar recursos ou executar a��es de encerramento, como:

- Fechar arquivos;

- Encerrar conex�es de banco de dados;

- Liberar mem�ria de objetos n�o gerenciados;

- Mostrar mensagens de log indicando o t�rmino de uma opera��o.

## Exce��es da Classe Exception

## ?? Erros Gerais

- **Exception** � Classe base para todas as exce��es.

- **SystemException** � Classe base para exce��es do sistema em tempo de execu��o.

- **ApplicationException** � Usada para definir exce��es personalizadas de aplica��o.
 
---
 
### ?? Opera��es Num�ricas

- **DivideByZeroException** � Tentativa de dividir por zero.

- **OverflowException** � Resultado de opera��o num�rica excede o limite do tipo.

- **ArithmeticException** � Base para exce��es aritm�ticas.
 
---
 
### ?? Arquivos e Diret�rios

- **FileNotFoundException** � Arquivo n�o encontrado.

- **DirectoryNotFoundException** � Diret�rio n�o encontrado.

- **PathTooLongException** � Caminho excede o tamanho m�ximo permitido.

- **IOException** � Erros de entrada/sa�da gen�ricos.

- **EndOfStreamException** � Final inesperado de fluxo.
 
---
 
### ?? Argumentos e Valores Inv�lidos

- **ArgumentException** � Argumento inv�lido.

- **ArgumentNullException** � Argumento nulo passado indevidamente.

- **ArgumentOutOfRangeException** � Valor fora do intervalo permitido.

- **NullReferenceException** � Tentativa de acessar membro de objeto nulo.

- **InvalidOperationException** � Estado inv�lido do objeto para a opera��o.

- **FormatException** � Formato inv�lido em convers�o/parsing.
 
---
 
### ?? Cole��es e �ndices

- **IndexOutOfRangeException** � �ndice inv�lido em array ou cole��o.

- **KeyNotFoundException** � Chave n�o encontrada em dicion�rio.
 
---
 
### ?? Rede e Seguran�a

- **UnauthorizedAccessException** � Acesso n�o autorizado a recurso.

- **SecurityException** � Viola��o de seguran�a detectada.

- **WebException** � Erro relacionado a requisi��es HTTP/HTTPS.
 
---
 
### ?? Concorr�ncia e Threads

- **ThreadAbortException** � Thread foi abortada.

- **ThreadInterruptedException** � Thread interrompida durante espera.

- **SynchronizationLockException** � Erro ao usar locks incorretamente.
 
---
 
### ?? Outras Comuns

- **NotImplementedException** � M�todo ainda n�o implementado.

- **NotSupportedException** � Opera��o n�o suportada.

- **TimeoutException** � Opera��o excedeu tempo limite.

- **OutOfMemoryException** � Mem�ria insuficiente.

- **StackOverflowException** � Estouro de pilha (recurs�o infinita, por exemplo).
 
---
 
### ?? Observa��es

- Sempre que poss�vel, trate exce��es espec�ficas em vez de capturar apenas **`Exception`**.

- Para exce��es personalizadas, derive da classe **`ApplicationException`** ou diretamente de **`Exception`**.

## Lan�amento de Exce��es

� poss�vel lan�ar exce��es de maneira expl�cita e de maneira manual usando a instru��o `throw` seguida por uma inst�ncia de classe de exce��o como `Exception` ou uma de suas classes derivas.

```chsarp
# Exemplo b�sico
throw new Exception();

throw new Exception("Lan�amento manual de exce��o");
````

## Filtrando Exce��es

O recurso de `Exception Filters` permite executar blocos `try/catch` com base em uma condi��o espec�fica quando ocorre uma exce��o.<br
Um bloco `catch` ser� executado somente quando a condi��o for *verdadeira*. Caso contr�rio, o bloco `catch` � ignorado e o complicador procura o pr�ximo manipulador `catch`.

Podemos implementar este recurso adicionando a condi��o `when` junto com os blocos `catch`

```csharp
catch (Exception ex) when (ex.Message.Contains("format")) //Lan�a a exce��o se a mensagem de exce��o conter a palavra "format"
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("Erro de formata��o");
}
``` 

- **Se o par�metro oferecido para o operador `when` gerar uma exce��o, o operador ir� retornar *false* e o bloco catch n�o ser� executado**