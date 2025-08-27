using Indexadores;

Time time = new();
time[1] = "Gremio";
time[3] = "Internacional";
time[5] = "Juventude";
time[7] = "Atletico";
time[-1] = "Bahia";

string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);

Console.Read();