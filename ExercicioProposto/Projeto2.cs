using System;

namespace Programas
{
    public class LivroFotos
    {
        private int numeropaginas;
        public int NumeroPaginas {  get; set; }

        public LivroFotos()
        {
            numeropaginas = 16;
        }

        public LivroFotos(int paginas)
        {
            numeropaginas = paginas;
        }

        public int  ExibeNumeroPaginas()
        {
            return numeropaginas;
        }
    }

    public class SuperLivroFotos 
    {
        private int numeropaginas;
        public int NumeroPaginas { get; set; }

        public SuperLivroFotos()
        {
            numeropaginas = 64;
        }

        public int  ExibirNumeroPaginas()
        {
            return numeropaginas;
        }
    }
}
