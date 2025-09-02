using ExercicioHeranca;

Conta cliente1 = new("Matheus");
cliente1.ExibirSaldo();
cliente1.Depositar(250.50m);
cliente1.ExibirSaldo();
cliente1.Sacar(50.25m);
cliente1.ExibirSaldo();

Investimentos cliente2 = new("Miranda");
cliente2.ExibirSaldo();
cliente2.Depositar(250.50m);
cliente2.ExibirSaldo();
cliente2.Sacar(50.25m);
cliente2.ExibirSaldo();

Investimentos cliente3 = new ("Marcos");
cliente3.ExibirSaldo();
cliente3.Depositar(250.50m);
cliente3.ExibirSaldo();
cliente3.Sacar(50.25m);
cliente3.ExibirSaldo();

Console.Read();