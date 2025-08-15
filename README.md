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

## Construtores

Tratam-se de tipos especiais de m�todos que s�o automaticamente chamados quando um objeto � instanciado, ou seja, quando um objeto � criado com o operador `new()`. Eles s�o utilizados para inicializar os atributos do objeto e podem receber par�metros para definir valores iniciais. <br> Se nenhum construtor for definido, o compilador cria um construtor padr�o sem par�metros. <br>
Construtores possuem uma estrutura caracter�stica : 
- O nome do construtor deve ser o mesmo nome da classe;
- N�o possuem tipo de retorno, nem mesmo `void`;
- Podem receber par�metros para inicializar os atributos do objeto;

- � poss�ve criar m�ltiplos construtores na mesma classe, desde que tenham assinaturas diferentes (n�mero ou tipos de par�metros diferentes). Isso � conhecido como sobrecarga de construtores. <br>
- **Quando resolve se instaciar um objeto utilizando determinado construtor, os atributos daquele construtor utilizados s�o inicialozados com os valores passados como par�metro, enquanto os atributos n�o utilizados s�o inicializados com seus valores padr�o.** <br>
- Tamb�m � poss�vel chamar um construtor dentro de um construtor, ao utilizar o operador `this` + o nome do atributo desejado, que deve estar presente nos par�metros do construtor principal


## Palavra `this`

� um operador que faz refer�ncia ao objeto atual. Ele � frequentemente utilizado dentro de m�todos e construtores para acessar os atributos e m�todos do pr�prio objeto, especialmente quando h� ambiguidade entre nomes de par�metros e atributos da classe. <br> Por exemplo, em um construtor, se um par�metro tem o mesmo nome que um atributo da classe, o operador `this` pode ser usado para diferenciar entre o par�metro e o atributo.

### Casos de uso da palavra `this`:

- Acessar atributos e m�todos do objeto atual;
- Passar o objeto atual como par�metro para outros m�todos ou construtores;
- Invocar outro construtor da mesma classe (construtor sobrecarregado);