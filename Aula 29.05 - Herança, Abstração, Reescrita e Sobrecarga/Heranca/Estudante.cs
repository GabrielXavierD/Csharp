using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Estudante : Pessoa
    {
        private string _matricula;
        public Estudante()
        {
        }
        public Estudante(string nome, int idade, string cpf, string matricula) : base(nome, idade, cpf)
        {
            _matricula = matricula;
        }

        public override string ToString()
        {
            return base.ToString() + $", Matrícula: {_matricula}";
        }
    }
}
