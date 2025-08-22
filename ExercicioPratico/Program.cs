using Montadora;
using CarroEnum;

int corEscolhida;
var carro1 = new Carro("Sedan", "Chevrolet");
var carro2 = new Carro("SUV", "Ford");

Console.WriteLine($"Modelo do Carro 1 : {carro1.Modelo}");
Console.WriteLine($"Montadora do Carro 1 : {carro1.Montadora}");
Console.WriteLine($"Modelo do Carro 2 : {carro2.Modelo}");
Console.WriteLine($"Montadora do Carro 2 : {carro2.Montadora}");

corEscolhida = Carro.ExibirCores();
var carro3 = new Carro("Sedan", "Chevrolet", "Onix", 1985, 110, corEscolhida);
carro3.ExibirInformacoes(carro3.Modelo, carro3.Montadora, carro3.Marca, carro3.Potencia, carro3.Ano, corEscolhida);
carro3.ExibirInformacoes(carro3.Modelo, carro3.Montadora, carro3.Marca, carro3.Potencia, carro3.Ano);
Console.WriteLine($"Velocidade Máxima do Carro 3 :{carro3.VelocidadeMaxima(carro3)}");
Console.WriteLine($"Potência atualizada do Carro 3 (+3): {carro3.AumentarPotencia(carro3.Potencia)}");
Console.WriteLine($"Potência atualizada do Carro 3 (+5): {carro3.AumentarPotencia(ref carro3.Potencia)}");
Console.WriteLine();


corEscolhida = Carro.ExibirCores();
Carro novaVelocidadePotencia = new("Sedan", "Chevrolet", "Onix", 2050, 110, corEscolhida);
novaVelocidadePotencia.ExibirInformacoes(novaVelocidadePotencia.Modelo, novaVelocidadePotencia.Montadora, novaVelocidadePotencia.Marca, novaVelocidadePotencia.Potencia, novaVelocidadePotencia.Ano);
novaVelocidadePotencia.AumentaPotenciaVelocidade(novaVelocidadePotencia, out double velocidade);
Console.WriteLine($"Velocidade do Carro 3 : {velocidade}");
Console.WriteLine($"Potência atualizada do Carro 3 (+7): {novaVelocidadePotencia.Potencia}");

Console.WriteLine($"Valor do IPVA : {Carro.ValorIpva}");
Console.ReadLine();
