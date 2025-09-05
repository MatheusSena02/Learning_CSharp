# Generics e Cole��es Gen�ricas

## Generics

Generics possibilitam o design de classes e m�todos que adiam a especifica��o de um ou mais par�metros de tipo at� que voc� use a classe ou o m�todo em seu c�digo. Por exemplo, ao usar um par�metro de tipo gen�rico T, voc� pode escrever uma �nica classe que outro c�digo de cliente pode usar sem incorrer o custo ou risco de convers�es de runtime ou opera��es de convers�o boxing. <br>

- Generics permitem a inclus�o de mais de um par�metro de tipos;
- � poss�vel definir restri��es nos tipos gen�ricos, utilizando o operador `where`;


## GetHashCode e Equals

Tratam-se de m�todo da classe `Object` que s�o usadas para comparar se dois objetos s�o iguais. Todos os objetos na linguagem C# herdam de `Object`, assim herdando os m�todos `GetHashCode` e `Equals` <br>
**Nos tipos definidos pelo usu�rio � necess�rio sobrescrever os m�todos `GetHashCode` e `Equals` para garantir a igualdade entre dois objetos do tipo seja avaliada de forma correta.***

### GetHashCode

Retorna um valor inteiro (*c�digo hash*) com base nas informa��es do objeto (*estado do objeto*). <br> Objetos diferentes sempre v�o gerar um n�mero diferente para `GetHashCode`, entretanto, c�digos *hash* iguais **n�o significam que os objetos s�o iguais**, pois podem existir objetos diferentes que podem ter os mesmos c�digos *hash*

### Equals

O m�todo Equals por padr�o verifica a igualdade de refer�ncia, n�o a igualdade de conte�do. Isso significa que ele compara se duas vari�veis de refer�ncia apontam para o mesmo objeto na mem�ria. <br>
Basicamente, ele retorna `true` caso as vari�veis apontem para **A MESMA REFER�NCIA DO OBJETO**, n�o necessariamente se forem objetos do mesmo tipo.

### Estrat�gia de compara��o entre os objetos

1. Utiliza o m�todo `GetHashCode` para localizar os objetos e verificar se possuem o mesmo c�digo hash, em fun��o do m�todo `GetHashCode` ser mais r�pido que o `Equals`
2. Confirmar a igualdade dos objetos usando o m�todo `Equals`gp de o