using ExercicioPratico;

////Resolução Exercício 1
//Exercicio1<int> resolucao1 = new Exercicio1<int>();
//resolucao1.AdicionaNumeros(5, 10);


////Resolução Exercício 2
//Exercicio2 resolucao2 = new();
//var listaAlunos = resolucao2.SetListaAlunos();
//foreach(var objetosLista in listaAlunos)
//{
//    Console.Write($"{objetosLista.Nome} - {objetosLista.Idade} anos - {objetosLista.Sexo}");
//    Console.WriteLine();
//}


////Resolução Exercício 3
//Exercicio3 resolucao3 = new Exercicio3("[{()}]");
//Console.WriteLine($"\nA expressão está balanceada? {resolucao3.VericicaBalanceamento()}");
//Console.WriteLine($"\nA expressão está balanceada? {resolucao3.VerificaBalanceamentoOtimizado()}");

////Resolução Exercício 4
//Exercicio4.FilaDeImpressao("relatório.pdf", "relação_de_clientes.txt", "planilha_de_pagamento.cvs", "lista_de_certificacoes.pdf", "aniversariantes.cvs");


//Resolução Exercício 5
int[] array1 = new int[] { 1, 2, 3, 4, 8, 9, 10 };
string[] array2 = new string[] { "Gerente", "Serviços Gerais", "Auxiliar" };
double[] array3 = new double[] {150.50, 12.87, 16.4, 20.575 };

Exercicio5.ReverterEImprimir(array1);
Exercicio5.ReverterEImprimir(array1);
Exercicio5.ReverterEImprimir(array2);
Exercicio5.ReverterEImprimir(array2);
Exercicio5.ReverterEImprimir(array3);
Exercicio5.ReverterEImprimir(array3);
Console.Read();