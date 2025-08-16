
Console.Write("Digite seu nome : ");
string nomeUsuario = Console.ReadLine();
Console.Write("Digite sua idade : ");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nome do usuário : " + nomeUsuario + "\nIdade do Usuário : " + idadeUsuario);
Console.WriteLine();

//Exercício para calcular a distância entre dois pontos (com foco em utilizar a class Math)
double x1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double xFinal = x2 - x1;
double yFinal = y2 - y1;
double resultado = Math.Sqrt(Math.Pow(xFinal, 2) + Math.Pow(yFinal, 2));
Console.WriteLine(Math.Round(resultado));
Console.ReadKey();