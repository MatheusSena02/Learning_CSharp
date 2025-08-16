//Estrutura de Controle : Laço While

int i = 1;
//Primeiro avalia a condição e posteriormente executa as instruções, se atender a condição
while(i <= 10)  //Continua executando as instruções até o momento em que i seja igual ou maior que 10
{
    Console.Write(i + "\t");
    i++;
}

Console.WriteLine();

//O loop do-while vai primeira executar as instruções e posteriormente vai analisar as condições, para assim saber se repete a execução das instruções
int j = 10;
do
{
    Console.Write(j + "\t");
    j--;
} while (j != 0);

Console.ReadLine();