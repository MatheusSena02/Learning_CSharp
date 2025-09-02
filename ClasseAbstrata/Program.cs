using ClasseAbstrata;

Quadrado bolaQuico = new();
Console.WriteLine(bolaQuico.Descrição());

bolaQuico.Lado = 2;
Console.WriteLine($"Valor da Área: {bolaQuico.CalcularArea()}");
Console.WriteLine($"Valor do Perímetro: {bolaQuico.CalcularPerimetro()}");

Console.Read();