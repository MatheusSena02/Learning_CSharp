//É possível passar arrays como parâmetros para métodos, quando se deseja trabalhar com uma grande quantidade de parâmetros por exemplo

int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine($"Método sem params : {resultado}");

resultado = Calcular.Soma(1, 4, 5 ,6 ,8); //O método params permite que passemos uma lista de valores
Console.WriteLine($"Método com params : {resultado}");

Console.Read(); 

public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach(int i in numeros)
        {
            total += i;
        }
        return total;
    }

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
}
