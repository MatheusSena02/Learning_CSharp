Console.Write("Informe a temperatura : ");
var temperatura = Convert.ToDouble(Console.ReadLine());

var resultado = temperatura >= 27 ? "Quente" : "Normal";
//Se a temperatura for maior ou igual a 27, o resultado será "Quente", caso contrário, será "Normal".
Console.WriteLine("A temperatura está " + resultado);

//Aninhamento de operadores ternários
resultado = temperatura >= 27 ? "Quente" : temperatura < 18 ? "Frio" : "Normal";
Console.WriteLine("A temperatura está " + resultado);
//Nesse caso, se a temperatura for maior ou igual a 27, o resultado será "Quente". Se for menor que 18, será "Frio". Caso contrário, será "Normal".
Console.ReadLine();