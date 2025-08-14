# Classes, Objetos e M�todos

## Conceito de Classe

As `Classes` tratam-se de um molde ou estrutura que utilizada para a cria��o de objetos. Ela define as propriedades (atributos) e comportamentos (m�todos) que os constituir�o os objetos criados a partir dela.

## Conceito de Objeto

A partir das `classes`, podemos criar os `Objetos`, que s�o inst�ncias de uma determinada classe. Cada objeto possui seus pr�prios valores para os atributos definidos na `classe`, mas compartilham a mesma estrutura e comportamento. <br> Em ess�ncia, os objetos represetam conceitos ou entidades da vida real, como um carro, uma pessoa ou um produto.
Esses Objetos s�o armazenados na mem�ria heap, logo, tratam-se de um tipo por refer�ncia.

## Rela��o entre Classes e Objetos

Paralelamente ao funcionamento de tipos de dados primitivos na declara��o de vari�veis, um `Objeto` � criado com um nome, antecedido pela `classe` que o define, seguido do pelo sinal de atribui��o `=` e o operador `new Nome_Da_Classe()` ou ent�o a declara��o do nome da **classe** seguida do m�todo `new`

```csharp
Pessoa p1 = new Pessoa();
p1.nome = "Jo�o";
p1.idade = 30;

Pessoa p2 = new();
p2.nome = "Maria";
p2.idade = 25;
```

## Aloca��o de Mem�ria 

Quando um objet� � criado, a "vari�vel" que o referencia � armazenada na mem�ria stack, enquanto o objeto em si � alocado na mem�ria heap. Isso significa que a vari�vel cont�m uma refer�ncia ao objeto, e n�o o objeto em si. Quando voc� cria um novo objeto, a mem�ria heap � alocada para armazenar os dados do objeto, enquanto a vari�vel na stack aponta para essa localiza��o na heap. <br> Em fun��o disso, se atribuirmos um objeto a outro, ambos apontar�o para o mesmo local na mem�ria heap. 

        