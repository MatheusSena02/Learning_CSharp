# Delegates, Express�es Lambda, Eventos e LINQ

## Delegates

Trata-se de um tipo de dado, assim como `int`, `string`, `bool`, dentre outros, mas `delegates` representam refer�ncias a m�todos com uma *lista de par�metros* e um *tipo de retorno*.<br>
Ao instanciar um `delegate`, podemos asoociar a sua inst�ncia a qualquer m�todo com uma **assinatura compat�vel e tipo de retorno**, podemos invocar o m�todo por meio da inst�ncia delegada. <br>

Comumente a declara��o de um `delegate` segue a seguinte estrutura :

|modificador de acesso| delegate |tipo de retorno| nome do delegate | (par�metros)|
|--------------------|---------|---------------|-------------------|---------------|

