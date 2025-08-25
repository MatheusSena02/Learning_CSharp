# Array, ArrayList e List

## Passagem de Arrays como Argumento 

Quando surge a necessidade de passar uma grande quantidade de dados para um m�todo, pode-se utilizar um array. <br>
Para isso, bastaria indicar a espera de um array como par�metro do m�todo.

```csharp

int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine($"M�todo sem params : {resultado}");

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

O modificador `params` permite que voc� passe um n�mero vari�vel de argumentos para um m�todo, sem a necessidade de criar um array explicitamente, mas listando os valores a serem passados de maneira semelhante � uma array. Isso � �til quando voc� n�o sabe quantos argumentos ser�o passados para o m�todo. O par�metro `params` deve ser o �ltimo par�metro do m�todo, podendo ser usado apenas e pode ser usado com arrays ou tipos primitivos.
```csharp
public static int Soma(params double[] numeros)
    {
        //O m�todo params permite que se passe um lista de valores no argumento, com formata��o semelhante � de uma array
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }
```

## Arrays Multidimensionais

Arrays multidimensionais s�o arrays que possuem mais de uma dimens�o, permitindo armazenar dados em uma estrutura de tabela ou matriz. Em C#, voc� pode criar arrays multidimensionais adicionando v�rgulas entre os colchetes, equivalente ao n�mero de dimens�es que voc� deseja adicionar.

```csharp
int[,] matriz = new int[3, 3]; // Cria uma matriz bidimensional 3x3
int[,,] cubo = new int[3, 3, 3]; // Cria um array tridimensional 3x3x3
```

### Fun��o GetLength(n)

A fun��o `GetLength(n)` retorna o tamanho da dimens�o especificada do array. O par�metro `n` � um �ndice baseado em zero que indica qual dimens�o voc� deseja obter o tamanho. <br>
Se n for '0', a fun��o retornar� o tamanho da primeira dimens�o; se n for '1', retornar� o tamanho da segunda dimens�o, e assim por diante.


### Arrays Bidimensionais

Os arrays bidimensionais s�o uma forma de armazenar dados em uma tabela com linhas e colunas. Em C#, voc� pode acessar os elementos de um array bidimensional usando dois �ndices: um para a linha e outro para a coluna.

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


