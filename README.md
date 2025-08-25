# Array, ArrayList e List

## Passagem de Arrays como Argumento 

Quando surge a necessidade de passar uma grande quantidade de dados para um método, pode-se utilizar um array. <br>
Para isso, bastaria indicar a espera de um array como parâmetro do método.

```csharp

int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine($"Método sem params : {resultado}");

public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach(int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

### Modificadores params

O modificador `params` permite que você passe um número variável de argumentos para um método, sem a necessidade de criar um array explicitamente, mas listando os valores a serem passados de maneira semelhante à uma array. Isso é útil quando você não sabe quantos argumentos serão passados para o método. O parâmetro `params` deve ser o último parâmetro do método, podendo ser usado apenas e pode ser usado com arrays ou tipos primitivos.
```csharp
public static int Soma(params double[] numeros)
    {
        //O método params permite que se passe um lista de valores no argumento, com formatação semelhante à de uma array
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

## Arrays Multidimensionais

Arrays multidimensionais são arrays que possuem mais de uma dimensão, permitindo armazenar dados em uma estrutura de tabela ou matriz. Em C#, você pode criar arrays multidimensionais adicionando vírgulas entre os colchetes, equivalente ao número de dimensões que você deseja adicionar.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
int[,,] cubo = new int[3, 3, 3]; // Cria um array tridimensional 3x3x3
```

### Função GetLength(n)

A função `GetLength(n)` retorna o tamanho da dimensão especificada do array. O parâmetro `n` é um índice baseado em zero que indica qual dimensão você deseja obter o tamanho. <br>
Se n for '0', a função retornará o tamanho da primeira dimensão; se n for '1', retornará o tamanho da segunda dimensão, e assim por diante.


### Arrays Bidimensionais

Os arrays bidimensionais são uma forma de armazenar dados em uma tabela com linhas e colunas. Em C#, você pode acessar os elementos de um array bidimensional usando dois índices: um para a linha e outro para a coluna.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 4;
matriz[1, 1] = 5;
matriz[1, 2] = 6;
matriz[2, 0] = 7;
matriz[2, 1] = 8;
matriz[2, 2] = 9;
```


