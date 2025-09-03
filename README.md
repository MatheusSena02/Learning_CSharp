# Programação Orientada a Objetos

## Os pilares da Programação Orientada a Objetos

### Abstração

A abstração é o processo de simplificar um sistema complexo, focando apenas nos aspectos essenciais e ignorando os detalhes irrelevantes. Em POO, a abstração permite criar classes que representam conceitos do mundo real, encapsulando atributos e comportamentos relevantes.

### Encapsulamento

O encapsulamento é o princípio de esconder os detalhes internos de um objeto e expor apenas uma interface pública para interagir com ele. Isso ajuda a proteger o estado interno do objeto, garantindo que ele só possa ser modificado de maneiras controladas.

### Herança

A herança é um mecanismo que permite criar novas classes (subclasses) baseadas em classes existentes (superclasses). A subclasse herda atributos e métodos da superclasse, promovendo a reutilização de código e facilitando a criação de hierarquias de classes.

### Polimorfismo

O polimorfismo é a capacidade de diferentes classes responderem de maneira diferente à mesma mensagem ou método. Isso permite que objetos de diferentes tipos sejam tratados de forma uniforme, facilitando a extensibilidade e a manutenção do código.

## Herança

A herança é um mecanismo pelo qual uma classe (*conhecida como classe derivada ou subclasse*) pode adquirir propriedades e métodos de outra classe (*conhecida como classe base ou superclasse*). <br>
A relação entre classe a classe *derivada* e a classe *base* é estabelecida através do `sinal de dois pontos (:)` seguido do nome da classe base, após a declaração da classe derivada.

```csharp 
class Animal
{
	public void Comer()
	{
		Console.WriteLine("O animal está comendo.");
	}
}
class Cachorro : Animal
{
	public void Latir()
	{
		Console.WriteLine("O cachorro está latindo.");
	}
}
``` 

### Classe Object 

No C#, todas as classes herdam implicitamente da classe `Object`, que é a raiz da hierarquia de classes. A classe `Object` fornece métodos básicos que todas as classes herdam.

| Método | Descrição |
|--------|-----------|
| `ToString()` | Retorna uma representação em string do objeto. |
| `Equals(object obj)` | Compara o objeto atual com outro objeto para verificar se são iguais. |
| `GetHashCode()` | Retorna um código hash para o objeto, usado em estruturas de dados como tabelas hash. |
| `GetType()` | Retorna o tipo do objeto em tempo de execução. |
| `MemberwiseClone()` | Cria uma cópia superficial do objeto atual. |
| `Finalize()` | Permite que um objeto libere recursos não gerenciados antes de ser coletado pelo coletor de lixo. |

### Modificador new 

O modificador `new` em C# é usado para ocultar um membro herdado de uma classe base. Quando uma classe derivada declara um membro (método, propriedade, campo, etc.) com o mesmo nome de um membro na classe base, o compilador emite um aviso indicando que o membro da classe derivada está ocultando o membro da classe base. Para suprimir esse aviso, você pode usar o modificador `new`.

```csharp
class Animal
{
	public void FazerSom()
	{
		Console.WriteLine("O animal faz um som.");
	}
}
class Cachorro : Animal
{
	public new void FazerSom() // Oculta o método FazerSom da classe base
	{
		Console.WriteLine("O cachorro late.");
	}
}
```

### virtual e override

O operador `virtual` é usado para modificar a declaração de um membro da classe base, substituindo o membro em questão por um membro na classe derivada, que utiliza o modificar `override`, dessa classe base.

### Modificador sealed

Quando aplicado a uma classe, o modificador `sealed` impede que outras classes herdem essa classe.

## Tipos de Herança 

### Herança Simples

Basicamente, é um tipo de herança em que há uma classe base e uma classe derivada, simples.

### Herança Hierárquica

É o tipo de herança em que existem várias classes derivada de uma mesma classe base.

### Herança Multinível

Ocorre quando uma classe é derivada de outra classe derivada, ou seja, é uma cadeia de classes derivadas que tem classes derivadas como sua classe base.

### Herança Múltipla

Ocorre quando temos uma base e uma classe derivada que implementa uma ou mais classes, ou seja, ela é derivada de uma classe base e implementa uma ou mais interfaces.

## Downcasting e Upcasting

### Upcasting

Processo de converter uma classe derivada em um classe base, ou seja, é o processo de "subida" na hierarquia da herança, subir para a classe base. O processo não necessita de conversão explícita.

```cssharp
public class Animal {
    public void Comer() => Console.WriteLine("Animal está comendo");
}

public class Cachorro : Animal {
    public void Latir() => Console.WriteLine("Cachorro está latindo");
}

class Program {
    static void Main() {
        Cachorro c = new Cachorro();

        // Upcasting: tratar um Cachorro como Animal
        Animal a = c; 

        a.Comer();   // ok (Animal)
        // a.Latir(); // erro, porque a referência é Animal
    }
}
```

### Downcasting

Processo inverso ao Upscasting, ou seja, é o processo de "descida" na hierarquia da herança, convertendo uma classe base em uma classe filha. O processo necessita de uma conversão explícita.

```csharp
class Program {
    static void Main() {
        Animal a = new Cachorro();  // objeto real é Cachorro

        // Downcasting: converter Animal de volta para Cachorro
        Cachorro c = (Cachorro)a;  

        c.Comer();  // herdado de Animal
        c.Latir();  // exclusivo de Cachorro
    }
}
```

## Operador is e as 

### Operador as 

Trata-se de um operador de *conversão de tipos*, realizando conversões entre *tipos de referência* e *tipos anuláveis* compatíveis. Caso a conversão seja possível, o operador `as` converte os dados, caso contrário, ele retorna `null`. <br>
É um método comumente utilizado para evitar a ocorrência da exceção *InvalidCastException*.

```csharp
Circulo circulo = new();
Forma forma = circulo;	//upcasting

//Circulo c = (Circulo)forma
Circulo c = forma as Circulo //downcasting
//Tenta converter o objeto forma para um objeto do tipo Circulo
```

### Operador is

Trata-se de um *verificador de tipos*, pois ele, basicamente, faz a comparação entre dois tipos de dados para averiguar se uma conversão entre esses tipos será possível. Ele **Não** converte os tipos, apenas retorna `true` caso seja possível converter e `false` caso não.

### Elvis operator `?.`

Trata-se de um verificador de operações, analisando que "caso o elemento a esquerda seja `null`, retorne null. Caso contrário, realiza a operação a direita do ponto `.` "

## Classe Abstrata

Tratam-se de classes que não podem ser instanciadas, ou seja, não é possível criar objetos a partir dessas classes. <br> Classes e métodos abstratos são caracterizados pelo uso do modificador `abstract`, sendo que os métodos abstratem são nativamente um método `virtual`. 

- Uma classe abstrata pode conter tanto métodos abstratos, quanto métodos instanciados;
- Um método abstrato possui somente a definição de sua assinatura, ou seja, ele não é implementado;
- A implementação do método abstrato é feita na classe derivada e as classes derivadas são obrigadas a implementar os seus métodos abstratos;
- É um erro usar os modificadores `virtual` e `static` em um método abstrato;

## Interfaces

Uma interface é semelhante a uma classe abstrata, mas não podendo conter campos de instância ou construtores, apenas as assinaturas de métodos, eventos propriedades e indexadores, também pode conter métodos públicos e estáticos que contém uma implementação. <br> **Os membros da interface são públicos por padrão** e são úteis para permitir que várias clsses diferentes implementem um conjunto comum de funcionalidades, sem precisar herdar de uma classe base comum.

```csharp

interface IControle
{
	void Desenhar();
}

```