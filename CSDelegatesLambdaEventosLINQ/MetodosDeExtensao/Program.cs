using MetodosDeExtensao;

string texto = "Texto original antes de ser invertido";

Console.WriteLine(texto);
Console.WriteLine();

string textoInvertido = texto.InverteString();  //Agora o método aparece como um método nativo do tipo string

Console.WriteLine(textoInvertido);

Console.Read();