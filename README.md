# Generics e Coleções Genéricas

## Generics

Generics possibilitam o design de classes e métodos que adiam a especificação de um ou mais parâmetros de tipo até que você use a classe ou o método em seu código. Por exemplo, ao usar um parâmetro de tipo genérico T, você pode escrever uma única classe que outro código de cliente pode usar sem incorrer o custo ou risco de conversões de runtime ou operações de conversão boxing. <br>

- Generics permitem a inclusão de mais de um parâmetro de tipos;
- É possível definir restrições nos tipos genéricos, utilizando o operador `where`;


## GetHashCode e Equals

Tratam-se de método da classe `Object` que são usadas para comparar se dois objetos são iguais. Todos os objetos na linguagem C# herdam de `Object`, assim herdando os métodos `GetHashCode` e `Equals` <br>
**Nos tipos definidos pelo usuário é necessário sobrescrever os métodos `GetHashCode` e `Equals` para garantir a igualdade entre dois objetos do tipo seja avaliada de forma correta.***

### GetHashCode

Retorna um valor inteiro (*código hash*) com base nas informações do objeto (*estado do objeto*). <br> Objetos diferentes sempre vão gerar um número diferente para `GetHashCode`, entretanto, códigos *hash* iguais **não significam que os objetos são iguais**, pois podem existir objetos diferentes que podem ter os mesmos códigos *hash*

### Equals

O método Equals por padrão verifica a igualdade de referência, não a igualdade de conteúdo. Isso significa que ele compara se duas variáveis de referência apontam para o mesmo objeto na memória. <br>
Basicamente, ele retorna `true` caso as variáveis apontem para **A MESMA REFERÊNCIA DO OBJETO**, não necessariamente se forem objetos do mesmo tipo.

### Estratégia de comparação entre os objetos

1. Utiliza o método `GetHashCode` para localizar os objetos e verificar se possuem o mesmo código hash, em função do método `GetHashCode` ser mais rápido que o `Equals`
2. Confirmar a igualdade dos objetos usando o método `Equals`gp de o