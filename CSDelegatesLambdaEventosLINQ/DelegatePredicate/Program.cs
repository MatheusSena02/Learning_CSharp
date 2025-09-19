Console.Write("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

DelegatePar delegatePar = VerificaPar;

Predicate <int> delegatePredicatePar = VerificaPar;

//Utilizando Predicate e Expressão Lambda
Predicate <int> predicatePar = x => x % 2 == 0;

if (predicatePar(numero)) { 
    Console.WriteLine($"O número {numero} é PAR");
}
else
{
    Console.WriteLine($"O número {numero} é ÍMPAR");
}

Console.Read();

    static bool VerificaPar(int x)
    {
        if (x % 2 == 0)
            return true;
        else
            return false;
    }

//Método Pãdrão sem o Predicate
public delegate bool DelegatePar(int x);