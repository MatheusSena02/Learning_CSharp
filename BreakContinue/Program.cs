//Estruturas de Controle : break e continue

int valor = 0;

while (true)    //Loop while infinito
{
    Console.WriteLine("Valor da variável : " + valor);
    valor++;
    if(valor == 10)
    {
        break; //Estrutura para interromper o loop em determinada condição
    }

}

valor = 1;

Console.WriteLine("Impressão de valores pares");
for(; ; )   //Loop for infinito
{
    valor++;
    if(valor % 2 != 0)
    {
        continue;   //Estrutura para pular uma iteração no loop, pulando para a próxima iteração
    }
    Console.WriteLine(valor);
    if(valor == 100)
    {
        break;
    }
}

Console.ReadLine();