using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();

            rect.X1 = 0;
            rect.Y1 = 0;
            rect.X2 = 4;
            rect.Y2 = 0;
            rect.X3 = 4;
            rect.Y3 = 3;
            rect.X4 = 0;
            rect.Y4 = 3;

            Console.WriteLine("Coordenadas del rectángulo:");
            Console.WriteLine($"P1 = ({rect.X1}, {rect.Y1})");
            Console.WriteLine($"P2 = ({rect.X2}, {rect.Y2})");
            Console.WriteLine($"P3 = ({rect.X3}, {rect.Y3})");
            Console.WriteLine($"P4 = ({rect.X4}, {rect.Y4})");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Base: {rect.CalcularBase()}");
            Console.WriteLine($"Altura: {rect.CalcularAltura()}");
            Console.WriteLine($"Área: {rect.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rect.CalcularPerimetro()}");
            Console.WriteLine($"Distancia entre puntos: {Distancia.Calcular(0, 0, 4, 0)}");

            Console.Read();
        }
    }
}
