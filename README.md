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