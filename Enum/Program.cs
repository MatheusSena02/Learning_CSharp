using Enum;

Console.WriteLine(DiasDaSemana.Segunda);
//Exibe o "nome" do atributo do Enum
Console.WriteLine((int)DiasDaSemana.Segunda);
//Exibe o "valor" do atributo do Enum

int dia = (int)DiasDaSemana.Domingo;
Console.WriteLine($"{DiasDaSemana.Domingo} vale {dia}\n");

int diaPar = (int)DiasPares.Domingo;
Console.WriteLine($"{DiasPares.Domingo} vale {diaPar}\n");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}\n");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}\n");

//Método de painel de seleção 
Console.WriteLine("_________________________________________________________");
Console.WriteLine("| 1 - Cadastrar cliente|   4 -         Sacar            |");
Console.WriteLine("| 2 - Consultar saldo  | 5 - Consultar dados do cliente |");
Console.WriteLine("| 3 -   Depositar      | 6 -           Sair             |");
Console.WriteLine("_________________________________________________________");
Console.Write("                 Digite a opção desejada: ");
int opcao = Convert.ToInt32(Console.ReadLine());

var opcaoSelecionada = (Banco)opcao; //Nesse caso, ocorre o "casting" de int para o Enum Banco
Console.WriteLine($"Opção selecionada foi {opcaoSelecionada.ToString()}");

Console.ReadLine(); 