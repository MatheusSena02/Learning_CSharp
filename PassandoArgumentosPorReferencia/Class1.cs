using System;

namespace MedidasCirculares
{
    public class Circulo
    {
        public double CalculaAreaPerimetro(double raio, out double area)
        {
            area = Math.PI * Math.Pow(raio, 2);
            double perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }
}