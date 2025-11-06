using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao
{
    internal class Cachorro: Animal
    {
        // Construtor que chama o construtor da classe base Animal -> não há nada dentro do escopo do construtor pois tudo oq é definido vem da classe Pai (base)
        public Cachorro(string nome, string sexo, int idade) : base(nome, sexo, idade)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro está latindo.");
        }
        public override void Mover()
        {
            Console.WriteLine("O cachorro está correndo.");
        }
        public void Brincar()
        {
            Console.WriteLine("O cachorro está brincando.");
        }
    }
}
