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