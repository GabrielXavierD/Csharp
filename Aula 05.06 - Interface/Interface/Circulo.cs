using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Circulo : IFormasGeometricas
    {
        private double _raio;
        public Circulo(double raio)
        {
            _raio = raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(_raio, 2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * _raio;
        }
    }
}
