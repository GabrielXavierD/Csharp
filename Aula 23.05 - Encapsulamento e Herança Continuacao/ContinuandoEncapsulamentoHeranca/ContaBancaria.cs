using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuandoEncapsulamentoHeranca
{
    internal class ContaBancaria
    {
        private double _numeroConta, _saldo;
        private string _titular;

        public ContaBancaria(string titular)
        {
            _titular = titular;
            _saldo = 0;
            _numeroConta = GerarNumeroConta();
        }

        public double NumeroConta
        {
            get { return _numeroConta; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        private double GerarNumeroConta()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }
    }
}
