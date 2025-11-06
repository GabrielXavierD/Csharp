using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0606
{
    internal class Pessoa
    {
        //Faça id, nome e email
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        //Construtor vazio
        public Pessoa()
        {
            Id = 0;
            Nome = string.Empty;
            Email = string.Empty;
        }
        //Construtor com parâmetros
        public Pessoa(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}
