using System;

namespace Laboratorio01
{
    internal class Rectangulo
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }

        public double CalcularBase()
        {
            return Distancia.Calcular(X1, Y1, X2, Y2);
        }

        public double CalcularAltura()
        {
            return Distancia.Calcular(X2, Y2, X3, Y3);
        }

        public double CalcularArea()
        {
            return CalcularBase() * CalcularAltura();
        }

        public double CalcularPerimetro()
        {
            return 2 * (CalcularBase() + CalcularAltura());
        }
    }
}
