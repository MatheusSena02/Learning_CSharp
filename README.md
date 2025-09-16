# Tratamento de Erros

## Tratamento de Excessões

Consiste na adequação do código para lidar com erros ou comportamentos inesperados dentro do código; <br> Quando ocorre uma exceção , ela é lançada da área do código onde ocorreu o problema e passada para cima na *pilha de chamadas de método*, quase como se retornasse para o método anterior onde ocorreu o erro, repetindo esse comportamento até ser tratada ou o programa ser encerrado. <br>
Os erros e exceções na linguagem C# são derivadas da Classe `Exception`.

### `try-catch`

- O bloco `try` contém o código que **pode lançar uma exceção**.  
- O bloco `catch` contém o código que **trata a exceção** caso ela ocorra.

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
            Console.WriteLine(numeros[5]); // Índice inválido
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Erro: Tentativa de acessar posição inexistente no array.");
            Console.WriteLine($"Detalhes: {ex.Message}");
        }
    }
}
```

### `try-catch-fianally`

O bloco finally é opcional.

Ele é executado sempre, mesmo que:

- Uma exceção tenha sido lançada e capturada;

- Nenhuma exceção tenha ocorrido;

- Uma exceção tenha sido lançada mas não capturada.

#### Quando usar o `finally` ? 

O finally é ideal para liberar recursos ou executar ações de encerramento, como:

- Fechar arquivos;

- Encerrar conexões de banco de dados;

- Liberar memória de objetos não gerenciados;

- Mostrar mensagens de log indicando o término de uma operação.

## Exceções da Classe Exception

## ?? Erros Gerais

- **Exception** – Classe base para todas as exceções.

- **SystemException** – Classe base para exceções do sistema em tempo de execução.

- **ApplicationException** – Usada para definir exceções personalizadas de aplicação.
 
---
 
### ?? Operações Numéricas

- **DivideByZeroException** – Tentativa de dividir por zero.

- **OverflowException** – Resultado de operação numérica excede o limite do tipo.

- **ArithmeticException** – Base para exceções aritméticas.
 
---
 
### ?? Arquivos e Diretórios

- **FileNotFoundException** – Arquivo não encontrado.

- **DirectoryNotFoundException** – Diretório não encontrado.

- **PathTooLongException** – Caminho excede o tamanho máximo permitido.

- **IOException** – Erros de entrada/saída genéricos.

- **EndOfStreamException** – Final inesperado de fluxo.
 
---
 
### ?? Argumentos e Valores Inválidos

- **ArgumentException** – Argumento inválido.

- **ArgumentNullException** – Argumento nulo passado indevidamente.

- **ArgumentOutOfRangeException** – Valor fora do intervalo permitido.

- **NullReferenceException** – Tentativa de acessar membro de objeto nulo.

- **InvalidOperationException** – Estado inválido do objeto para a operação.

- **FormatException** – Formato inválido em conversão/parsing.
 
---
 
### ?? Coleções e Índices

- **IndexOutOfRangeException** – Índice inválido em array ou coleção.

- **KeyNotFoundException** – Chave não encontrada em dicionário.
 
---
 
### ?? Rede e Segurança

- **UnauthorizedAccessException** – Acesso não autorizado a recurso.

- **SecurityException** – Violação de segurança detectada.

- **WebException** – Erro relacionado a requisições HTTP/HTTPS.
 
---
 
### ?? Concorrência e Threads

- **ThreadAbortException** – Thread foi abortada.

- **ThreadInterruptedException** – Thread interrompida durante espera.

- **SynchronizationLockException** – Erro ao usar locks incorretamente.
 
---
 
### ?? Outras Comuns

- **NotImplementedException** – Método ainda não implementado.

- **NotSupportedException** – Operação não suportada.

- **TimeoutException** – Operação excedeu tempo limite.

- **OutOfMemoryException** – Memória insuficiente.

- **StackOverflowException** – Estouro de pilha (recursão infinita, por exemplo).
 
---
 
### ?? Observações

- Sempre que possível, trate exceções específicas em vez de capturar apenas **`Exception`**.

- Para exceções personalizadas, derive da classe **`ApplicationException`** ou diretamente de **`Exception`**.

## Lançamento de Exceções

É possível lançar exceções de maneira explícita e de maneira manual usando a instrução `throw` seguida por uma instância de classe de exceção como `Exception` ou uma de suas classes derivas.

```chsarp
# Exemplo básico
throw new Exception();

throw new Exception("Lançamento manual de exceção");
````

## Filtrando Exceções

O recurso de `Exception Filters` permite executar blocos `try/catch` com base em uma condição específica quando ocorre uma exceção.<br
Um bloco `catch` será executado somente quando a condição for *verdadeira*. Caso contrário, o bloco `catch` é ignorado e o complicador procura o próximo manipulador `catch`.

Podemos implementar este recurso adicionando a condição `when` junto com os blocos `catch`

```csharp
catch (Exception ex) when (ex.Message.Contains("format")) //Lança a exceção se a mensagem de exceção conter a palavra "format"
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("Erro de formatação");
}
``` 

- **Se o parâmetro oferecido para o operador `when` gerar uma exceção, o operador irá retornar *false* e o bloco catch não será executado**