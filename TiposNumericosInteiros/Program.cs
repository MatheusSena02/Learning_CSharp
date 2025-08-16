//Declaração de variáveis numéricas inteiras em C# 

sbyte valorSByte = 127; // Valor mínimo para sbyte
byte valorByte = 255;
short valorShort = 32767;
ushort valorUShort = 65535;
int valorInt = 2147483647;

/*
Tabela de tipos numéricos inteiros em C#:   
sbyte : -128 a 127	
byte  : 0 a 255	
short : -32.768 a 32.767	
ushort : 0 a 65.535	
int	 : -2.147.483.648 a 2.147.483.647	
uint : 0 a 4.294.967.295	
long : -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
ulong : 0 a 18.446.744.073.709.551.615	
nint : Depende da plataforma (computado em tempo de execução)	
nuint : Depende da plataforma (computada em tempo de execução)
 */


Console.WriteLine($"Valor máximo do tipo numérico sbyte : {valorSByte}");
Console.WriteLine($"Valor máximo do tipo numérico byte : {valorByte}");
Console.WriteLine($"Valor máximo do tipo numérico short : {valorShort}");
Console.WriteLine($"Valor máximo do tipo numérico ushort : {valorUShort}");
Console.WriteLine($"Valor máximo do tipo numérico int : {valorInt}");


