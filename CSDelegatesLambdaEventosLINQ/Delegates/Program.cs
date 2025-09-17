using Delegates;

var resultado = Calculadora.Somar(10, 40);

Console.WriteLine(resultado);

DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);  //Primeiro método de atribuição do delegate ao método
resultado = calc.Invoke(50, 10);        //Para utilizar o método atribuído ao delegate, pode-se utilizar o método Invoke()
Console.WriteLine(resultado);


calc = Calculadora.Subtrair;    //Segundo método de atribuição de método ao delegate
resultado = calc.Invoke(50, 10);
Console.WriteLine(resultado);

calc = (float x,  float y) => Calculadora.Multiplicar(x, y);    //Terceiro método de atribuição do método ao delegate
resultado = calc(5, 10);    //Forma alternativo do método de invocação do delegate
Console.WriteLine(resultado);


Console.Read();

//A declaração do delegate deve estar fora do método main
public delegate float DelegateCalculadora(float x, float y);