using ColecoesSet;

var dataBase = new TimesBrasileiros();
var timesSp = dataBase.TimesSP;
var timesRj = dataBase.TimesRJ;
var timesBa = dataBase.TimesBA;
var timesMundial = dataBase.TimesComMundial;

//Exibe os elementos da lista timesSP e adiciona elemento nessa lista
Console.Write("Lista original: ");
dataBase.ExibeTime(timesSp);
dataBase.AdicionaTime(timesSp, "Madureira");
Console.Write("Lista modificada: ");
dataBase.ExibeTime(timesSp);
dataBase.VerificaSubconjuntos(timesSp, timesMundial);
dataBase.VerificaSuperconjuntos(timesMundial, timesSp);
dataBase.VerificaElementosComuns(timesSp, timesMundial);

//Operações de conjuntos
timesSp.UnionWith(timesRj); //União entre conjuntos
Console.Write("União entre conjuntos nos times de SP e RJ: ");
dataBase.ExibeTime(timesSp);
Console.Write("\nIntersecção entre conjuntos nos times de Mundial e RJ: ");
timesMundial.IntersectWith(timesRj);
dataBase.ExibeTime(timesMundial);
Console.Write("\nIntersecção entre conjuntos nos times de Mundial e BA: ");
timesRj.ExceptWith(timesMundial);
dataBase.ExibeTime(timesRj);

Console.Read();