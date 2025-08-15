//Utilizando Sobrecarga de Métodos

using SobrecargaDeMetodos;

var email = new Email();
email.Enviar("Avenida Dorivam Caymi");
email.Enviar("Avenida Dorivam Caymi", "Congestionamento");
email.Enviar("Avenida Dorivam Caymi", 10.250m);

var resultado = email.Enviar("Hotel Plaza", 1000, 520.60m);
Console.WriteLine(resultado);
Console.ReadLine();