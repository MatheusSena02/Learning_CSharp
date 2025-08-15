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