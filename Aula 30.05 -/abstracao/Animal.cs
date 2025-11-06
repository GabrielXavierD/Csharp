using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao
{
    public abstract class Animal
    {
        private string _nome, _sexo;
        private int _idade;

        //se houver construtor aqui, faz com q obrigatoriamente tenha tb nas subclasses
        protected Animal(string nome, string sexo, int idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string Sexo
        {
            get => _sexo;
            set => _sexo = value;
        }
        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }
        public abstract void EmitirSom();
        public abstract void Mover();

        public virtual void Respirar()
        {
            Console.WriteLine("O animal está respirando.");
        }
        // Método virtual que pode ser sobrescrito por classes derivadas, mas não é obrigatório
        public void Dormir()
        {
            Console.WriteLine("O animal está dormindo.");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Sexo: {Sexo}, Idade: {Idade} anos";
        }

    }
}
