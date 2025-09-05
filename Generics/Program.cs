using Generics;

Teste teste = new();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

//Comparar <T> (T p1, T p2)

teste.Comparar(i1, i2);
teste.Comparar(f1, f2);
teste.CompararInteiros(f1, i1);

//Por utilizar o tipo genérico, é possível utilizar diversos tipos de dados no método, sem precisar especificar no próprio método da classe


Console.Read();