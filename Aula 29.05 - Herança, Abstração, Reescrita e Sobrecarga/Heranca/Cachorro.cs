using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Cachorro : Mamifero
    {
        public string Raca { get; set; }
        //sobrescrita de construtor herdado com :base
        public override void Movimentar()
        {
            Console.WriteLine("O cachorro corre e pula.");
        }

        public void BuscarOsso()
        {
            Console.WriteLine($"{Nome} está buscando um osso.");
        }
    }
}
