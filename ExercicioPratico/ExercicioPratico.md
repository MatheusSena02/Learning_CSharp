# Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int. Crie tamb�m o comportamento Acelerar que n�o retorna nada e apenas exiba a mensagem �Acelerando...�

### 1. Exiba os valores dos atributos no console para cada um dos objetos criados e chame o m�todo Acelerar para cada objeto
### 2. Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110
### 3. Altere o m�todo Acelerar para receber um par�metro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto �Acelerando o meu {marca}� , seguido da marca do carro.
### 4. Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
### 5. Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos : modelo, montadora, marco, ano e potencia (use a palavra this para identificar a inst�ncia da classe)
### 6. Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o m�todo Acelerar passando o valor do argumento para o par�metro no m�todo Acelerar
## Obs : Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os membros da classe
### 7. Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (n�o use a palavra-chave this)
### 8. Crie um m�todo chamado VelocidadeMaxima que recebe um par�metro do tipo int chamado potencia que vai retornar um double representando a velocidade m�xima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)
### 9. Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
### 10. Explique o comportamento da palavra return
### 11. Crie um m�todo chamado AumentarPotencia que recebe um par�metro do tipo int por valor chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a pot�ncia incremente 3 ao par�metro recebido)
### 12. Invocar o m�todo criado e passar o valor do argumento por valor e exibir os valores. Explique o comportamento da passagem do argumento por valor
### 13. Crie uma sobrecarga para o m�todo AumentarPotencia que recebe um par�metro do tipo int por refer�ncia chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a pot�ncia incremente 5 ao par�metro recebido)
### 14. Crie um m�todo AumentarPotenciaVelocidade que recebe o par�metro int potencia e retorna um int como valor da nova pot�ncia. Neste m�todo use par�metro out e passe a vari�vel velocidade e que vai retornar a nova velocidade como um double. (incremente a pot�ncia de 7 e calcule a nova velocidade multiplicando a pot�ncia por 1.75)
### 14. Fa�a a chamada ao m�todo exibindo os valores da nova potencia e da nova velocidade e explique o comportamento do par�metro out.
### 15. Crie um m�todo chamado ExibirInfo() que retorna void e que utiliza os par�metros : Modelo, Montadora, Marca, Potencia e Ano e que exiba as informa��es destes atributos no console.
### 16. Para este m�todo defina o par�metro Ano como opcional e fa�a duas chamadas ao m�todo usando o conceito de argumentos nomeados n�o informando o ano na primeira chamada e informando o ano na segunda chamada.
### 17. Explique o uso do par�metro opcional e dos argumentos nomeados
### 18. Crie um campo est�tico ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para todos os carros
### 19. Crie um m�todo est�tico ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
### 20. Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.