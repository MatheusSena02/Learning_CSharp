# Exercícios Fase 1 - Fundamentos

### 1. Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor

`
int idade = 35; 
Console.WriteLine(idade);
`

### 2. Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor

`
string nome =  "Maria";
Console.WriteLine(nome);
`

### 3. Crie uma variável chamada altura e atribua a ela o valor 3.45

`
double altura = 3.45;      
Console.WriteLine(altura);
`

### 4. Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor

`
DateTime data = new DateTime(1999,09,04);      
Console.WriteLine(data);
`

### 5. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor

`
const int ANO = 12;
Console.WriteLine(ANO); 
`

### 6. Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor

`
double ? nota = 7.8;
Console.WriteLine(nota);
`

### 7. Quais as diferenças entre os tipos por valor e os tipos por referência ?

- **Tipos por valor: São dados armazenados diretamente na memória stack, ou seja, para cada variável com valor criada, será alocado um espaço de memória para armazenar aquele valor**
- **Tipos por referência: São dados armazenados na memória heap, ao invés de diretamente na memória stack, esses dados possuem um ponteiro que aponta para o espaço na memória reservado para alocar aquela varíavel e seu valor**

### 8.  Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:


|Questão|Resposta|
|-------|--------|
|( ) x = 10;|Int|
|( ) numero = 7.99;|Double|
|( ) letra = 'C';|Char|
|( ) temperatura = 27.4f;|Float|
|( ) ativo = false;|Bool|
|( ) nome = "Manoel";|String|
|( ) salario = 950.99m;|Decimal|
|( ) hoje = DateTime.Now;|DateTime|

### 9. Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :

|Questão|Resposta|
|-------|--------|
|( ) int n = 1;|Valor (V)|
|( ) string titulo = "A vida";|Referência (R)|
|( ) float f = 12.45f;|Valor (V)|
|( ) double d = 5.45;|Valor (V)|
|( ) decimal valor = 10.99m;|Valor (V)|
|( ) char sexo = ‘M’;| Valor (V)| 
|( ) object o = null;| Referência (R)|

### 10. O que é um nullable type e qual a sua utilidade ?

- **Um Nullable Type é um tipo de dado que permite que tipos de dados primitivos aceitem o valor `null` como seu valor**
- **Torna-se útil quando não se tem conhecimento da presença de valores ou dados. Em um banco de dados por exemplo, quando não se sabe se existe a presença de dados ou não**

### 11. O que é Camel Case ? Dê um exemplo de sua aplicação

- **Camel Case é uma convenção para nomenclatura, que consiste em iniciar a nomenclatura com letras minúsculas com o a primeira letra das palavras subsequenes em maiúsculas**
- **Comumente utilizo para nomear variáveis, parâmetros e campos, como campos internos privados**

### 12. O que é Pascal Case ? Dê um exemplo de sua aplicação.

- **Pascal Case é uma outra convenção de nomenclatura, que consistem em iniciar cada palavra com maiúsculas**
- **Comumente utilizada para nomear classes, namespaces e métodos**

### 13. Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)

`
int x = 77, y = 66;
Console.WriteLine($"Resultado da soma : {x+y}");
`

### 14. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

|Tipo de dado|Valor padrão|
|------------|------------|
|bool| false|
|char|'\0'|
|int|   0|
|double|0|
|float|0|
|decimal|0|
|string|null|

### 15.Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:

|Questão|Resposta|
|--------|----------|
|( ) double 1valor = 12.45;| F|
|( ) string #nome = "Pedro";| F|
|( ) float _temperatura = 12.45f;| V|
|( ) double int = 5;| F |
|( ) decimal renda extra = 91.45m;| F| 
|( ) bool status$conta = false;| F| 
|( ) string titulo3 = “Tópico 1”;| V| 
|( ) float salario_mensal = 1999.55f;| V| 
|( ) int percentualValorDesconto = 5;|V| 
|( ) const bool MENSALIDADE_EM_DIA = true;| V| 