using System;

namespace Propriedades
{
    public class Produto
    {
        //Atributo privado, campo de apoio
        private string? nome;   //Mesmo tipo de dado com nome em caixa baixa
        //Interface pública
        public string? Nome 
        { 
            get { return nome.ToUpper(); }
            //get : Retorna o valor do atributo nome em caixa alta
            set { nome = value; }
            //set : Atribui o valor recebido ao atributo nome, ou seja, o valor que for passado para a propriedade Nome será armazenado no atributo nome
        }
        private double preco;
        public double Preco 
        {
            get { return preco; }
            //O modificador set permite realizar operações lógicas acerca do valor
            set
            {
                if(value < 5)
                {
                    preco = 5;
                }else
                {
                    preco = value;
                }
            }
        }
        private double desconto = 0.05;
        public double Desconto 
        {
            //O modificador get permite apenas acessar o valor do atributo desconto, não modificar
            get
            {
                return desconto;
            }
        }
        //Por ser apenas leitura (get), não é necessário ter o campo de apoio
        public double PrecoFinal 
        {
            //O modificador get permite acessar o valor do atributo precoFinal, que é calculado com base no preço e no desconto
            get { return Preco - (Preco * Desconto); }    
        }
        private int estoqueMinimo;
        public int EstoqueMinimo 
        {
            //O modificador set permite modificar o valor do atributo estoqueMinimo
            set { estoqueMinimo = value; }
        }

        public void Exibir()
        {
            //Nesse caso, para acessar os valaroes, passamos a propriedade, ao invés dos campos
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Desconto: {Desconto}");
            Console.WriteLine($"Preço Final: {PrecoFinal}");
            Console.WriteLine($"Estoque Mínimo: {estoqueMinimo}");
        }
    }
}
