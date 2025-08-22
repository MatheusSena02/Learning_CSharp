using Class1;

MinhaPartial partialClass = new();
Console.WriteLine($"Idade : {partialClass.CalculaIdade(new DateTime(2003, 8, 7))}");
Console.WriteLine($"Idade : {partialClass.DiferencaEntreDatas(new DateTime(2003, 8, 7), new DateTime(2003, 1, 2))}");

Console.Read();