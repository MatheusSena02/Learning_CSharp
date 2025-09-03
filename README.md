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

## Tipos de Heran�a 

### Heran�a Simples

Basicamente, � um tipo de heran�a em que h� uma classe base e uma classe derivada, simples.

### Heran�a Hier�rquica

� o tipo de heran�a em que existem v�rias classes derivada de uma mesma classe base.

### Heran�a Multin�vel

Ocorre quando uma classe � derivada de outra classe derivada, ou seja, � uma cadeia de classes derivadas que tem classes derivadas como sua classe base.

### Heran�a M�ltipla

Ocorre quando temos uma base e uma classe derivada que implementa uma ou mais classes, ou seja, ela � derivada de uma classe base e implementa uma ou mais interfaces.

## Downcasting e Upcasting

### Upcasting

Processo de converter uma classe derivada em um classe base, ou seja, � o processo de "subida" na hierarquia da heran�a, subir para a classe base. O processo n�o necessita de convers�o expl�cita.

```cssharp
public class Animal {
    public void Comer() => Console.WriteLine("Animal est� comendo");
}

public class Cachorro : Animal {
    public void Latir() => Console.WriteLine("Cachorro est� latindo");
}

class Program {
    static void Main() {
        Cachorro c = new Cachorro();

        // Upcasting: tratar um Cachorro como Animal
        Animal a = c; 

        a.Comer();   // ok (Animal)
        // a.Latir(); // erro, porque a refer�ncia � Animal
    }
}
```

### Downcasting

Processo inverso ao Upscasting, ou seja, � o processo de "descida" na hierarquia da heran�a, convertendo uma classe base em uma classe filha. O processo necessita de uma convers�o expl�cita.

```csharp
class Program {
    static void Main() {
        Animal a = new Cachorro();  // objeto real � Cachorro

        // Downcasting: converter Animal de volta para Cachorro
        Cachorro c = (Cachorro)a;  

        c.Comer();  // herdado de Animal
        c.Latir();  // exclusivo de Cachorro
    }
}
```

## Operador is e as 

### Operador as 

Trata-se de um operador de *convers�o de tipos*, realizando convers�es entre *tipos de refer�ncia* e *tipos anul�veis* compat�veis. Caso a convers�o seja poss�vel, o operador `as` converte os dados, caso contr�rio, ele retorna `null`. <br>
� um m�todo comumente utilizado para evitar a ocorr�ncia da exce��o *InvalidCastException*.

```csharp
Circulo circulo = new();
Forma forma = circulo;	//upcasting

//Circulo c = (Circulo)forma
Circulo c = forma as Circulo //downcasting
//Tenta converter o objeto forma para um objeto do tipo Circulo
```

### Operador is

Trata-se de um *verificador de tipos*, pois ele, basicamente, faz a compara��o entre dois tipos de dados para averiguar se uma convers�o entre esses tipos ser� poss�vel. Ele **N�o** converte os tipos, apenas retorna `true` caso seja poss�vel converter e `false` caso n�o.

### Elvis operator `?.`

Trata-se de um verificador de opera��es, analisando que "caso o elemento a esquerda seja `null`, retorne null. Caso contr�rio, realiza a opera��o a direita do ponto `.` "

## Classe Abstrata

Tratam-se de classes que n�o podem ser instanciadas, ou seja, n�o � poss�vel criar objetos a partir dessas classes. <br> Classes e m�todos abstratos s�o caracterizados pelo uso do modificador `abstract`, sendo que os m�todos abstratem s�o nativamente um m�todo `virtual`. 

- Uma classe abstrata pode conter tanto m�todos abstratos, quanto m�todos instanciados;
- Um m�todo abstrato possui somente a defini��o de sua assinatura, ou seja, ele n�o � implementado;
- A implementa��o do m�todo abstrato � feita na classe derivada e as classes derivadas s�o obrigadas a implementar os seus m�todos abstratos;
- � um erro usar os modificadores `virtual` e `static` em um m�todo abstrato;

## Interfaces

Uma interface � semelhante a uma classe abstrata, mas n�o podendo conter campos de inst�ncia ou construtores, apenas as assinaturas de m�todos, eventos propriedades e indexadores, tamb�m pode conter m�todos p�blicos e est�ticos que cont�m uma implementa��o. <br> **Os membros da interface s�o p�blicos por padr�o** e s�o �teis para permitir que v�rias clsses diferentes implementem um conjunto comum de funcionalidades, sem precisar herdar de uma classe base comum.

```csharp

interface IControle
{
	void Desenhar();
}

```