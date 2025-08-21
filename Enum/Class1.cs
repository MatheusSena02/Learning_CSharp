using System;

namespace Enum
{
    enum DiasDaSemana
    {
        Segunda, // 0
        Terca,   // 1
        Quarta,  // 2
        Quinta,  // 3
        Sexta,  // 4
        Sabado, // 5
        Domingo  // 6
    } 

    enum DiasPares
    {
        Segunda = 2,   //2
        Quarta,        //3
        Sexta,         //4
        Domingo = 8,   //8
    }

    enum Categorias
    {
        Moda,
        Automotivo,
        Livros,
        Artes,
        Bebidas,
    }

    enum Banco
    {
        Cadastro = 1,   
        Saque = 4,
        Deposito = 3,
        ConsultaSaldo = 2,
        ConsultaDados = 5,
        Saida = 6,
    }
}
