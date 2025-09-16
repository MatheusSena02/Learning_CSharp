using ExcecoesPersonalizadas;

try
{
    Conta conta1 = new Conta(100, "João", 100m);
    Console.WriteLine(conta1.ToString());
    Console.WriteLine(conta1.Depositar(100));
    Console.WriteLine(conta1.Sacar(1000));
}catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.Read();

public class Conta
{
    public int Numero {  get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if(Saldo < valor)
        {
            throw new SaldoInsuficienteException(valor, Saldo);
        }
        Saldo -= valor;
        return Saldo;
    }

    public override string ToString()   //O método ToString() é um método virtual, ou seja, permite sobrescrever o método
    {
        return $"Conta: {Numero} : {Titular} - Saldo = {Saldo}";
    }

}