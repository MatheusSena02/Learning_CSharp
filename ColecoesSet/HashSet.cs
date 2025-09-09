using System;

namespace ColecoesSet
{
    public class HashSet
    {
        private static HashSet<string> timesSP = new HashSet<string>
        {
            "Santos", "Palmeiras", "São Paulo" 
        };

        private static HashSet<string> timesRJ = new HashSet<string>
        {
            "Vasco", "Flamengo", "Fluminense" 
        };

        private static HashSet<string> timesBA = new HashSet<string>
        {
            "Bahia", "Vitória", "Juazeiro" 
        };

        private static HashSet<string> timesMundo = new HashSet<string>
        {
            "Santos", "Palmeiras", "São Paulo", "Flamengo"
        };

        public static void ExibeTimesSP()
        {
            foreach(var i in timesSP)
            {
                Console.Write($"|{i}|");
            }
            Console.WriteLine("\n");
        }
        public static void ExibeTimesRJ()
        {
            foreach(var i in timesRJ)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        public static void ExibeTimesBA()
        {
            foreach(var i in timesBA)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }

        public static void AdicionaTimeSP(string? time)
        {
            if (!timesSP.Contains(time))
            {
                timesSP.Add(time);
            }
            else
            {
                Console.WriteLine("Elemento já existente na lista");
            }
        }
        public static void AdicionaTimeRJ(string? time)
        {
            if (!timesRJ.Contains(time))
            {
                timesRJ.Add(time);
            }
            else
            {
                Console.WriteLine("Elemento já existente na lista");
            }
        }
        public static void AdicionaTimeBA(string? time)
        {
            if (!timesBA.Contains(time))
            {
                timesBA.Add(time);
            }
            else
            {
                Console.WriteLine("Elemento já existente na lista");
            }
        }

        public static void VerificaSubconjuntos()
        {
            Console.WriteLine($"SP ⊆ Mundo? {timesSP.IsSubsetOf(timesMundo)}");
            Console.WriteLine($"RJ ⊆ Mundo? {timesRJ.IsSubsetOf(timesMundo)}");
            Console.WriteLine($"BA ⊆ Mundo? {timesBA.IsSubsetOf(timesMundo)}");

            // Mostra itens de SP que NÃO estão em Mundo (se houver)
            foreach (var t in timesSP)
                if (!timesMundo.Contains(t))
                    Console.WriteLine($"Falta em Mundo (SP): '{t}'");

            foreach (var t in timesRJ)
                if (!timesMundo.Contains(t))
                    Console.WriteLine($"Falta em Mundo (RJ): '{t}'");

            foreach (var t in timesBA)
                if (!timesMundo.Contains(t))
                    Console.WriteLine($"Falta em Mundo (BA): '{t}'");
        }

        public static void VerificaSuperconjuntos()
        {
            if (timesMundo.IsSupersetOf(timesSP))
            {
                Console.Write("timesMundo é um super conjunto de timesSP");
            }

            if (timesMundo.IsSupersetOf(timesRJ))
            {
                Console.Write("timesMundo é um super conjunto de timesRJ");
            }
            if (timesMundo.IsSupersetOf(timesBA))
            {
                Console.Write("timesMundo é um super conjunto de timesBA");
            }
        }

        public static void VerificaElementosComuns()
        {
            if (timesSP.Overlaps(timesMundo))
            {
                Console.WriteLine("Pelo menos um time do SP possuí título mundial");
            }
            if (timesRJ.Overlaps(timesMundo))
            {
                Console.WriteLine("Pelo menos um time do RJ possuí título mundial");
            }
            if (timesBA.Overlaps(timesMundo))
            {
                Console.WriteLine("Pelo menos um time da BA possuí título mundial");
            }
        }


    }
}