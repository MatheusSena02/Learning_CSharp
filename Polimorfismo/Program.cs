using Polimorfismo;

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

Figura figura1 = new Circulo(); // "crie um círculo a partir da classe Circulo e guarde ele dentro de uma variável que é vista como uma Figura”.
//Cria uma instância do tipo da classe base que tem acesso às informãções de figura
figura1.Desenhar(); //Executa o método Desenhar da classe Circulo

Figura figura2 = new Triangulo();

foreach(var figura in figuras)
{
    figura.Desenhar();
}

Console.Read();