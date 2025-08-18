using Montadora;

//Exemplo de Argumentos Nomeados
var carro3 = new Carro(modelo : "Sedan", marca: "Chevrolet", montadora: "Onix", ano: 2016, potencia: 110);
carro3.ExibirInformacoes(veiculo : carro3);
Console.WriteLine($"Velocidade Máxima do Carro 3 :{carro3.VelocidadeMaxima(veiculo : carro3)}");
Console.WriteLine($"Potência atualizada do Carro 3 (+3): {carro3.AumentarPotencia(potencia : carro3.potencia)}");
Console.WriteLine($"Potência atualizada do Carro 3 (+5): {carro3.AumentarPotencia(potencia : ref carro3.potencia)}");

Console.ReadLine();