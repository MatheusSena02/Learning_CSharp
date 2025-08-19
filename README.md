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

## Assinatura de um m�todo 

Trata-se de uma identifica��o exclusiva de um m�todo para o compilador, em que dois m�todos n�o podem possuir a mesma assinatura. <br>
**A assinatura de um m�todo � constitu�da por** :
- O nome do m�todo;
- A quantidade de par�metros e seus tipos;
- A ordem dos par�metros;

**O tipo de retorno do m�todo N�O faz parte da assinatura.** 

### Sobrecarga de M�todos

Quando fazemos uso de m�todos com mesmo nome, mas com assinaturas diferentes, chamamos isso de sobrecarga de m�todos. Isso permite que voc� tenha m�todos com o mesmo nome, mas que realizam tarefas diferentes com base nos tipos ou na quantidade de par�metros passados. <br> A sobrecarga de m�todos � uma forma de **polimorfismo**, onde o mesmo nome de m�todo pode se comportar de maneiras diferentes dependendo dos argumentos fornecidos.

## Passagem de Argumentos

### Passagem de Argumentos por Valor

Uma c�pia do valor do argumento � feita e passada para o m�todo. Isso significa que qualquer modifica��o feita no par�metro dentro do m�todo n�o afeta o valor original fora do m�todo. <br> Em C#, tipos primitivos (como `int`, `float`, `char`, etc.) s�o passados por valor por padr�o.

### Passagem de Argumentos por Refer�ncia

Passa a refer�ncia ao mesmo local de mem�ria dos argumentos para os par�metros, ou seja, nenhuma c�pia � feita. Isso significa que qualquer modifica��o feita no par�metro dentro do m�todo afeta o valor original fora do m�todo. <br> Em C#, tipos de refer�ncia (como objetos e arrays) s�o passados por refer�ncia por padr�o.
Utiliza-se os modificadores `ref` ou `out` para indicar que um par�metro deve ser passado por refer�ncia.

- #### Modificador `ref`
Utilizado para passar um argumento por refer�ncia, permitindo que o m�todo modifique o valor do argumento original. O par�metro deve ser inicializado antes de ser passado para o m�todo.

- #### Modificador `out`
Diferente do `ref`, o modificador `out` transfere dados para fora do m�todo, enquanto o `ref` transfere dados de fora para dentro do m�todo, permitindo inclusive que haja mais de um retorno pelo m�todo. Al�m disso, n�o requer que o par�metro seja inicializado antes de ser passado para o m�todo. <br>
```csharp
using MedidasCirculares;

Console.WriteLine("Informa��es do C�rculo");
Console.Write("Digite o raio do c�rculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Per�metro da Circunfer�ncia : {circunferencia}");
Console.WriteLine($"�rea da Circunfer�ncia : {area}");
//Permite que a vari�vel 'area' seja usada fora do m�todo 'CalculaAreaPerimetro'.
```

1. O compilador cria a vari�vel `area` no escopo do m�todo chamador.
2. Ele passa uma refer�ncia dessa vari�vel para o m�todo chamado.
3. O m�todo escreve o valor na mem�ria dessa vari�vel.
4. Ao retornar, voc� pode usar `area` normalmente.

- Analogia

Pense no `out` como entregar um papel em branco para o m�todo preencher.  
Quando o m�todo termina, ele devolve o papel preenchido para voc� usar.

- **Observa��o importante**

 Se voc� tentar usar `area` antes da chamada do m�todo, o compilador n�o permite, pois ela s� � inicializada dentro do m�todo.

- Resumo

O par�metro `out` � �til para retornar m�ltiplos valores de um m�todo, garantindo que a vari�vel ser� inicializada dentro do m�todo e estar� dispon�vel no escopo principal ap�s a chamada.

## Argumentos Nomeados
Os `Argumentos Nomeados` permitem que voc� especifique o nome dos par�metros ao chamar um m�todo, sem precisar respeitar a ordena��o dos par�metros, tornando mais claro qual valor est� sendo passado para qual par�metro. Isso � especialmente �til quando um m�todo tem muitos par�metros ou quando voc� deseja passar apenas alguns deles. <br> Para utilizar argumentos nomeados, basta especificar o nome do par�metro seguido de dois pontos `:` e o valor desejado.

## Par�metros Opcionais

Os `Par�metros Opcionais` permitem que voc� defina valores padr�o para par�metros em um m�todo, tornando-os opcionais ao chamar o m�todo. Se o par�metro n�o for fornecido na chamada, o valor padr�o ser� utilizado. Isso � �til para simplificar chamadas de m�todos quando alguns par�metros t�m valores comuns ou padr�o. <br> Para definir um par�metro opcional, basta atribuir um valor padr�o ao par�metro na defini��o do m�todo.
<br>	`Os par�metros opcionais devem aparecer ap�s todos os par�metros necess�rios. E apenas aceitam valores constantes`

## M�todos Est�ticos