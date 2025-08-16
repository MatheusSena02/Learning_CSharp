string nome = null; 
Console.WriteLine(nome);
//Nesse caso, o compilador emite um alerta, porém não impede a execução do código.

string sobrenome = null;
//Console.WriteLine(sobrenome.ToUpper());
//Nesse caso, o compilador emite um alerta, pois o método ToUpper() não pode ser chamado em uma variável que pode ser null.

string? ultimoNome = null; // Usando o operador de interrogação para indicar que a variável pode ser null
Console.WriteLine(nome?.ToUpper()); //O operador ?. avalia a operação, caso nome não seja null, ele chama o método ToUpper(). Caso contrário, ele retorna null
//Nesse caso, o operador de interrogação evita o erro de referência nula, e o resultado será null se nome for null.

Console.ReadLine(); 