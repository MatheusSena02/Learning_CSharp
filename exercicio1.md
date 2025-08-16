# Exerc�cios Fase 1 - Fundamentos

### 1. Crie uma vari�vel chamada idade e atribua a ela o valor 35 e exiba o seu valor

`
int idade = 35; 
Console.WriteLine(idade);
`

### 2. Crie uma vari�vel chamada nome e atribua o valor "Maria" e exiba o seu valor

`
string nome =  "Maria";
Console.WriteLine(nome);
`

### 3. Crie uma vari�vel chamada altura e atribua a ela o valor 3.45

`
double altura = 3.45;      
Console.WriteLine(altura);
`

### 4. Crie uma vari�vel chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor

`
DateTime data = new DateTime(1999,09,04);      
Console.WriteLine(data);
`

### 5. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor

`
const int ANO = 12;
Console.WriteLine(ANO); 
`

### 6. Declare uma vari�vel nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor

`
double ? nota = 7.8;
Console.WriteLine(nota);
`

### 7. Quais as diferen�as entre os tipos por valor e os tipos por refer�ncia ?

- **Tipos por valor: S�o dados armazenados diretamente na mem�ria stack, ou seja, para cada vari�vel com valor criada, ser� alocado um espa�o de mem�ria para armazenar aquele valor**
- **Tipos por refer�ncia: S�o dados armazenados na mem�ria heap, ao inv�s de diretamente na mem�ria stack, esses dados possuem um ponteiro que aponta para o espa�o na mem�ria reservado para alocar aquela var�avel e seu valor**

### 8.  Inclua o tipo de dados correto entre os par�nteses nas seguintes declara��es de vari�veis:


|Quest�o|Resposta|
|-------|--------|
|( ) x = 10;|Int|
|( ) numero = 7.99;|Double|
|( ) letra = 'C';|Char|
|( ) temperatura = 27.4f;|Float|
|( ) ativo = false;|Bool|
|( ) nome = "Manoel";|String|
|( ) salario = 950.99m;|Decimal|
|( ) hoje = DateTime.Now;|DateTime|

### 9. Dada as vari�veis declaradas a seguir classifique-as em tipos por valor(V) e tipos por refer�ncia (R) :

|Quest�o|Resposta|
|-------|--------|
|( ) int n = 1;|Valor (V)|
|( ) string titulo = "A vida";|Refer�ncia (R)|
|( ) float f = 12.45f;|Valor (V)|
|( ) double d = 5.45;|Valor (V)|
|( ) decimal valor = 10.99m;|Valor (V)|
|( ) char sexo = �M�;| Valor (V)| 
|( ) object o = null;| Refer�ncia (R)|

### 10. O que � um nullable type e qual a sua utilidade ?

- **Um Nullable Type � um tipo de dado que permite que tipos de dados primitivos aceitem o valor `null` como seu valor**
- **Torna-se �til quando n�o se tem conhecimento da presen�a de valores ou dados. Em um banco de dados por exemplo, quando n�o se sabe se existe a presen�a de dados ou n�o**

### 11. O que � Camel Case ? D� um exemplo de sua aplica��o

- **Camel Case � uma conven��o para nomenclatura, que consiste em iniciar a nomenclatura com letras min�sculas com o a primeira letra das palavras subsequenes em mai�sculas**
- **Comumente utilizo para nomear vari�veis, par�metros e campos, como campos internos privados**

### 12. O que � Pascal Case ? D� um exemplo de sua aplica��o.

- **Pascal Case � uma outra conven��o de nomenclatura, que consistem em iniciar cada palavra com mai�sculas**
- **Comumente utilizada para nomear classes, namespaces e m�todos**

### 13. Declare duas vari�veis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritm�tico + para realizar a opera��o de soma)

`
int x = 77, y = 66;
Console.WriteLine($"Resultado da soma : {x+y}");
`

### 14. Quais os valores padr�es dos tipos de dados bool, char, int, double, float, decimal e string.

|Tipo de dado|Valor padr�o|
|------------|------------|
|bool| false|
|char|'\0'|
|int|   0|
|double|0|
|float|0|
|decimal|0|
|string|null|

### 15.Indique verdadeiro(V) ou falso (F) para as seguintes declara��es de vari�veis considerando a nomenclatura usada:

|Quest�o|Resposta|
|--------|----------|
|( ) double 1valor = 12.45;| F|
|( ) string #nome = "Pedro";| F|
|( ) float _temperatura = 12.45f;| V|
|( ) double int = 5;| F |
|( ) decimal renda extra = 91.45m;| F| 
|( ) bool status$conta = false;| F| 
|( ) string titulo3 = �T�pico 1�;| V| 
|( ) float salario_mensal = 1999.55f;| V| 
|( ) int percentualValorDesconto = 5;|V| 
|( ) const bool MENSALIDADE_EM_DIA = true;| V| 