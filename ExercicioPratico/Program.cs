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
Console.WriteLine($"Potência atualizada do Carro 3 (+3): {carro3.AumentarPotencia(carro3.potencia)}");
Console.WriteLine($"Potência atualizada do Carro 3 (+5): {carro3.AumentarPotencia(ref carro3.potencia)}");

Carro novaVelocidadePotencia = new("Sedan", "Chevrolet", "Onix", 2016, 110);
novaVelocidadePotencia.AumentaPotenciaVelocidade(novaVelocidadePotencia, out double velocidade);
Console.WriteLine($"Velocidade do Carro 3 : {velocidade}");
Console.WriteLine($"Potência atualizada do Carro 3 (+7): {novaVelocidadePotencia.potencia}");
Console.ReadLine();
