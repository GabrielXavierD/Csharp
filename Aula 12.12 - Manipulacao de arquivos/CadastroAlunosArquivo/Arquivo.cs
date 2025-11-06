using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunosArquivo
{
    public class Arquivo
    {
        private string _nomeArquivo;
        private StreamWriter _sw { get; set; } // escrita no arquivo
        private StreamReader _sr { get; set; } // leitura do arquivo
        public string NomeArquivo
        {
            get => _nomeArquivo;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome do arquivo não pode ser vazio ou nulo.");
                }
                _nomeArquivo = value;
            }
        }
        public Arquivo(string nome)
        {
            NomeArquivo = nome;
        }
        public void CriaAbreArquivo()
        {
            try
            {
                _sw = new StreamWriter(NomeArquivo + ".txt", true, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao criar ou abrir o arquivo: {ex.Message}");
            }
        }

        public void FechaArquivo()
        {
            try
            {
                _sw.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao fechar o arquivo: {ex.Message}");
            }
        }
        public void Escrever(string conteudo)
        {
            if (_sw == null)
            {
                throw new InvalidOperationException("O arquivo não foi aberto. Chame CriaAbreArquivo primeiro.");
            }
            try
            {
                _sw.WriteLine(conteudo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao escrever no arquivo: {ex.Message}");
            }
        }

        public void LerArquivo()
        {
            string linha;
            try
            {
                //salvando como padrao utf8
                _sr = new StreamReader(NomeArquivo + ".txt", Encoding.UTF8);
                linha = _sr.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = _sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao ler o arquivo: {ex.Message}");
            }
            finally
            {
                _sr?.Close();
            }
        }

        public string[] LerTodasAsLinhas() // lê as linhas e retorna em um vetor
        {
            string caminho = NomeArquivo + ".txt";
            if (!File.Exists(caminho))
            {
                // Retorna um array vazio se o arquivo não existir
                return Array.Empty<string>();
            }
            return File.ReadAllLines(caminho, Encoding.UTF8);
        }
    }
}
