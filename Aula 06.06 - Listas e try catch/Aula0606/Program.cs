//namespace Aula0606
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int op;
//            List<Pessoa> pessoas = new List<Pessoa>();
//            while (true)
//            {
//                Console.WriteLine("Cadastro de pessoas: ");
//                Console.WriteLine("Digite: ");
//                Console.WriteLine("1 - Cadastrar uma pessoa");
//                Console.WriteLine("2 - Ler todas as pessoas");
//                op = int.Parse(Console.ReadLine());
//                if (op == 1)
//                {
//                    Pessoa pessoa = new Pessoa();
//                    Console.WriteLine("Digite o id da pessoa: ");
//                    pessoa.Id = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Digite o nome da pessoa: ");
//                    pessoa.Nome = Console.ReadLine();
//                    Console.WriteLine("Digite o e-mail da pessoa: ");
//                    pessoa.Email = Console.ReadLine();
//                    pessoas.Add(pessoa);
//                }
//                else if (op == 2)
//                {
//                    Console.WriteLine("Lista de pessoas cadastradas: ");
//                    foreach (var p in pessoas)
//                    {
//                        Console.Write("ID: " + p.Id);
//                        Console.Write(" - Nome: " + p.Nome);
//                        Console.WriteLine(" - E-mail: " + p.Email);
//                    }
//                }
//                else if (op == 0)
//                {
//                    Console.WriteLine("Saindo do programa...");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Opção inválida. Tente novamente.");
//                }

//                /*Se nao tratarmos o erro a execução é encerrada*/

//                try
//                {
//                    //tudo que tiver aqui dentro, estara protegido de erros
//                    Console.WriteLine("Digite um número: ");
//                    int numero = int.Parse(Console.ReadLine());
//                    int resultado = 100 / numero; //pode gerar erro se numero for 0
//                    Console.WriteLine("Resultado: " + resultado); //se ocoru um erro, essa linha não será executada
//                }
//                catch (DivideByZeroException erro)
//                {
//                    //aqui eu trato o erro
//                    Console.WriteLine("A- Ocorreu um erro: " + erro.Message + "Nome da Exceção especifica capturada: " +
//                                      erro.GetType().Name);
//                }
//                catch (FormatException erro)
//                {
//                    Console.WriteLine("B- Ocorreu um erro: " + erro.Message + "Nome da Exceção especifica capturada: " +
//                                      erro.GetType().Name);
//                }
//                catch (OverflowException erro)
//                {
//                    Console.WriteLine("C- Ocorreu um erro: " + erro.Message + "Nome da Exceção especifica capturada: " +
//                                      erro.GetType().Name);
//                }
//                catch (Exception erro)
//                {
//                    Console.WriteLine("D - Ocorreu um erro: " + erro.Message +
//                                      "Nome da Exceção especifica capturada: " + erro.GetType().Name);
//                }
//                finally
//                {
//                    //sempre vai ser executado, mesmo se der erro ou não
//                    Console.WriteLine("FINALLY SEMPRE EXECUTA - Fim do tratamento de erros.");
//                }


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
//                StreamReader leitor = new StreamReader("C:\\Arquivo\\pessoas.txt");
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
//}
