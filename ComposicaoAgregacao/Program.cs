using ComposicaoAgregacao;

ComportamentoAndar andar = new();
ComportamentoNadar nadar = new();

var homem = new Homem(andar);
homem.Locomocao();

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.Read();