using System.ComponentModel;
using CadastroAlunosArquivo;
using CadastroAlunosArquivos;

namespace CadastroAlunosArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/ricardofrohlich/CadastroAlunosArquivos
            //lombok

            string nomeArquivo, mensagem;
            Console.WriteLine("Cadastro de alunos da INFNET");
            Console.WriteLine("------------------------------");
            Console.Write("Digite o nome do arquivo: ");
            nomeArquivo = Console.ReadLine();
            Arquivo arquivo = new Arquivo(nomeArquivo);
            List<Aluno> alunos = new List<Aluno>();
            string[] pessoas = arquivo.LerTodasAsLinhas();
            for (int i = 0; i < pessoas.Length; i++)
            {
                string[] dados = pessoas[i].Split(',');
                Aluno aluno = new Aluno
                {
                    Id = int.Parse(dados[0]),
                    Nome = dados[1],
                    Matricula = dados[2]
                };
                alunos.Add(aluno);
            }

            while (true)
            {
                Console.WriteLine("Menu do sistema: ");
                Console.WriteLine("1 - Cadastrar um aluno");
                Console.WriteLine("2 - Listar todos os alunos");
                Console.WriteLine("3 - Sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Aluno aluno = new Aluno();
                    Console.WriteLine("Digite o ID do aluno: ");
                    aluno.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do aluno: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a matrícula do aluno: ");
                    aluno.Matricula = Console.ReadLine();
                    alunos.Add(aluno);
                    arquivo.CriaAbreArquivo();
                    arquivo.Escrever(aluno.Id + "," + aluno.Nome + "," + aluno.Matricula);
                    arquivo.FechaArquivo();
                }
                else if (op == 2)
                {
                    foreach (Aluno a in alunos)
                    {
                        Console.WriteLine("ID: " + a.Id + " Nome: " + a.Nome + " Matrícula: " + a.Matricula);
                    }
                }
                else if (op == 3)
                {
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