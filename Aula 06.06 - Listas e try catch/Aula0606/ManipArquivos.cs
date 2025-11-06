//namespace Aula0606
//{
//    internal class ManipArquivos
//    {
//        static void Main(string[] args)
//        {
//                Console.WriteLine("com o tratamento de exceções, eu sigo com o software em execução");

//                //Caso rodew dnv elesobrescreve o arqv
//                // StreamWriter escrever = new StreamWriter("arquivo.txt");
//                StreamWriter escrever = new StreamWriter("C:\\Arquivo\\arquivo.txt");
//                escrever.WriteLine("Escrevendo no arquivo texto");
//                escrever.WriteLine("qualquer coisa");
//                escrever.Close();


//                //Pra nao substituir o conteudo do arquivo colocamos true no arquivo, se não coloque false ou use o exemplo anterior
//                string mensagem;
//                StreamWriter
//                    sw = new StreamWriter("C:\\Arquivo\\pessoas.txt", true); //true para adicionar ao arquivo existente

//                while (true)
//                {
//                    Console.WriteLine("Digite uma mensagem para salvar no arquivo (ou 'sair' para encerrar): ");
//                    mensagem = Console.ReadLine();
//                    if (mensagem.Equals("sair"))
//                    {
//                        break; //sai do loop se o usuário digitar "sair"
//                    }

//                    sw.WriteLine(mensagem); //escreve a mensagem no arquivo
//                }

//                sw.Close(); //fecha o arquivo, é importante fechar o arquivo para garantir que os dados sejam salvos corretamente

//                string linha;
//                StreamReader leitor = new StreamReader("C:\\Arquivo\\texto.txt");
//                linha = leitor.ReadLine();
//                while (linha != null)
//                {
//                    Console.WriteLine(linha); //lê e exibe cada linha do arquivo
//                    linha = leitor.ReadLine(); //lê a próxima linha
//                }
//                leitor.Close(); //fecha o leitor de arquivo
//            }
//        }
//    }
