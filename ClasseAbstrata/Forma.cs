using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public abstract class Forma
    {
        public string? Cor {  get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        //Métodos Abstratos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        //Método comum
        public string Descrição()
        {
            return "Classe Abstrata";
        }
    }

    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            Area = Math.Pow(Lado, 2);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = 4  * Lado;
            return Perimetro;
        }
    }
}
