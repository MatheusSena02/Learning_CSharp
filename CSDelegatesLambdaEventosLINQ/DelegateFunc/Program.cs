Console.Write("Digite um número: ");
double numero = Convert.ToInt32(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);

double resultado = raizQuadrada(numero);

Console.WriteLine($"\nA raiz quadrada do {numero} é {resultado}");

Console.Read();