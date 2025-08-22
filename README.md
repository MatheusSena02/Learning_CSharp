# Classes, Objetos e Métodos

## Conceito de Classe

As `Classes` tratam-se de um molde ou estrutura que utilizada para a criação de objetos. Ela define as propriedades (atributos) e comportamentos (métodos) que os constituirão os objetos criados a partir dela.

## Conceito de Objeto

A partir das `classes`, podemos criar os `Objetos`, que são instâncias de uma determinada classe. Cada objeto possui seus próprios valores para os atributos definidos na `classe`, mas compartilham a mesma estrutura e comportamento. <br> Em essência, os objetos represetam conceitos ou entidades da vida real, como um carro, uma pessoa ou um produto.
Esses Objetos são armazenados na memória heap, logo, tratam-se de um tipo por referência.

## Relação entre Classes e Objetos

Paralelamente ao funcionamento de tipos de dados primitivos na declaração de variáveis, um `Objeto` é criado com um nome, antecedido pela `classe` que o define, seguido do pelo sinal de atribuição `=` e o operador `new Nome_Da_Classe()` ou então a declaração do nome da **classe** seguida do método `new`

```csharp
Pessoa p1 = new Pessoa();
p1.nome = "João";
p1.idade = 30;

Pessoa p2 = new();
p2.nome = "Maria";
p2.idade = 25;
```

## Alocação de Memória 

Quando um objetó é criado, a "variável" que o referencia é armazenada na memória stack, enquanto o objeto em si é alocado na memória heap. Isso significa que a variável contém uma referência ao objeto, e não o objeto em si. Quando você cria um novo objeto, a memória heap é alocada para armazenar os dados do objeto, enquanto a variável na stack aponta para essa localização na heap. <br> Em função disso, se atribuirmos um objeto a outro, ambos apontarão para o mesmo local na memória heap. 

## Construtores

Tratam-se de tipos especiais de métodos que são automaticamente chamados quando um objeto é instanciado, ou seja, quando um objeto é criado com o operador `new()`. Eles são utilizados para inicializar os atributos do objeto e podem receber parâmetros para definir valores iniciais. <br> Se nenhum construtor for definido, o compilador cria um construtor padrão sem parâmetros. <br>
Construtores possuem uma estrutura característica : 
- O nome do construtor deve ser o mesmo nome da classe;
- Não possuem tipo de retorno, nem mesmo `void`;
- Podem receber parâmetros para inicializar os atributos do objeto;

- É possíve criar múltiplos construtores na mesma classe, desde que tenham assinaturas diferentes (número ou tipos de parâmetros diferentes). Isso é conhecido como sobrecarga de construtores. <br>
- **Quando resolve se instaciar um objeto utilizando determinado construtor, os atributos daquele construtor utilizados são inicialozados com os valores passados como parâmetro, enquanto os atributos não utilizados são inicializados com seus valores padrão.** <br>
- Também é possível chamar um construtor dentro de um construtor, ao utilizar o operador `this` + o nome do atributo desejado, que deve estar presente nos parâmetros do construtor principal


## Palavra `this`

É um operador que faz referência ao objeto atual. Ele é frequentemente utilizado dentro de métodos e construtores para acessar os atributos e métodos do próprio objeto, especialmente quando há ambiguidade entre nomes de parâmetros e atributos da classe. <br> Por exemplo, em um construtor, se um parâmetro tem o mesmo nome que um atributo da classe, o operador `this` pode ser usado para diferenciar entre o parâmetro e o atributo.

### Casos de uso da palavra `this`:

- Acessar atributos e métodos do objeto atual;
- Passar o objeto atual como parâmetro para outros métodos ou construtores;
- Invocar outro construtor da mesma classe (construtor sobrecarregado);

## Assinatura de um método 

Trata-se de uma identificação exclusiva de um método para o compilador, em que dois métodos não podem possuir a mesma assinatura. <br>
**A assinatura de um método é constituída por** :
- O nome do método;
- A quantidade de parâmetros e seus tipos;
- A ordem dos parâmetros;

**O tipo de retorno do método NÂO faz parte da assinatura.** 

### Sobrecarga de Métodos

Quando fazemos uso de métodos com mesmo nome, mas com assinaturas diferentes, chamamos isso de sobrecarga de métodos. Isso permite que você tenha métodos com o mesmo nome, mas que realizam tarefas diferentes com base nos tipos ou na quantidade de parâmetros passados. <br> A sobrecarga de métodos é uma forma de **polimorfismo**, onde o mesmo nome de método pode se comportar de maneiras diferentes dependendo dos argumentos fornecidos.

## Passagem de Argumentos

### Passagem de Argumentos por Valor

Uma cópia do valor do argumento é feita e passada para o método. Isso significa que qualquer modificação feita no parâmetro dentro do método não afeta o valor original fora do método. <br> Em C#, tipos primitivos (como `int`, `float`, `char`, etc.) são passados por valor por padrão.

### Passagem de Argumentos por Referência

Passa a referência ao mesmo local de memória dos argumentos para os parâmetros, ou seja, nenhuma cópia é feita. Isso significa que qualquer modificação feita no parâmetro dentro do método afeta o valor original fora do método. <br> Em C#, tipos de referência (como objetos e arrays) são passados por referência por padrão.
Utiliza-se os modificadores `ref` ou `out` para indicar que um parâmetro deve ser passado por referência.

- #### Modificador `ref`
Utilizado para passar um argumento por referência, permitindo que o método modifique o valor do argumento original. O parâmetro deve ser inicializado antes de ser passado para o método.

- #### Modificador `out`
Diferente do `ref`, o modificador `out` transfere dados para fora do método, enquanto o `ref` transfere dados de fora para dentro do método, permitindo inclusive que haja mais de um retorno pelo método. Além disso, não requer que o parâmetro seja inicializado antes de ser passado para o método. <br>
```csharp
using MedidasCirculares;

Console.WriteLine("Informações do Círculo");
Console.Write("Digite o raio do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da Circunferência : {circunferencia}");
Console.WriteLine($"Área da Circunferência : {area}");
//Permite que a variável 'area' seja usada fora do método 'CalculaAreaPerimetro'.
```

1. O compilador cria a variável `area` no escopo do método chamador.
2. Ele passa uma referência dessa variável para o método chamado.
3. O método escreve o valor na memória dessa variável.
4. Ao retornar, você pode usar `area` normalmente.

- Analogia

Pense no `out` como entregar um papel em branco para o método preencher.  
Quando o método termina, ele devolve o papel preenchido para você usar.

- **Observação importante**

 Se você tentar usar `area` antes da chamada do método, o compilador não permite, pois ela só é inicializada dentro do método.

- Resumo

O parâmetro `out` é útil para retornar múltiplos valores de um método, garantindo que a variável será inicializada dentro do método e estará disponível no escopo principal após a chamada.

## Argumentos Nomeados
Os `Argumentos Nomeados` permitem que você especifique o nome dos parâmetros ao chamar um método, sem precisar respeitar a ordenação dos parâmetros, tornando mais claro qual valor está sendo passado para qual parâmetro. Isso é especialmente útil quando um método tem muitos parâmetros ou quando você deseja passar apenas alguns deles. <br> Para utilizar argumentos nomeados, basta especificar o nome do parâmetro seguido de dois pontos `:` e o valor desejado.

## Parâmetros Opcionais

Os `Parâmetros Opcionais` permitem que você defina valores padrão para parâmetros em um método, tornando-os opcionais ao chamar o método. Se o parâmetro não for fornecido na chamada, o valor padrão será utilizado. Isso é útil para simplificar chamadas de métodos quando alguns parâmetros têm valores comuns ou padrão. <br> Para definir um parâmetro opcional, basta atribuir um valor padrão ao parâmetro na definição do método.
<br>	`Os parâmetros opcionais devem aparecer após todos os parâmetros necessários. E apenas aceitam valores constantes`

## Métodos Estáticos

Os métodos estáticos pertecem à classe, ao invés do objeto, ou seja, são métodos que *não* dependem de um objeto, não dependem da criação de uma instância da classe para serem acessados. <br>
Como o método estático não possui ligação com o objeto, ele não pode acessar diretamente os atributos de instância (não estáticos) da classe. No entanto, ele pode acessar outros métodos estáticos e atributos estáticos da mesma classe.
Esses métodos podem ser acessados refereniando a classe, aplicando o operador `.` seguido do nome do método. 

### Campos Estáticos

Semelhantemente aos métodos estáticos, os campos estáticos não pertecem a instância da classe, mas sim à própria classe em si, então são variáveis que serão de "comum uso a todos". <br>
Isso quer dizer que, ao invés de cada instância de uma classe ter sua própria cópia de um campo, todas as instâncias compartilham a mesma cópia do campo estático. <br>

### Construtor Estático

Semelhantemente ao construtor padrão, o construtor estático é chamado automaticamente quando a classe é carregada pela primeira vez, antes de qualquer instância ser criada ou qualquer membro estático ser acessado. <br> Ele é usado para inicializar campos estáticos ou executar qualquer configuração necessária para a classe como um todo

#### Características do Construtor Estático:
- Não pode receber parâmetros;
- Só pode haver um construtor estático por classe;
- Não pode ser chamado explicitamente, é invocado automaticamente pelo runtime;
- Se um construtor estático gerar uma exceção, a classe não poderá ser usada, e o construtor não será chamado novamente em futuras tentativas de uso da classe.

## Propriedades

Até então, todos os programas foram construídas com atributos públicos, o que não é uma boa prática de programação, pois permite acesso direto aos dados do objeto. As `Propriedades` são uma forma de encapsular os atributos, permitindo o controle sobre como os dados são acessados e modificados. <br> Elas consistem em métodos especiais chamados `get` e `set`, que permitem ler e escrever valores de atributos de forma controlada. <br>
Uma propriedade é uma combinação de um campo privado e dois acessadores : get e set. Normalmente, o campo privado é um campo oculto gerado pelo compilador tendo um campo público como interface para acesso externo, quase como se o compilador usasse o atributo público como máscara para esconder as operações no campo privado.

### get e set 
get é utilizado para ler o valor de uma propriedade, enquanto set é utilizado para atribuir um valor a ela. <br> A propriedade pode ser definida como somente leitura (apenas get) ou somente gravação (apenas set), dependendo das necessidades da classe.

## Enum

Funciona como uma "struct de constates", ou seja, é um tipo de dado que permite definir um conjunto nomeado de constantes. Isso é útil para representar um conjunto fixo de valores relacionados, como dias da semana, estados de um processo, etc. <br> Se não houver um valor atribuído, o primeiro valor do enum será 0, e os demais serão incrementados a partir desse valor. <br>

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

São palavras-chave usadas para especificar o acesso de um membro (campo, propriedade, método, etc) ou de um tipo (classe, struct, etc).

- `public` : Pode ser acessado por qualquer outro código no mesmo mesmo *assembly* ou em outro *assembly* que faz referência a ele;
- `private`: Pode ser acessado apenas internamente na classe, ou seja, não é possível modificar o tipo ou membro a partir do objeto;
- `internal` : Pode ser acessado por qualquer código no mesmo *assembly*, mas não de outro *assembly*;
- `protected` : Pode ser acessado por qualquer código no *assembly* no qual ele é declarado ou de uma classe derivada em outro *assembly* (Herança);
- `file` : Restringe o escopo e a visibilidade de um tipo de nível superior ao arquivo no qual ele foi declarado; 

## Tratamento de Exceção : Try / Catch

As exceções que podem ocorrer em um aplicativo devem ser tratadas para evitar *travamentos* e *resultados inesperados* e continuar a execução do código, quando isso for possível.

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
	Console.WriteLine("Divisão Inválida");
}
```

É um método de código para tratamento de excessões, em que o programa tenta executar o código no bloco `try`. Caso seja internamente inválido para o compilador, ele executa o código no bloco `catch`.,

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
	Console.WriteLine("Divisão Inválida");
}
finally
{
	Console.WriteLine("Processamento concluído");
}
```

Basicamente possui o mesmo comportamento que anteriormente, mas a inclusão do `finally` faz com que um escopo de código seja executado, independemente de atender as exceções ou não, ou seja, sempre será executado.

### Propriedades da Exceção 

|Propriedade|Tipo|Descrição|
|-----------|----|----------|
|Message|String|Contém uma mensagem de erro explicando a causa da exceção|
|StackTrace|String|Contém a informação que descreve aonde a exceção ocorreu|
|InnerException|Exception|Se a exceção foi lançada por outra exceção, esta propriedade contém a referência da antiga exceção|

```csharp

int a = 5;
int b = 0;

try
{
	Console.WriteLine($"Valor : {x/y}");
}
catch (Exception ex)	//Cria-se um objeto do tipo Exception para acessar as propriedades de exceções
{
	Console.WriteLine("Divisão Inválida");
	Console.WriteLine($"Motivo do erro : {ex.Message}");
	Console.WriteLine($"Onde está o erro : {ex?.StackTrace?}");

}
finally
{
	Console.WriteLine("Processamento concluído");
}
```

## TIpos Anônimos

Trata-se de um tipo sem nenhum nome ou identificação que pode conter apenas propriedades públicas *somente leitura*, sempre sendo alocado localmente =. O nome do tipo é gerado pelo compilador e não está disponível no código-fonte e o tipo de cada propriedade é inferido pelo compilador.

```csharp

var tipoAnonimo = new
{
	Nome = "Matheus",
	Idade = 42
};
```

Basicamente criamos um objeto, mas este objeto não é uma instância de qualquer classe. Não a toa ele é declarado utilizando `var`, pois o compilador vai ficar responsável por atribuir os tipos. <br> Um tipo anônimo pode ter uma propriedade de outro tipo anônimo.

```csharp

var tipoAnonimo = new
{
	Nome = "Matheus",
	Idade = 42,
	Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
};
```


## Partial Class 

O modificador `partial` nos permite, basicamente, "quebrar" a definição da classe em vários arquivos. Ao invés de declarar todos os aspectos da classe em um único arquivo, podemos usar esse modificador para quebrar em vários arquivos, desde eles possuam mesmo nome e sejam identificados com o modificador `partial` <br>
Ao final da compilação, o compilador vai combinar todos esses fragmentos da classe em uma classe só e executar o que lhe foi pedido.

