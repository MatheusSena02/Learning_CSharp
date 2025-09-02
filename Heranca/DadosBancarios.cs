using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Pessoa
    {
        protected string? Nome { get; set; }
        protected string? Email { get; set; }
        protected string? Telefone { get; set; }
        protected string? Sexo { get; set; }
        protected int Idade { get; set; }
        protected string? Endereco { get; set; }
        private int id;

        //Funcionario irá herdar o atributo ID, porém não poderá acessá-lo, pois é private

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        //Utilizando encapsulamento para permitir o acesso ao atributo ID

        public Pessoa(string nome, string email, string telefone, string sexo, int idade, string endereco)
        {
            Console.WriteLine("Construtor da classe Pessoa");
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Sexo = sexo;
            Idade = idade;
            Endereco = endereco;
        }

        public Pessoa(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Endereço: {Endereco}");
        }


    }

    public class Funcionario : Pessoa
    {
        public string? Empresa { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string email, string telefone, string sexo, int idade, string endereco, string empresa, string cargo, decimal salario) : base(nome, email, telefone, sexo, idade, endereco) //Utiliza o construtor da classe base completo, esperando receber os 5 argumentos
        {
            //A classe derivada Funcionario chama o construtor da classe base Pessoa utilizando a palavra-chave 'base'
            Console.WriteLine("Construtor da classe Funcionario");
            Empresa = empresa;
            Cargo = cargo;
            Salario = salario;
        }

        public Funcionario(string nome, string email, int idade) : base(nome, email, idade)
        {
            //A classe derivada Funcionario chama o construtor resumido da classe base Pessoa utilizando a palavra-chave 'base'
            Console.WriteLine("\nConstrutor da classe Funcionario - Cadastro rápido");
            Empresa = "Renova";
            Cargo = "Estagiário";
            Salario = 700.0m;
        }

        public override void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }

    public class Cliente : Pessoa
    {
        internal string? NumeroConta { get; set; }
        internal int Agencia { get; set; }
        internal int CVC { get; set; }

        public Cliente(string nome, string email, string telefone, string sexo, int idade, string endereco) : base(nome, email, telefone, sexo, idade, endereco)
        {
            Random seed = new Random();
            CVC = seed.Next(001, 999);
            Agencia = seed.Next(0001, 9999);
            NumeroConta = seed.Next(00001, 9999).ToString();
        }

        public sealed override void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Número da Conta: {NumeroConta}");
        }
    }
}
