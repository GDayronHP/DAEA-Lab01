using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public double CalcularIGV()
        {
            return Precio * 0.18;
        }

        public double CalcularDescuento()
        {
            return Precio * 0.1;
        }

        public double CalcularPrecioFinal()
        {
            return Precio + CalcularIGV() - CalcularDescuento();
        }
    }
}
