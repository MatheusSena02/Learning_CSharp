using System;

namespace SobrecargaDeMetodos
{
    public class Email() 
    {
        public void Enviar(string endereco)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine("Assunto padrão");
        }

        public void Enviar(string endereco, string assunto)
        {
            Console.WriteLine(endereco);
            Console.WriteLine(assunto);
        }
        public void Enviar(string endereco, decimal valor)
        {
            Console.WriteLine(endereco);
            Console.WriteLine(valor);
        }

        public decimal Enviar(string endereco, decimal renda, decimal valor)
        {
            return renda + valor;
        }
    }
}