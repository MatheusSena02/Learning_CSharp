using System;

namespace Generics
{
    public class Teste
    {
        public void Comparar <T> (T p1, T p2)
        {
            Console.WriteLine($"Os tipos de dados de P1 : {p1.GetType().Name}\nOs tipos de dados de P2: {p2.GetType().Name}");
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais: {resultado}\n");
        }

        public void CompararInteiros <T1, T2> (T1 p1, T2 p2)
        {
            Console.WriteLine($"Os tipos de dados de P1 : {p1.GetType().Name}\nOs tipos de dados de P2: {p2.GetType().Name}");
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais: {resultado}\n");
        }
    }
}
