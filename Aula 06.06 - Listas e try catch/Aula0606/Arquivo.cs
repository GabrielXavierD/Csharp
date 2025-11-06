using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0606
{
    internal class Arquivo
    {

        private string _nome; //nome do arquivo
        private StreamWriter _sw; //para escrever no arquivo
        private StreamReader _sr; //para ler o arquivo
        public string mensagem; //mensagem a ser escrita no arquivo

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome do arquivo não pode ser vazio ou nulo."); //lançando uma exceção se o nome for inválido
                }
                _nome = value;
            }
        }
        public Arquivo(string nome)
        {
            Nome = nome;
        }
        public void LerArquivo()
        {
            string linha; //variável para armazenar cada linha lida do arquivo
            try
            {
                _sr = new StreamReader("C:\\Arquivo\\" + Nome + ".txt"); //abre o arquivo para leitura
                linha = _sr.ReadLine(); //lê a linha do arquivo
                while (linha != null) //enquanto houver linhas para ler
                {
                    linha = _sr.ReadLine(); //lê a linha do arquivo
                    Console.WriteLine(linha); //exibe a linha no console
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Erro: Arquivo não encontrado. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
            }
            finally
            {
                _sr.Close(); //fecha o arquivo
            }
        }
        public void AbrirArquivo()
        {
            try
            {
                _sw = new StreamWriter("C:\\Arquivo\\" + Nome + ".txt", true); //abre o arquivo para escrita (append)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir o arquivo para escrita: " + ex.Message);
            }
        }
        public void GravarMensagem(string mensagem)
        {
            _sw.WriteLine(mensagem); //escreve a mensagem no arquivo
        }
        public void FecharArquivo()
        {
            try
            {
                _sw.Close(); //fecha o arquivo
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar o arquivo: " + ex.Message);
            }
        }
    }
}
