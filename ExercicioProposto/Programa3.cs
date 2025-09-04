using System;

namespace Programas
{
    public abstract class Pessoa
    {
        protected string? Nome {  get; set; }
        protected Pessoa[] lista = new Pessoa[3]; 

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual void Explicar() { }

        public virtual void Estudar() { }
    }

    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome) { }

        public override void Explicar()
        {
            Console.WriteLine($"{Nome} está explicando...");
        }
    }

    public class Aluno : Pessoa
    {
        public Aluno (string nome) : base(nome) { } 


        public override void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando...");
        }
    }
}