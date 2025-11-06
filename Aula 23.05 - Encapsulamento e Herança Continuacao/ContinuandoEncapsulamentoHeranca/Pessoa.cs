using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuandoEncapsulamentoHeranca
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        private bool _maiorIdade;

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }
                _idade = value;
                _maiorIdade = _idade >= 18; // Simplificação da lógica
            }
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value; // value representa o que eu estou atribuindo lá onde eu estou chamando
                }
                else
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
            }
        }

        public bool MaiorIdade => _maiorIdade; // Alterado para ser somente leitura, pois é derivado da idade
    }
}