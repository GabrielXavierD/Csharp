using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuandoEncapsulamentoHeranca
{
    internal class Produto
    {
        public int Codigo { get; init; } //só posso declarar na inicialização
        private string _nome;
        private double _preco;
        private int _quantidade;
        public string Nome //propriedade somente leitura
        {
            get
            {
                return _nome;
            }
        }
        public double Preco//propriedade somente escrita
        {
            set
            {
                _preco = value;
            }
        }

        public int Quantidade
        {
            get;private set;
        }

        public Produto(int c)
         {
         Codigo = c;
        }
        //ctor sniped pra criar o construtor vazio
        public Produto()
        {
        }
    }
}
