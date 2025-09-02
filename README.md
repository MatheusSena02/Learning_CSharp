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