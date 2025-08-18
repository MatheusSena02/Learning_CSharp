using MedidasCirculares;

Console.WriteLine("Informações do Círculo");
Console.Write("Digite o raio do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da Circunferência : {circunferencia}");
Console.WriteLine($"Área da Circunferência : {area}");
//Permite que a variável 'area' seja usada fora do método 'CalculaAreaPerimetro'.

Console.ReadKey();