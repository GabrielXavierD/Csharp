using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0606
{
    internal class MainArquivo
    {
        static void Main(string[] args)
        {

            //string nome, mensagem;
            //Console.WriteLine("Digite o nome do arquivo: ");
            //nome = Console.ReadLine();
            //Arquivo arquivo = new Arquivo(nome);
            //try
            //{
            //    arquivo.AbrirArquivo();
            //    Console.WriteLine("Digite uma mensagem para salvar no arquivo (ou 'sair' para encerrar): ");
            //    mensagem = Console.ReadLine();
            //    while (!mensagem.Equals("sair"))
            //    {
            //        arquivo.mensagem = mensagem;
            //        arquivo.EscreverArquivo();
            //        Console.WriteLine("Mensagem salva. Digite outra mensagem (ou 'sair' para encerrar): ");
            //        mensagem = Console.ReadLine();
            //    }
            //    arquivo.LerArquivo();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ocorreu um erro: " + ex.Message);
            //}

            string nome, mensagem;
            Console.WriteLine("Digite o nome do arquivo: ");
            nome = Console.ReadLine();
            Arquivo arquivo = new Arquivo(nome);
            int op;
            while (true)
            {
                Console.WriteLine("Menu do sistema de anotações:");
                Console.WriteLine("1 - para escrever uma anotação");
                Console.WriteLine("2 - para ler uma anotação");
                Console.WriteLine("0 - para sair do sistema");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    arquivo.AbrirArquivo();
                    Console.WriteLine("Digite uma mensagem para ser armazenada: ");
                    Console.WriteLine("Digite SAIR para finalizar");
                    while (true)
                    {
                        mensagem = Console.ReadLine();
                        if (mensagem.Equals("SAIR"))
                        {
                            arquivo.FecharArquivo();
                            break;
                        }
                        arquivo.GravarMensagem(mensagem);
                    }
                }
                else if (op == 2)
                {
                    arquivo.LerArquivo();
                }
                else if (op == 0)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
        }
    }
}
