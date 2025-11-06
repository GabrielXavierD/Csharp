using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao
{
    internal class Peixe : Animal
    {
        // Construtor que chama o construtor da classe base Animal
        public Peixe(string nome, string sexo, int idade) : base(nome, sexo, idade)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Glub glub");
        }
        public override void Mover()
        {
            Console.WriteLine("O peixe está nadando.");
        }
        public void Nadar()
        {
            Console.WriteLine("O peixe está nadando rapidamente.");
        }

        public void Comer()
        {
            Console.WriteLine("O peixe está comendo algas.");
        }
        public override void Respirar()
        {
            Console.WriteLine("O peixe está respirando através das brânquias.");
        }
    }
}
