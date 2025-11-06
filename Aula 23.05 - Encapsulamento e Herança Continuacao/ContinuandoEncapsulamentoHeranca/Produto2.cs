using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuandoEncapsulamentoHeranca
{
    internal class Produto2
    {
        private string _nome;
        private double _preco;
        private double _imposto;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double Preco
        {
            get => _preco;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Erro: Preço menor que zero");
                }
                else
                {
                    _preco = value;
                }
            }
        }

        public double Imposto
        {
            get => _imposto;
            set => _imposto = value;
        }

        public double PrecoFinal // Nova propriedade para calcular o preço final
        {
            get => _preco + (_preco * _imposto);
        }
    }
}
