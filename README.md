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