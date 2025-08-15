using Montadora;

var carro1 = new Carro("Sedan", "Chevrolet");
var carro2 = new Carro("SUV", "Ford");

Console.WriteLine($"Modelo do Carro 1 : {carro1.modelo}");
Console.WriteLine($"Montadora do Carro 1 : {carro1.montadora}");
Console.WriteLine($"Modelo do Carro 2 : {carro2.modelo}");
Console.WriteLine($"Montadora do Carro 2 : {carro2.montadora}");


var carro3 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
carro3.ExibirInformacoes(carro3);
Console.WriteLine($"Velocidade Máxima do Carro 3 :{carro3.VelocidadeMaxima(carro3)}");
Console.ReadLine();
