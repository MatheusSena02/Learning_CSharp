//Estrutura de Controle : Condicional Switch

Console.WriteLine("1. Rock \t 2. Pop \t 3. Nacional \t 4. Anos 80");
Console.Write("Selecione a opção musical : ");
char opcaoUsuario = Convert.ToChar(Console.ReadLine());


//Estrutura padrão do Switch Case
switch (opcaoUsuario)   //Switch Case NÂO avalia uma expressão booleana. Mas o valor de uma variável ou expressão 
{
    case '1':   //Caso o valor da variável opcaoUsuario seja '1'
        Console.WriteLine("Tocar rock...");
        break;
    case '2':   //Caso o valor da variável opcaoUsuario seja '2'
        Console.WriteLine("Tocar pop...");
        break;
    case '3':   //Caso o valor da variável opcaoUsuario seja '2'
        Console.WriteLine("Tocar música nacional...");
        break;
    case '4':   //Caso o valor da variável opcaoUsuario seja '1'
        Console.WriteLine("Tocar música dos anos 80");
        break;
    default:    //Caso o valor da variável opcaoUsuario não corresponda aos casos apresentados
        Console.WriteLine("Opção inválida");
        break;

}

//Estrutura para executar o mesmo código para valores diferentes
Console.Write("Digite um mês : ");
string mes = Console.ReadLine().ToLower();
switch (mes)
{
    //Caso o valor da variável mês seja qualquer um dos casos apresentados abaixo, a instrução é executada (Operador OR)
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Esse mês possui 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Esse mês possui 28 dias");
        break;
    default:
        Console.WriteLine("Esse mês possui 30 dias");
        break;  
}


Console.Read();