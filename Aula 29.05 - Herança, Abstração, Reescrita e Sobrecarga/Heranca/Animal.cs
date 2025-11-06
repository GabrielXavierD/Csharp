using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }
        public int NumeroPatas { get; set; }

        //sobrecarga de construtor
        public Animal() { }
        public Animal(string nome, int idade, string especie)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }

        //sobrecarga de metodo
        public void EmitirSom(string som)
        {
            Console.WriteLine($"O animal emite um som: {som}");
        }
        public void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }

        public virtual void Movimentar()
        {
            Console.WriteLine("O animal se movimenta.");
        }
    }
}
