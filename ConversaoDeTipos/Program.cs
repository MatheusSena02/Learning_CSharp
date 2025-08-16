//Exemplo de conversão implícita 
int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble+"\n");

//Exemplo de conversão explícita
varDouble = 12.456;
varInt = (int)varDouble;
Console.WriteLine(varInt + "\n"); 

//Exemplo de conversão usando ToString()
int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.5678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3 + "\n");

//Exemplo de conversão usando os métodos da classe Convert
varInt = 10;
valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToDouble(varInt));
Console.WriteLine(Convert.ToInt16(valorDouble));
Console.WriteLine(Convert.ToString(valorBool));

Console.ReadLine();
