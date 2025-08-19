using System;


namespace CamposEstaticos
{
    public class Class1
    {
        public int Conta;
        public string? Nome;
        public static float Juros;

        public float JurosAnual()
        {
            return Juros * 12;
        }


    }
}
