using System;

namespace ColecoesSet
{
    public class TimesBrasileiros
    {
        private HashSet<string> timesSp = new HashSet<string>
        {
            "Santos", "Palmeiras", "São Paulo" 
        };

        public HashSet<string> TimesSP {  get { return timesSp; } }

        private HashSet<string> timesRj = new HashSet<string>
        {
            "Vasco", "Flamengo", "Fluminense" 
        };

        public HashSet<string> TimesRJ { get { return timesRj; } }

        private HashSet<string> timesBa = new HashSet<string>
        {
            "Bahia", "Vitória", "Juazeiro" 
        };

        public HashSet<string> TimesBA { get { return timesBa; } }

        private HashSet<string> timesComMundial = new HashSet<string>
        {
            "Santos", "Palmeiras", "São Paulo", "Flamengo"
        };

        public HashSet<string> TimesComMundial { get { return timesComMundial; } }

        public void ExibeTime<T>(IEnumerable <T> times)
        {
            foreach(var nome in times)
            {
                Console.Write($"|{nome}|");
            }
        }

        public void AdicionaTime(HashSet<string>listTimes, string? nomeTime)
        {
            listTimes.Add(nomeTime);
            Console.WriteLine($"\n\nTime adicionado com sucesso à lista\n");
        }

        public void VerificaSubconjuntos(HashSet<string> timeA, HashSet<string> timeB)
        {
            if (timeA.IsSubsetOf(timeB))
            {
                Console.WriteLine($"{timeA} é um subconjunto de {timeB}");
            }else if (timeB.IsSubsetOf(timeA))
            {
                Console.WriteLine($"{timeB} é um subconjunto de {timeA}");
            }
            
        }

        public void VerificaSuperconjuntos(HashSet<string> timeA, HashSet<string> timeB)
        {
            if (timeA.IsSupersetOf(timeB))
            {
                Console.WriteLine($"{timeA} é um superconjunto de {timeB}");
            }else if(timeB.IsSupersetOf(timeA) )
            {
                Console.WriteLine($"{timeB} é um subconjunto de {timeA}");
            }
        }

        public void VerificaElementosComuns(HashSet<string> timeA, HashSet<string> timeB)
        {
            if (timeA.Overlaps(timeB))
            {
                Console.WriteLine($"\n\nPelo menos um item da {timeA} tem valores na {timeB}\n");
            }else if( timeB.Overlaps(timeA))
            {
                Console.WriteLine($"Pelo menos um item da {timeB} tem valores na {timeA}\n");
            }
        }
    }
}