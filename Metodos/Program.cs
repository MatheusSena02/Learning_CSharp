//Declaração de Métodos em uma clase

CadastroBancario cliente = new CadastroBancario();
cliente.inicializacaoDoServico();


class CadastroBancario
{
    string? nomeDoTitular;
    double saldo;
    string? numeroDaConta;
    string? agencia;
    char? opcao;

    public void inicializacaoDoServico()
    {
        do
        {
            opcaoDoUsuario();
            painelDeControle();
        } while (true);
    }
    public void opcaoDoUsuario()    //O modificador "public" permite que o método seja acessado de fora da classe.
    {
        Console.WriteLine("_________________________________________________________");
        Console.WriteLine("| 1 - Cadastrar cliente|   4 -         Sacar            |");
        Console.WriteLine("| 2 - Consultar saldo  | 5 - Consultar dados do cliente |");
        Console.WriteLine("| 3 -   Depositar      | 6 -           Sair             |");
        Console.WriteLine("_________________________________________________________");
        Console.Write("                 Digite a opção desejada: ");
        opcao = Convert.ToChar(Console.ReadLine());
    }

    public void painelDeControle()
    {
        switch (opcao)
        {
            case '1':
                cadastrarCliente();
                break;
            case '2':
                consultarSaldo();
                break;
            case '3':
                depositar();
                break;
            case '4':
                sacar();
                break;
            case '5':
                consultarDadosDaConta();
                break;
            case '6':
                sair();
                break;
            default:
                Console.WriteLine("Nenhuma das opções são válidas");
                break;
        }
    }

    public void cadastrarCliente()
    {
        Console.Write("\nDigite o nome do titular: ");
        nomeDoTitular = Console.ReadLine();
        saldo = 0.0;
        Random rnd = new Random();
        numeroDaConta = Convert.ToString(rnd.Next(00001, 99999));
        agencia = Convert.ToString(rnd.Next(0001, 9999));
    }

    public void depositar()
    {
        Console.Write("Digite o valor do depósito: ");
        double valorDeposito = Convert.ToDouble(Console.ReadLine());
        if(valorDeposito > 0)
        {
            Console.WriteLine("Não foi possível realizar o depósito. Valor não compatível");
        }
        saldo += valorDeposito;
    }

    public void sacar()
    {
        Console.Write("Digite o valor de retirada : ");
        double valorRetirada = Convert.ToDouble(Console.ReadLine());
        if(valorRetirada > saldo)
        {
            Console.WriteLine("Não foi possível completar a operação. Saldo indisponível");
        }else if(valorRetirada < 0)
        {
            Console.WriteLine("Não foi possível completar a operação. Operação inválida");
        }
        saldo -= valorRetirada;
    }

    public void consultarSaldo()
    {
        Console.WriteLine($"Saldo Atual : {saldo}");
    }
    public void consultarDadosDaConta()
    {
        Console.WriteLine($"Nome do titular : {nomeDoTitular}");
        Console.WriteLine($"Número da conta : {numeroDaConta}");
        Console.WriteLine($"Número da agência : {agencia}");
    }

    public void sair()
    {
        Environment.Exit(0);
    }
}
