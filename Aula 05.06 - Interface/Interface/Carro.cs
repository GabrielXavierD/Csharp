using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Carro : IVeiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Carro acelerando...");
        }
        public void Ligar()
        {
            Console.WriteLine("Carro ligado.");
        }
    }
}
