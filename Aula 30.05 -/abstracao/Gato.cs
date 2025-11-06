using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao
{
    internal class Gato : Animal
    {
        private string _vidas;
        private bool _vivo;

        public string Vidas
        {
            get => _vidas;
            set => _vidas = value;
        }


        // Construtor que chama o construtor da classe base Animal
        public Gato(string nome, string sexo, int idade, string vidas) : base(nome, sexo, idade)
        {
            Vidas = vidas; //passando propriedades especificas para o construtor
            _vivo = true;
        }



        //metodo abstratos herdados de Animal e sendo definidos {...} em Gato com sobrescrita
        public override void EmitirSom()
        {
            Console.WriteLine("Miau miau");
        }

        public override void Mover()
        {
            Console.WriteLine("O gato está pulando.");
        }

        public override void Respirar()
        {
            Console.WriteLine("O gato está respirando suavemente.");
        }

        //metodo da propria classe
        public void Brincar()
        {
            Console.WriteLine("O gato está brincando com um novelo de lã.");
        }

        public void Ronronar()
        {
            Console.WriteLine("O gato está ronronando.");
        }

        //reescrita da reescrita do metodo Totring()  (reesc. 1 em animal -> 2 aq em gato)
        public override string ToString()
        {
            return $"Nome: {Nome}, Sexo: {Sexo}, Idade: {Idade} anos, Vidas: {Vidas}";
        }
    }
}
