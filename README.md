﻿# Tipos de Dados 

## `Dados de Referência x Dados de Valor`

**Dados de Referência** : Não armazenam os dados diretamente na memória stack e cada variável contém uma referência (ponteiro) ao local da memória onde os dados estão armazenados. Em função disso,seu valor padrão é **null**

**Dados de Valor** : Os dados são armazenados diretamente na memória stack, ou seja, cada variável contém o próprio valor. Em função disso, seu valor padrão é o valor zero do tipo de dado.

## `Tipos de Dados Numéricos Inteiros`

**Trata-se de dados inteiros, ou seja, dados que possuem casas decimais em sua representação. Basicamente, são valores que não são "quebrados"**

| Tipo   | Intervalo | Tamanho | Tipo .NET |
|--------|-----------|-----------|------------|
| sbyte  | -128 a 127 | Inteiro de 8 bits com sinal | System.SByte |
| byte   | 0 a 255 | Número inteiro sem sinal de 8 bits | System.Byte |
| short  | -32.768 a 32.767 | Inteiro de 16 bits com sinal | System.Int16 |
| ushort | 0 a 65.535 | Inteiro de 16 bits sem sinal | System.UInt16 |
| int    | -2.147.483.648 a 2.147.483.647 | Inteiro assinado de 32 bits | System.Int32 |
| uint   | 0 a 4.294.967.295 | Inteiro de 32 bits sem sinal | System.UInt32 |
| long   | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | Inteiro assinado de 64 bits | System.Int64 |
| ulong  | 0 a 18.446.744.073.709.551.615 | Inteiro de 64 bits sem sinal | System.UInt64 |
| nint   | Depende da plataforma | Inteiro de 32 ou 64 bits com sinal | System.IntPtr |
| nuint  | Depende da plataforma | Inteiro de 32 ou 64 bits sem sinal | System.UIntPtr |

## `Tipos de Dados de Ponto Flutuante`

**Trata-se de dados numéricos diferentes dos inteiros, são os valores que já são representados utilizando casas decimais, ou seja, são os valores "quebrados", como o valor de pi.**

| Tipo    | Intervalo | Precisão aproximada | Tamanho | Tipo .NET       |
|---------|-----------|---------------------|---------|------------------|
| float   | ±1,5 × 10⁻⁴⁵ a ±3,4 × 10³⁸  | ~6 a 9 dígitos       | 4 bytes | System.Single  |
| double  | ±5,0 × 10⁻³²⁴ a ±1,7 × 10³⁰⁸ | ~15 a 17 dígitos     | 8 bytes | System.Double  |
| decimal | ±1,0 × 10⁻²⁸ a ±7,9228 × 10²⁸ | 28 a 29 dígitos      | 16 bytes| System.Decimal |


## `Tipos de Dados Booleano e Char` 

**Dados Booleanos : São tipos de dados lógicos, normalmente resultados de operações de comparações. Tipos de dados booleanos possuem, basicamente, dois valores : True e False**

**Dados Char : A palavra-chave de tipo char é um alias para o tipo de estrutura System.Char em .NET que representa um caractere Unicode UTF-16. O valor padrão do tipo char é \0, ou seja, U+0000.**

| Tipo     | Intervalo/Valores possíveis | Tamanho    | Tipo .NET     |
|----------|-----------------------------|------------|----------------|
| char     | U+0000 a U+FFFF (Unicode)   | 16 bits    | System.Char    |
| bool     | true ou false               | 1 byte*    | System.Boolean |

## `Tipos de Dados de Referência`

**Dados como string, object e dynamic são chamados de dados de referência porque esse tipo de dados não são armazenados diretamente, pois são armazenados na memória heap ou seja, cada variável contém uma referência (ponteiro) para local da memória onde os dados estão armazenados**

## `string`

- Representa uma **sequência de caracteres Unicode**.
- É **imutável**: sempre que você altera uma `string`, uma nova é criada.
- Apesar de parecer um tipo primitivo, é na verdade uma **classe (`System.String`)**.

## `object`
- É o tipo **base de todos os tipos em C#** (classe raiz de `System.Object`).
- **Qualquer valor** (int, string, arrays, classes, etc.) pode ser armazenado em uma variável do tipo `object`. Tipo "coringa".
- Quando armazena um tipo de valor (`int`, `double`, etc.) em um `object`, ocorre **boxing** (armazenamento no heap).
- Para acessar membros específicos, é necessário realizar **casting** (conversão explícita).

---

## `dynamic`
- Tipo **dinâmico** introduzido no C# 4.0 que **ignora a verificação de tipos em tempo de compilação**.
- A resolução dos membros (como propriedades ou métodos) é feita **em tempo de execução**.
- **Aceita qualquer tipo de valor** e pode mudar de tipo ao longo do tempo.
- Muito útil para trabalhar com:
  - **JSON dinâmico**
  - **APIs externas**
  - **Interoperabilidade COM**
  - **ExpandoObject**

> ⚠️ **Atenção**: por não haver verificação em tempo de compilação, erros só aparecem **em tempo de execução**.

<br>

# Tratando com Data e Hora

## `Struct DateTime`
- Representa um momento no tempo expresso como uma data e hora;
- Uma variável do tipo **DateTime** é um tipo de valor e possui um valor padrão, que será `01/01/0001 00:00:00`;
- O padrão de hora e data seguirá a formatação do padrão da localidade identificada no sistema operacional;

## `Extrair informações, como dia, mês, hora, ano, etc` : 

|Métodos|Função|Exemplo|
|-------|------|-------|
| Year  |Extrair o ano| dataAno.Year |
| Month  |Extrair o mês| dataAno.Month |
| Day  |Extrair o dia| dataAno.Day |
| Hour  |Extrair a hora | dataAno.Hour |
| Minute  |Extrair os minutos| dataAno.Minute |
| Second  |Extrair os segundos| dataAno.Second |
| Millisecond  |Extrair os milesegundos| dataAno.Millisecond |

## `Adicionar dias, horas, mês, anos, etc` : 

|Métodos|Função|Exemplo|
|-------|------|-------|
| AddYear  |Adiciona uma quantidade de anos| dataAno.AddYear(valor) |
| AddMonths  |Adiciona uma quantidade de meses| dataAno.AddMonths(valor) |
| AddDays  |Adiciona uma quantidade de dias| dataAno.AddDays(valor) |
| AddHours  |Adiciona uma quantidade de horas| dataAno.AddHours(valor) |

## `Extrair informações saber o dia da semana e do ano, como segunda, terça, etc`

|Métodos|Função|Exemplo|
|-------|------|-------|
| DayOfWeek  |Extrair o dia da semana daquele mês em específico| dataAno.DayOfWeek | dataAno.DayOfWeek |
| DayOfYear |Extrair o dia da semana daquele ano em específico, expressando qual o número daquele dia do ano| dataAno.DayOfYear |

 ## `Expressara formato longo e abreviado`

|Métodos|Função|Exemplo|
|-------|------|-------|
| ToLongDateString  |Expressa a data de forma completa, mostrando o dia da semana, data do mês e ano| ToLongDateString() |;
| ToShortDateString  |Expressa a data de forma resumida, formato padrão de data/mês/ano| ToShortDateString() |;
| ToShortHourString  |Expressa a hora de forma resumida, formato padrão de data/mês/ano| ToShortHourString() |;
| ToLongHourString  |Expressa a hora de forma completa, formato padrão de data/mês/ano| ToLongHourString() |;

<br >

# Nubllable Types ou Tipos Anuláveis

**Basicamente, são de tipos de dados de valor que podem receber um valor **null**. Isso é útil quando você precisa representar a ausência de um valor, como em bancos de dados onde um campo pode ser opcional.**

|Sintaxe|Descrição|
|----------------------|-------------------------------------|
|Nullable< bool >b = null|Suporta os valores true, false e null|

## `Operador ?`

- Para simplificar a declaração de Nullable Types, pode-se utilizar o Operador `?`;
- Nullable Types < bool > a = null pode ser escrito como bool? b = null;
.


## ``Operador ??``

- Por padrão, Nullable Types não podem ser atribuídos a tipos de dados de valor, pois um `int ?` é diferente de um `int`. Então não há a possibilidade de fazer atribuição entre os tipos;
- Para solucionar esse problema, existe o operador `??`, que permite fazer a atribuição entre os diferentes tipos de dados;
- O operador `??` retorna o valor à esquerda se não for nulo; caso contrário, retorna o valor à direita;
- O operador `??` não avalia o operando do lado direito se o operando do lado esquerda não for avaliado como *não nulo*

## `HasValue e Value`

- `HasValue` é uma propriedade que retorna **true** se houver um valor presente e **false** caso não haja um valor (null);
- `Value` é uma propriedade que retorna o valor contido no Nullable Type, mas se não houver um valor, uma exceção será lançada;

# Convenções de Nomenclatura

|Casos de Uso|Convenção|Descrição|
|------------------|------------------|-------------------------------------|
|Variáveis, Parâmetros e Campos|Camel Case|Primeira letra minúscula com as palavras subsequentes iniciando com letra maiúscula|
|Classes, Estruturas, Interfaces e Delegates|Pascal Case|Todas as palavras iniciando com letra maiúscula|
|Constantes|Screaming Snake Case|Todas as letras maiúsculas com palavras separadas por underline (_)|
|Campos Internos Privados e Somente leitura|Camel Case com prefixo `_`|Primeira letra minúscula com as palavras subsequentes iniciando com letra maiúscula, precedido por um underline (_)|

<br>

# Formatação de Saída 

## `Concatenação`

**A concatenação de cadeias de caracteres consiste simplesmente na combinação de dois ou mais valores string em um novo valor string. Ao contrário da adição, o segundo valor é acrescentado ao final do primeiro valor e assim por diante, através do operador de concatenação de cadeia de caracteres, também conhecido como o símbolo de adição `+`**

`
int idade = 21;
string nome = "Matheus";
Console.WriteLine(nome + " tem " + idade + " anos ");
`

## `Interpolação` 

**A interpolação de cadeia de caracteres combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação. Uma expressão de interpolação é indicada por um símbolo de chave de abertura e fechamento { }. Você pode colocar qualquer expressão C# que retorne um valor entre chaves. A cadeia de caracteres literal se torna um modelo quando ele é prefixado pelo caractere `$`**

`
int idade = 21;
string nome = "Matheus";
Console.WriteLine($"{nome} tem {idade} anos");
`

## `Sequências de Escape`

**É uma instrução para o tempo de execução para inserir um caractere especial que afetará a saída da cadeia de caracteres. Em C#, a sequência de caracteres de fuga é declarada por \ (barra invertida), seguida pelo operador que você deseja. Então, por exemplo, \n é um caractere especial que realiza uma quebra de linha, enquanto o \t é um caractere especial que dá uma quebra de espaço** <br>
**Caso haja o desejo de inserir um caminho para uma pasta ou algo semelhante, basta utilizar dupla barra invertida em todas as barras invertidas simples no caminho, ou seja, ao invés de `C:\ProgramData\Adobe\Installer`, deve ser `C:\\ProgramData\\Adobe\\Installer`, para que seja devidamente compilado.**

| Escape       | Descrição                                                                                                  | Código Unicode |
|--------------|------------------------------------------------------------------------------------------------------------|----------------|
| `\a`         | Corresponde a um caractere de sino (alarme)                                                               | `\u0007`       |
| `\b`         | Em classe de caracteres (`[...]`), corresponde a uma **barra invertida**; fora dela, é um **limite de palavra** | `\u0008`       |
| `\t`         | Corresponde a uma tabulação                                                                                | `\u0009`       |
| `\r`         | Corresponde a um retorno de carro (não é igual a nova linha)                                               | `\u000D`       |
| `\v`         | Corresponde a uma tabulação vertical                                                                       | `\u000B`       |
| `\f`         | Corresponde a um avanço de página                                                                          | `\u000C`       |
| `\n`         | Corresponde a uma nova linha                                                                               | `\u000A`       |
| `\e`         | Corresponde a um caractere de escape                                                                       | `\u001B`       |
| `\nnn`       | Caractere ASCII em octal (ex: `\040` é um espaço); se for `\2`, pode ser referência a grupo de captura     | Varia          |
| `\xnn`       | Caractere ASCII com código hexadecimal de dois dígitos (ex: `\x2A`)                                       | Varia          |
| `\cX`        | Caractere de controle ASCII (ex: `\cC` é **CTRL-C**)                                                       | Varia          |
| `\unnnn`     | Unidade de código UTF-16 com valor hexadecimal (ex: `\u03A9` para Ω)                                       | `\unnnn`       |
| `\` + outro  | Se seguido por caractere não especial, corresponde ao próprio caractere (ex: `\*` é um asterisco `*`)     | Varia          |

<br>

# Conversão entre Tipos

- `Conversão Implícita` : Nesse caso, o compilador converte automaticamente um tipo de dados em outro tipo. Mas apenas quando a conversão entre os tipos forem compatíveis.

- `Conversão Explícita` : Nesse caso, a conversão precisa ser feita e declarada manualmente, pois o compilador sozinho não tem como realizar a conversão entre tipos.

- `Implícita x Explícita` : A grande questão envolvendo as diferentes formas de conversão de tipos está relacionada a quantidade de armazenamento exigido por cada tipo. Então, por exemplo, uma conversão de um tipo `int`, que ocupa **4 Bytes** de memória, para um tipo `double`, que ocupa **8 Bytes** de memória, é possível devido ao fato de o tipo `int` ocupar menos espaço que o tipo `double`, logo é possível "encaixar" um tipo dentro do espaço de memória do outro. Já em um processo contrário, não é possível, porque seria algo semelhane a tentar encaixar algo muito grande em um espaço reduzido. 

- `Conversão para String usando o método ToString()` : O método `ToString()` da classe `Object` retorna uma string que representa o objeto atual. E como `Object` é o pai de todos os objetos na linguagem, todos os objetos erdam o método `ToString()` da classe `Object;`

- `Conversão de tipos usando a classe Convert()` : A classe `Convert()` fornece diversos métodos para converter um tipo de dados para outro tipos de dados

|Método|Descrição|
|------|---------|
|ToBoolean()|Converte um tipo para um valor Boolean|
|ToChar()|Converte um tipo para o tipo char|
|ToDouble()|Converte um tipo para o tipo double|
|ToInt16()|Converte um tipo para o tipo int 16-bit|
|ToInt32()|Converte um tipo para o tipo int 32-bit|
|ToString()|Converte um tipo para uma string|

<br>

# Entrada de Dados

- `ReadLine()` : Lê uma única linha de entrada no fluxo de entrada. Retorna a mesma `string`.

- `Read()` : Lê apenas um único caractere do fluxo de entrada padrão. Retorna o `valor ASCII` do caractere.

- `ReadKey()` : Lê apenas um único caractere do fluxo d eentrada, ou seja, obtém a tecla pressionada pelo usuário. Retorna um tipo `ConsoleKeyInfo`.

<br>

# Class Math

**Uma classe que armazena diversas constantes e métodos estáticos utéis para serem utilizados em operações matemáticas**

| Função                                      | Descrição                                                                 |
|---------------------------------------------|---------------------------------------------------------------------------|
| Abs(Decimal)                                | Retorna o valor absoluto de um número de Decimal.                        |
| Abs(Double)                                  | Retorna o valor absoluto de um número de ponto flutuante de precisão dupla. |
| Abs(Int16)                                   | Retorna o valor absoluto de um inteiro com sinal de 16 bits.             |
| Abs(Int32)                                   | Retorna o valor absoluto de um inteiro com sinal de 32 bits.             |
| Abs(Int64)                                   | Retorna o valor absoluto de um inteiro com sinal de 64 bits.             |
| Abs(IntPtr)                                  | Retorna o valor absoluto de um inteiro com sinal nativo.                 |
| Abs(SByte)                                   | Retorna o valor absoluto de um inteiro com sinal de 8 bits.              |
| Abs(Single)                                  | Retorna o valor absoluto de um número de ponto flutuante de precisão única. |
| Acos(Double)                                 | Retorna o ângulo cujo cosseno é o número especificado.                   |
| Acosh(Double)                                | Retorna o ângulo cujo cosseno hiperbólico é o número especificado.       |
| Asin(Double)                                 | Retorna o ângulo cujo seno é o número especificado.                      |
| Asinh(Double)                                | Retorna o ângulo cujo seno hiperbólico é o número especificado.          |
| Atan(Double)                                 | Retorna o ângulo cuja tangente é o número especificado.                  |
| Atan2(Double, Double)                        | Retorna o ângulo cuja tangente é o quociente de dois números especificados. |
| Atanh(Double)                                | Retorna o ângulo cuja tangente hiperbólica é o número especificado.      |
| BigMul(Int32, Int32)                         | Produz o produto completo de dois números de 32 bits.                    |
| BigMul(Int64, Int64, Int64)                  | Produz o produto completo de dois números de 64 bits.                    |
| BigMul(UInt64, UInt64, UInt64)               | Produz o produto completo de dois números de 64 bits sem sinal.          |
| BitDecrement(Double)                         | Retorna o maior valor que compara menos do que um valor especificado.    |
| BitIncrement(Double)                         | Retorna o menor valor que compara maior que um valor especificado.       |
| Cbrt(Double)                                 | Retorna a raiz do cubo de um número especificado.                        |
| Ceiling(Decimal)                             | Retorna o menor valor integral maior ou igual ao número decimal especificado. |
| Ceiling(Double)                              | Retorna o menor valor integral maior ou igual ao número de ponto flutuante de precisão dupla especificado. |
| Clamp(Byte, Byte, Byte)                      | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Decimal, Decimal, Decimal)             | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Double, Double, Double)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Int16, Int16, Int16)                   | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Int32, Int32, Int32)                   | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Int64, Int64, Int64)                   | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(IntPtr, IntPtr, IntPtr)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(SByte, SByte, SByte)                   | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(Single, Single, Single)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(UInt16, UInt16, UInt16)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(UInt32, UInt32, UInt32)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(UInt64, UInt64, UInt64)                | Retorna value fixado ao intervalo inclusivo de min e max.                |
| Clamp(UIntPtr, UIntPtr, UIntPtr)             | Retorna value fixado ao intervalo inclusivo de min e max.                |
| CopySign(Double, Double)                     | Retorna um valor com a magnitude de x e o sinal de y.                    |
| Cos(Double)                                  | Retorna o cosseno do ângulo especificado.                                |
| Cosh(Double)                                 | Retorna o cosseno hiperbólico do ângulo especificado.                    |
| DivRem(Byte, Byte)                           | Produz o quociente e o restante de dois números de 8 bits não assinados. |
| DivRem(Int16, Int16)                         | Produz o quociente e o restante de dois números assinados de 16 bits.    |
| DivRem(Int32, Int32)                         | Produz o quociente e o restante de dois números assinados de 32 bits.    |
| DivRem(Int32, Int32, Int32)                  | Calcula o quociente e retorna o restante em um parâmetro de saída.       |
| DivRem(Int64, Int64)                         | Produz o quociente e o restante de dois números assinados de 64 bits.    |
| DivRem(Int64, Int64, Int64)                  | Calcula o quociente e retorna o restante em um parâmetro de saída.       |
| DivRem(IntPtr, IntPtr)                       | Produz o quociente e o restante de dois números de tamanho nativo assinados. |
| DivRem(SByte, SByte)                         | Produz o quociente e o restante de dois números assinados de 8 bits.     |
| DivRem(UInt16, UInt16)                       | Produz o quociente e o restante de dois números de 16 bits não assinados.|
| DivRem(UInt32, UInt32)                       | Produz o quociente e o restante de dois números de 32 bits não assinados.|
| DivRem(UInt64, UInt64)                       | Produz o quociente e o restante de dois números de 64 bits não assinados.|
| DivRem(UIntPtr, UIntPtr)                     | Produz o quociente e o restante de dois números nativos não assinados.   |
| Exp(Double)                                  | Retorna e gerados para a potência especificada.                          |
| Floor(Decimal)                               | Retorna o maior valor integral menor ou igual ao número decimal especificado. |
| Floor(Double)                                | Retorna o maior valor integral menor ou igual ao número de ponto flutuante de precisão dupla especificado. |
| FusedMultiplyAdd(Double, Double, Double)     | Retorna (x * y) + z, arredondado como uma operação ternária.             |
| IEEERemainder(Double, Double)                | Retorna o restante da divisão IEEE.                                      |
| ILogB(Double)                                | Retorna o logaritmo inteiro base 2.                                      |
| Log(Double)                                  | Retorna o logaritmo natural.                                             |
| Log(Double, Double)                          | Retorna o logaritmo em uma base especificada.                            |
| Log10(Double)                                | Retorna o logaritmo base 10.                                             |
| Log2(Double)                                 | Retorna o logaritmo base 2.                                              |
| Max(...)                                     | Retorna o maior de dois valores (múltiplas sobrecargas).                 |
| MaxMagnitude(Double, Double)                 | Retorna a magnitude maior entre dois números.                            |
| Min(...)                                     | Retorna o menor de dois valores (múltiplas sobrecargas).                 |
| MinMagnitude(Double, Double)                 | Retorna a menor magnitude entre dois números.                            |
| Pow(Double, Double)                          | Retorna x elevado à potência y.                                          |
| ReciprocalEstimate(Double)                   | Estimativa da recíproca de um número.                                    |
| ReciprocalSqrtEstimate(Double)               | Estimativa da raiz quadrada recíproca.                                   |
| Round(...)                                   | Arredonda um número (múltiplas sobrecargas).                             |
| ScaleB(Double, Int32)                        | Retorna x * 2^n de forma eficiente.                                      |
| Sign(...)                                    | Retorna um inteiro que indica o sinal de um número (múltiplas sobrecargas). |
| Sin(Double)                                  | Retorna o seno.                                                          |
| SinCos(Double)                               | Retorna seno e cosseno.                                                  |
| Sinh(Double)                                 | Retorna o seno hiperbólico.                                              |
| Sqrt(Double)                                 | Retorna a raiz quadrada.                                                 |
| Tan(Double)                                  | Retorna a tangente.                                                      |
| Tanh(Double)                                 | Retorna a tangente hiperbólica.                                          |
| Truncate(Decimal)                            | Retorna a parte inteira de um decimal.                                   |
| Truncate(Double)                             | Retorna a parte inteira de um número de ponto flutuante.                 |

<br>

# Inferência de Tipo

**Consiste em uma técnica para declaração de variável, que consiste em declarar uma variável utilizando var ao invés do tipo do dado. Ela é chamada de implícita, pois o que vai definir o tipo daquela variável é o valor atribuído a ela na declaração, então se declarar um `var nome = “Sérgio”`, essa variável será um tipo string.**

**O processo de declarar uma variável e seu valor é normalmente denominado de set, normalmente “setamos” uma variável, enquanto o processo de “pegar” uma variável, obter o seu valor, é normalmente denominada `get`**

- **Os tipos da variável declarada com `var` não pode ser alterado posteriormente**;
- **A variável desse ser teclarada e imediatamente ter seu valor setado, apenas não poder setar o valor `null`, pois o mesmo não é aceito nesse caso**;

<br> 

# Operadores de Atribuição 

| Operador     | Nome                        | Descrição                                                                 |
|--------------|-----------------------------|---------------------------------------------------------------------------|
| `=`          | Atribuição simples           | Atribui o valor do operando da direita à variável à esquerda.            |
| `+=`         | Adição e atribuição          | Soma o operando da direita ao da esquerda e atribui o resultado.         |
| `-=`         | Subtração e atribuição       | Subtrai o operando da direita do da esquerda e atribui o resultado.      |
| `*=`         | Multiplicação e atribuição   | Multiplica os operandos e atribui o resultado à variável à esquerda.     |
| `/=`         | Divisão e atribuição         | Divide o operando da esquerda pelo da direita e atribui o resultado.     |
| `%=`         | Módulo e atribuição          | Calcula o resto da divisão e atribui à variável à esquerda.              |
| `&=`         | AND bit a bit e atribuição   | Executa um AND bit a bit e atribui o resultado.                          |
| `|=`         | OR bit a bit e atribuição    | Executa um OR bit a bit e atribui o resultado.                           |
| `^=`         | XOR bit a bit e atribuição   | Executa um XOR bit a bit e atribui o resultado.                          |
| `<<=`        | Deslocamento à esquerda      | Desloca os bits para a esquerda e atribui o resultado.                   |
| `>>=`        | Deslocamento à direita       | Desloca os bits para a direita e atribui o resultado.                    |
| `??=`        | Atribuição condicional nula  | Atribui valor apenas se a variável for `null`.                           |

<br>

# Constantes

**São valores imutáveis que são conhecidos em tempo de compilação e não podem ser alterados durante a execução do programa. Normalmente são utilizadas para valores que não serão modificados, como em cálculos matemáticos. Elas são declaradas usando a palavra-chave `const` seguida pelo tipo de dado e o nome da constante, elas devem ser inicializadas durante sua declaração.**


# Incremento

### Conceito

- **Pré-incremento (`++x`)**: A variável é incrementada **antes** de seu valor ser usado na expressão.
- **Pós-incremento (`x++`)**: A variável é incrementada **depois** de seu valor ser usado na expressão.

## Exemplo comparativo

```csharp
int value = 1;
value++;
Console.WriteLine("First: " + value); //Saída: 2 
Console.WriteLine($"Second: {value++}"); //Saída: 2 (primeiro opera, depois incrementa)
Console.WriteLine("Third: " + value); //Saída: 3 (valor já incrementado)
Console.WriteLine("Fourth: " + (++value)); //Saída: 4 (incrementa antes de operar)
```

<br>

# Operadores Lógicos

| Operador | Nome                             | Descrição                                                                                         | Exemplo                                         | Resultado do Exemplo |
|----------|----------------------------------|---------------------------------------------------------------------------------------------------|--------------------------------------------------|----------------------|
| `!`      | Negação lógica                   | Inverte o valor booleano da expressão.                                                           | `!true`                                         | `false`              |
| `&`      | AND lógico                       | Retorna `true` se **ambas** as expressões forem `true`. Avalia **sempre** ambos os lados.        | `true & false`                                  | `false`              |
| `^`      | OR exclusivo lógico (XOR)        | Retorna `true` se **somente uma** das expressões for `true`.                                     | `true ^ false`                                  | `true`               |
| `|`      | OR lógico                        | Retorna `true` se **pelo menos uma** das expressões for `true`. Avalia ambos os lados.           | `false | true`                                  | `true`               |
| `&&`     | AND lógico condicional           | Retorna `true` se **ambas** as expressões forem `true`. Avaliação **curta** (short-circuit).     | `true && false`                                 | `false`              |
| `||`     | OR lógico condicional            | Retorna `true` se **pelo menos uma** das expressões for `true`. Avaliação **curta**.             | `false || true`                                 | `true`               |

### Tabela Verdade dos Operadores Lógicos em C#

| A     | B     | !A    | A & B | A | B | A ^ B | A && B | A || B |
|-------|-------|-------|-------|------|--------|--------|--------|
| true  | true  | false | true  | true | false  | true   | true   |
| true  | false | false | false | true | true   | false  | true   |
| false | true  | true  | false | true | true   | false  | true   |
| false | false | true  | false | false| false  | false  | false  |

<br>

# Nullable Reference Types

**Introduzido no C# 8.0, permite que você declare se uma referência pode ou não ser nula. Isso ajuda a evitar erros comuns de referência nula. Principalmente evitar o erro `System.NullReferenceException`**

- **Para inibir o alerta, pode-se usar o tipo `Nullable(?)` ao atribuir o valor `null`**;
- **Além de emprega o `Null Conditional Operator(?.)` ao acessar a referência**;

**Utilizar esses operadores inibem a eminência de erros de referência nula, pois o compilador não irá mais acusar erro caso a variável seja nula, mas sim retornará `null` caso a variável não tenha sido inicializada.**

<br>

# Operador Ternário 

- `Operadores Uniários` : São operadores que atuam em apenas um operando em uma expressão, como `++`, `--`, `!` e etc;
- `Operadores Binários` : São operadores que atuam em dois operandos em uma expressão, como `+`, `-`, `*`, `/`, `&&`, `==` e etc;
- `Operador Ternário` : É um operador que atuam com três operadores e avalia uma expressão booleana, utilizando o operador `?:` para retornar um valor se a expressão for verdadeira e outro valor se a expressão for falsa. É uma forma concisa de escrever uma estrutura condicional `if-else`.`

### `Operador ?:`

**Avalia uma expressão booleana e retorna o resultado de uma das duas expressões, dependendo do resultado da avaliação.**
```csharp
condição ? expressão_se_verdadeira : expressão_se_falsa;
```