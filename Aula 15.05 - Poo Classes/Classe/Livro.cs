using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class Livro
    {
        public string titulo, autor;
        public int ano;
        public bool emprestado = false;

        public Livro()
        {

        }

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }

        public bool emprestar()
        {
            if (!emprestado)
            {
                emprestado = true;
                Console.WriteLine("Item emprestado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("O item já está emprestado.");
                return false;
            }
        }

        public bool devolver()
        {
            if (emprestado)
            {
                emprestado = false;
                Console.WriteLine("Item devolvido com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("O item já está disponível.");
                return false;
            }
        }
    }
}
