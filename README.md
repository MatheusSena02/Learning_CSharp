# Programa��o Orientada a Objetos

## Os pilares da Programa��o Orientada a Objetos

### Abstra��o

A abstra��o � o processo de simplificar um sistema complexo, focando apenas nos aspectos essenciais e ignorando os detalhes irrelevantes. Em POO, a abstra��o permite criar classes que representam conceitos do mundo real, encapsulando atributos e comportamentos relevantes.

### Encapsulamento

O encapsulamento � o princ�pio de esconder os detalhes internos de um objeto e expor apenas uma interface p�blica para interagir com ele. Isso ajuda a proteger o estado interno do objeto, garantindo que ele s� possa ser modificado de maneiras controladas.

### Heran�a

A heran�a � um mecanismo que permite criar novas classes (subclasses) baseadas em classes existentes (superclasses). A subclasse herda atributos e m�todos da superclasse, promovendo a reutiliza��o de c�digo e facilitando a cria��o de hierarquias de classes.

### Polimorfismo

O polimorfismo � a capacidade de diferentes classes responderem de maneira diferente � mesma mensagem ou m�todo. Isso permite que objetos de diferentes tipos sejam tratados de forma uniforme, facilitando a extensibilidade e a manuten��o do c�digo.

## Heran�a

A heran�a � um mecanismo pelo qual uma classe (*conhecida como classe derivada ou subclasse*) pode adquirir propriedades e m�todos de outra classe (*conhecida como classe base ou superclasse*). <br>
A rela��o entre classe a classe *derivada* e a classe *base* � estabelecida atrav�s do `sinal de dois pontos (:)` seguido do nome da classe base, ap�s a declara��o da classe derivada.

```csharp 
class Animal
{
	public void Comer()
	{
		Console.WriteLine("O animal est� comendo.");
	}
}
class Cachorro : Animal
{
	public void Latir()
	{
		Console.WriteLine("O cachorro est� latindo.");
	}
}
``` 

### Classe Object 

No C#, todas as classes herdam implicitamente da classe `Object`, que � a raiz da hierarquia de classes. A classe `Object` fornece m�todos b�sicos que todas as classes herdam.

| M�todo | Descri��o |
|--------|-----------|
| `ToString()` | Retorna uma representa��o em string do objeto. |
| `Equals(object obj)` | Compara o objeto atual com outro objeto para verificar se s�o iguais. |
| `GetHashCode()` | Retorna um c�digo hash para o objeto, usado em estruturas de dados como tabelas hash. |
| `GetType()` | Retorna o tipo do objeto em tempo de execu��o. |
| `MemberwiseClone()` | Cria uma c�pia superficial do objeto atual. |
| `Finalize()` | Permite que um objeto libere recursos n�o gerenciados antes de ser coletado pelo coletor de lixo. |

### Modificador new 

O modificador `new` em C# � usado para ocultar um membro herdado de uma classe base. Quando uma classe derivada declara um membro (m�todo, propriedade, campo, etc.) com o mesmo nome de um membro na classe base, o compilador emite um aviso indicando que o membro da classe derivada est� ocultando o membro da classe base. Para suprimir esse aviso, voc� pode usar o modificador `new`.

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
	public new void FazerSom() // Oculta o m�todo FazerSom da classe base
	{
		Console.WriteLine("O cachorro late.");
	}
}
```

### virtual e override

O operador `virtual` � usado para modificar a declara��o de um membro da classe base, substituindo o membro em quest�o por um membro na classe derivada, que utiliza o modificar `override`, dessa classe base.

### Modificador sealed

Quando aplicado a uma classe, o modificador `sealed` impede que outras classes herdem essa classe.