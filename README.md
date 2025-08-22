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

Os m�todos est�ticos pertecem � classe, ao inv�s do objeto, ou seja, s�o m�todos que *n�o* dependem de um objeto, n�o dependem da cria��o de uma inst�ncia da classe para serem acessados. <br>
Como o m�todo est�tico n�o possui liga��o com o objeto, ele n�o pode acessar diretamente os atributos de inst�ncia (n�o est�ticos) da classe. No entanto, ele pode acessar outros m�todos est�ticos e atributos est�ticos da mesma classe.
Esses m�todos podem ser acessados refereniando a classe, aplicando o operador `.` seguido do nome do m�todo. 

### Campos Est�ticos

Semelhantemente aos m�todos est�ticos, os campos est�ticos n�o pertecem a inst�ncia da classe, mas sim � pr�pria classe em si, ent�o s�o vari�veis que ser�o de "comum uso a todos". <br>
Isso quer dizer que, ao inv�s de cada inst�ncia de uma classe ter sua pr�pria c�pia de um campo, todas as inst�ncias compartilham a mesma c�pia do campo est�tico. <br>

### Construtor Est�tico

Semelhantemente ao construtor padr�o, o construtor est�tico � chamado automaticamente quando a classe � carregada pela primeira vez, antes de qualquer inst�ncia ser criada ou qualquer membro est�tico ser acessado. <br> Ele � usado para inicializar campos est�ticos ou executar qualquer configura��o necess�ria para a classe como um todo

#### Caracter�sticas do Construtor Est�tico:
- N�o pode receber par�metros;
- S� pode haver um construtor est�tico por classe;
- N�o pode ser chamado explicitamente, � invocado automaticamente pelo runtime;
- Se um construtor est�tico gerar uma exce��o, a classe n�o poder� ser usada, e o construtor n�o ser� chamado novamente em futuras tentativas de uso da classe.

## Propriedades

At� ent�o, todos os programas foram constru�das com atributos p�blicos, o que n�o � uma boa pr�tica de programa��o, pois permite acesso direto aos dados do objeto. As `Propriedades` s�o uma forma de encapsular os atributos, permitindo o controle sobre como os dados s�o acessados e modificados. <br> Elas consistem em m�todos especiais chamados `get` e `set`, que permitem ler e escrever valores de atributos de forma controlada. <br>
Uma propriedade � uma combina��o de um campo privado e dois acessadores : get e set. Normalmente, o campo privado � um campo oculto gerado pelo compilador tendo um campo p�blico como interface para acesso externo, quase como se o compilador usasse o atributo p�blico como m�scara para esconder as opera��es no campo privado.

### get e set 
get � utilizado para ler o valor de uma propriedade, enquanto set � utilizado para atribuir um valor a ela. <br> A propriedade pode ser definida como somente leitura (apenas get) ou somente grava��o (apenas set), dependendo das necessidades da classe.

## Enum

Funciona como uma "struct de constates", ou seja, � um tipo de dado que permite definir um conjunto nomeado de constantes. Isso � �til para representar um conjunto fixo de valores relacionados, como dias da semana, estados de um processo, etc. <br> Se n�o houver um valor atribu�do, o primeiro valor do enum ser� 0, e os demais ser�o incrementados a partir desse valor. <br>

```csharp 
# Essa sintaxe exibe o nome do atributo do atributo do Enum
Console.WriteLine(DiasDaSemana.Segunda);

# Essa sintaxe exibe o valor do atributo do Enum
Console.WriteLine((int)DiasDaSemana.Segunda);
//Exibe o "valor" do atributo do Enum

```

Da mesma forma que para acessar o valor do atributo do Enum, podemos fazer o inverso, ou seja, acessar o nome do atributo a partir do valor do atributo.

```csharp
DiasDaSemana dia = (DiasDaSemana)2;
Console.WriteLine(dia); //Exibe "Quarta"
```

## Modificadores de Acesso

S�o palavras-chave usadas para especificar o acesso de um membro (campo, propriedade, m�todo, etc) ou de um tipo (classe, struct, etc).

- `public` : Pode ser acessado por qualquer outro c�digo no mesmo mesmo *assembly* ou em outro *assembly* que faz refer�ncia a ele;
- `private`: Pode ser acessado apenas internamente na classe, ou seja, n�o � poss�vel modificar o tipo ou membro a partir do objeto;
- `internal` : Pode ser acessado por qualquer c�digo no mesmo *assembly*, mas n�o de outro *assembly*;
- `protected` : Pode ser acessado por qualquer c�digo no *assembly* no qual ele � declarado ou de uma classe derivada em outro *assembly* (Heran�a);
- `file` : Restringe o escopo e a visibilidade de um tipo de n�vel superior ao arquivo no qual ele foi declarado; 

## Tratamento de Exce��o : Try / Catch

As exce��es que podem ocorrer em um aplicativo devem ser tratadas para evitar *travamentos* e *resultados inesperados* e continuar a execu��o do c�digo, quando isso for poss�vel.

### Bloco try-catch

```csharp

int a = 5;
int b = 0;

try
{
	Console.WriteLine($"Valor : {x/y}");
}
catch
{
	Console.WriteLine("Divis�o Inv�lida");
}
```

� um m�todo de c�digo para tratamento de excess�es, em que o programa tenta executar o c�digo no bloco `try`. Caso seja internamente inv�lido para o compilador, ele executa o c�digo no bloco `catch`.,

### Bloco try-catch-finally

```csharp

int a = 5;
int b = 0;

try
{
	Console.WriteLine($"Valor : {x/y}");
}
catch
{
	Console.WriteLine("Divis�o Inv�lida");
}
finally
{
	Console.WriteLine("Processamento conclu�do");
}
```

Basicamente possui o mesmo comportamento que anteriormente, mas a inclus�o do `finally` faz com que um escopo de c�digo seja executado, independemente de atender as exce��es ou n�o, ou seja, sempre ser� executado.

### Propriedades da Exce��o 

|Propriedade|Tipo|Descri��o|
|-----------|----|----------|
|Message|String|Cont�m uma mensagem de erro explicando a causa da exce��o|
|StackTrace|String|Cont�m a informa��o que descreve aonde a exce��o ocorreu|
|InnerException|Exception|Se a exce��o foi lan�ada por outra exce��o, esta propriedade cont�m a refer�ncia da antiga exce��o|

```csharp

int a = 5;
int b = 0;

try
{
	Console.WriteLine($"Valor : {x/y}");
}
catch (Exception ex)	//Cria-se um objeto do tipo Exception para acessar as propriedades de exce��es
{
	Console.WriteLine("Divis�o Inv�lida");
	Console.WriteLine($"Motivo do erro : {ex.Message}");
	Console.WriteLine($"Onde est� o erro : {ex?.StackTrace?}");

}
finally
{
	Console.WriteLine("Processamento conclu�do");
}
```

## TIpos An�nimos

Trata-se de um tipo sem nenhum nome ou identifica��o que pode conter apenas propriedades p�blicas *somente leitura*, sempre sendo alocado localmente =. O nome do tipo � gerado pelo compilador e n�o est� dispon�vel no c�digo-fonte e o tipo de cada propriedade � inferido pelo compilador.

```csharp

var tipoAnonimo = new
{
	Nome = "Matheus",
	Idade = 42
};
```

Basicamente criamos um objeto, mas este objeto n�o � uma inst�ncia de qualquer classe. N�o a toa ele � declarado utilizando `var`, pois o compilador vai ficar respons�vel por atribuir os tipos. <br> Um tipo an�nimo pode ter uma propriedade de outro tipo an�nimo.

```csharp

var tipoAnonimo = new
{
	Nome = "Matheus",
	Idade = 42,
	Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
};
```


## Partial Class 

O modificador `partial` nos permite, basicamente, "quebrar" a defini��o da classe em v�rios arquivos. Ao inv�s de declarar todos os aspectos da classe em um �nico arquivo, podemos usar esse modificador para quebrar em v�rios arquivos, desde eles possuam mesmo nome e sejam identificados com o modificador `partial` <br>
Ao final da compila��o, o compilador vai combinar todos esses fragmentos da classe em uma classe s� e executar o que lhe foi pedido.

