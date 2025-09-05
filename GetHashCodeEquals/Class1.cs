using System;

namespace GetHashCode
{
    public class Class1
    {
        public bool Comparar <T> (T valor1, T valor2)
        {
            return valor1.Equals(valor2);
        }
    }

    public class  Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public Pessoa(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }

        //Sobrescrita do método Equals
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(obj is not Pessoa) return false;
            //Se o parâmetro for diferente do um objeto da classe Pessoa, retorna false

            var other = (Pessoa)obj; //Faz o boxing do obj, convertendo em um objeto do tipo Pessoa

            return Id.Equals(other.Id);     //Faz a comparação baseado no atributo ID
            //Retorna o resultado a operação do atributo Id do objeto com o Id do objeto Pessoa passado no argumento
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}