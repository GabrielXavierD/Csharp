using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class Lampada
    {

        public bool ligada;
        public double potencia;

        //Um metodo construtor sempre tem o nome da classe e ele nunca retorna algo
        public Lampada()
        {

        }
        public Lampada(bool ligada, double potencia)
        {
            this.ligada = ligada;
            this.potencia = potencia;
        }

        public void ligar()
        {
            if (!estaLigada())
            {
                Console.WriteLine("Ligando a lâmpada!");
                ligada = true;
            }
            else
            {
                Console.WriteLine("A lâmpada já está ligada!");
            }

        }

        public void desligar()
        {
            if (estaLigada())
            {
                Console.WriteLine("Desligando a lâmpada!");
                ligada = false;
            }
            else
            {
                Console.WriteLine("A lâmpada já está desligada!");
            }

        }

        public bool estaLigada()
        {
            return ligada;
        }

        public static void MostrarMensagem()
        {
            Console.WriteLine("Metodo estatico - mensagem");
        }
    }
}