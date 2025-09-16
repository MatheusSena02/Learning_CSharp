# Delegates, Expressões Lambda, Eventos e LINQ

## Delegates

Trata-se de um tipo de dado, assim como `int`, `string`, `bool`, dentre outros, mas `delegates` representam referências a métodos com uma *lista de parâmetros* e um *tipo de retorno*.<br>
Ao instanciar um `delegate`, podemos asoociar a sua instância a qualquer método com uma **assinatura compatível e tipo de retorno**, podemos invocar o método por meio da instância delegada. <br>

Comumente a declaração de um `delegate` segue a seguinte estrutura :

|modificador de acesso| delegate |tipo de retorno| nome do delegate | (parâmetros)|
|--------------------|---------|---------------|-------------------|---------------|

