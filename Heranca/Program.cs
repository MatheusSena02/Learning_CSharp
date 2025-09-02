using Banco;

Funcionario gestorLeandro = new("Leandro", "leandro@email.com", "1234-5678", "Masculino", 30, "Rua A, 123", "Microsoft", "Gerente", 8000.00m);
gestorLeandro.MostrarDados();

Funcionario estagiarioMatheus = new("Matheus", "matheus@gmail.com", 21);
estagiarioMatheus.MostrarDados();

Cliente cliente1 = new("Átila", "atilapj@gmail.com", "(71) 9 8265947", "Indefinido", 28, "Rua dos Cocais - Brotas");
cliente1.MostrarDados();

Console.Read();