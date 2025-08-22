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