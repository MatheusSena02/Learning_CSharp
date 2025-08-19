# Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int. Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

### 1. Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto
### 2. Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110
### 3. Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.
### 4. Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
### 5. Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos : modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)
### 6. Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o método Acelerar passando o valor do argumento para o parâmetro no método Acelerar
## Obs : Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os membros da classe
### 7. Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)
### 8. Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que vai retornar um double representando a velocidade máxima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)
### 9. Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
### 10. Explique o comportamento da palavra return
### 11. Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 3 ao parâmetro recebido)
### 12. Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o comportamento da passagem do argumento por valor
### 13. Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 5 ao parâmetro recebido)
### 14. Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai retornar a nova velocidade como um double. (incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
### 14. Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o comportamento do parâmetro out.
### 15. Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora, Marca, Potencia e Ano e que exiba as informações destes atributos no console.
### 16. Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda chamada.
### 17. Explique o uso do parâmetro opcional e dos argumentos nomeados
### 18. Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para todos os carros
### 19. Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
### 20. Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.