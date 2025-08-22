using System;

namespace Class1
{
    public partial class MinhaPartial
    {
        public TimeSpan CalculaIdade(DateTime dataNascimento)
        {
            return (DateTime.Now.Date - dataNascimento);
        } 

        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }
    }
}