using Montadora;

Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro carro2 = new("SUV", "Ford", "EcoSport", 2018, 120);

carro1.ExibirInformacoes(carro1);
carro1.Acelerar();

carro2.ExibirInformacoes(carro2);
carro2.Acelerar();

Console.ReadLine();