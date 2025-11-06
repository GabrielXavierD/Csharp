using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuandoEncapsulamentoHeranca
{
    internal class Carro
    {
            private string _marca;
            private string _modelo;
            private int _ano;
            public string Marca { get => _marca; set => _marca = value; }
            public string Modelo { get => _modelo; set => _modelo = value; }
            public int Ano
            {
                get => _ano;
                private set // coloquei como privado, só posso atribuir aqui
                {
                    if (value > 0)
                    {
                        _ano = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ano inválido");
                    }

                }
            }
            public Carro(int ano)
            {
                Ano = ano;
            }
        }
    }
