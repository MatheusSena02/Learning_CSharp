using System.Data;

DateTime dataAtual = DateTime.Now;  //Para obter a data e a hora no momento atual da execução do programa
Console.WriteLine($"Data Atual : {dataAtual}\n");

DateTime dataEspecifica = new DateTime(2022, 09, 04, 12,30,38); //Para obter uma data e hora específicos
                          //ano, mês, dia, hora, minuto, segundo

Console.WriteLine($"Data Específica : {dataEspecifica}\n");

//Extração de Informações da dataAtual

Console.WriteLine($"Ano Atual : {dataAtual.Year}");
Console.WriteLine($"Mês Atual : {dataAtual.Month}");
Console.WriteLine($"Dia Atual : {dataAtual.Day}");
Console.WriteLine($"Hora Atual : {dataAtual.Hour}");
Console.WriteLine($"Minutos Atual : {dataAtual.Minute}");
Console.WriteLine($"Segundos Atual : {dataAtual.Second}");
Console.WriteLine($"Milissegundos Atual : {dataAtual.Millisecond}\n");


//Adicionando valores
Console.WriteLine($"Ano Atual : {dataAtual.AddYears(20)}");
Console.WriteLine($"Mês Atual : {dataAtual.AddMonths(8)}");
Console.WriteLine($"Dia Atual : {dataAtual.AddDays(12)}");
Console.WriteLine($"Hora Atual : {dataAtual.AddHours(36)}");
Console.WriteLine($"Minutos Atual : {dataAtual.AddMinutes(40)}");
Console.WriteLine($"Segundos Atual : {dataAtual.AddSeconds(120)}");
Console.WriteLine($"Milissegundos Atual : {dataAtual.AddMilliseconds(500)}\n");

//Extrair o dia do mês e do ano
Console.WriteLine($"Dia do mês : {dataAtual.DayOfWeek}");
Console.WriteLine($"Dia do ano : {dataAtual.DayOfYear}");
