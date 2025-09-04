## Programa 1

Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir
do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
quantidade de gasolina a abastecer.(defina isso como uma propriedade)
<br>
Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a
quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.
<br>
O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso
contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do
carro e retornar true.
<br>
Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a
informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
método Dirigir do carro.

## Programa 2

Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
orientada a objetos.
<br>
O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
construtor adicional, com o qual podemos especificar o número de páginas que queremos
no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
64 páginas.
<br>
Por fim, execute as seguintes ações:
- Criar um álbum de fotos padrão e exibir o número de páginas
- Criar um álbum de fotos com 24 páginas e exibir o número de páginas
- Criar um álbum de fotos grande e exibir o número de páginas


## Programa 3

Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
pessoa do tipo Professor.
<br>
Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
construtor que receba o nome como parâmetro e sobrescreva o método ToString().
Então crie mais duas classes que herdam da classe Pessoa, elas serão chamadas de
Aluno e Professor. A classe Aluno possui um método Estudar que escreve pelo console
que o aluno está estudando. A classe Professor terá um método Explicar que grava no
console que o professor está explicando.
<br>
Lembre-se de também criar dois construtores nas classes filhas que chamam o
construtor pai da classe Pessoa.
<br>
Termine o programa lendo as pessoas (o professor e os alunos) e execute os métodos
Explicar e Estudar.

## Programa 4

Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma
matriz de objetos do tipo Pessoa.
<br>
Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
string, um construtor que receba o nome como parâmetro e sobrescreva o método
ToString().
<br>
Finalize o programa lendo as pessoas e executando o método ToString() na tela.