using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunosArquivos
{
    public class Aluno
    {
        private int _id;
        private string _nome;
        private string _matricula;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
    }
}