using System;

namespace ParametrosOpcionais
{
    public class Class1
    {
        public Class1(string nome,string boasVindas = "Seja bem-vindo(a)! \n" )
        {
            Console.WriteLine(boasVindas + nome);

        }
    }
}