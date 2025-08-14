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

        