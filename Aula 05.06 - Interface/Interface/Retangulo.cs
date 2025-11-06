using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Retangulo : IFormasGeometricas
    {
        private double _largura;
        private double _altura;
        public Retangulo(double largura, double altura)
        {
            _largura = largura;
            _altura = altura;
        }
        public double CalcularArea()
        {
            return _largura * _altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (_largura + _altura);
        }
    }
}
