using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Mamifero: Animal
    {
        private bool _produzLeite;
        public bool ProduzLeite
        {
            get { return _produzLeite; }
            set { _produzLeite = value; }
        }
        public void verificarSeProduzLeite()
        {
            if (_produzLeite)
            {
                Console.WriteLine($"{Nome} produz leite.");
            }
            else
            {
                Console.WriteLine($"{Nome} não produz leite.");
            }
        }
    }
}
