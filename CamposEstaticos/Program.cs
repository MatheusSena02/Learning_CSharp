using CamposEstaticos;

Class1.Juros = 4.25f;

Class1 c1 = new Class1();
c1.Conta = 101;
c1.Nome = "Maria";

Class1 c2 = new();
c2.Conta = 102;
c2.Nome = "Pedro";

Console.WriteLine($"Cliente {c1.Nome} - Juros Anual : {c1.JurosAnual()}");
Console.WriteLine($"Cliente {c2.Nome} - Juros Anual : {c2.JurosAnual()}");



Console.Read();