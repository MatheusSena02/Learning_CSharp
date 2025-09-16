using System;

namespace ExcecoesPersonalizadas
{
    public class SaldoInsuficienteException: Exception
    {
        public SaldoInsuficienteException() { }     //Primeiro construtor comum

        public SaldoInsuficienteException(string? message) : base(message) { }  //Segundo construtor comum

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException) { }   //Terceiro construtor comum

        public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"\nException: Valor do saque R${saque - saldo} superior ao saldo") { }

        public override string Message  //Message também é um método virtual da classe Exception. Logo, é possível sobrescrever
        {
            get
            {
                return "Não há saldo suficiente para sacar";
            }
        }
    }
}