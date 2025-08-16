using System.Runtime.CompilerServices;

const int ANO = 2025; //Declaração padrão de constantes (Seguindo o Pascal Case)

const int MES = 30, SEMANA = 7, DIA = 15; //Declaração de múltiplas constantes na mesma linha

const int MESES_ANO = 12;
const int DIAS_ANO = 365; 
const float DIAS_MES = (float)DIAS_ANO / MESES_ANO; //Declaração de constantes com tipo explícito
 
//Cálculo da Área e Perímetro de um Círculo

const double PI = Math.PI;
double raioCirculo, perimetroCirculo, areaCirculo;
Console.Write("Informe o raio do círculo : ");
raioCirculo = Convert.ToDouble(Console.ReadLine());
perimetroCirculo = 2 * PI * raioCirculo; //Cálculo do Perímetro
areaCirculo = PI * Math.Pow(raioCirculo, 2); //Cálculo da Área
Console.WriteLine("Perímetro do Círculo : " + perimetroCirculo.ToString("F") + "\nÁrea do Círculo : " + areaCirculo.ToString("F"));
Console.ReadKey();  