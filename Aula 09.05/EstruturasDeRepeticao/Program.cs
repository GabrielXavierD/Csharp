namespace EstruturasDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim;

            Console.Write("Digite o valor inicial: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor final: ");
            fim = int.Parse(Console.ReadLine());

            Console.WriteLine("Números entre {0} e {1}:", inicio, fim);

            // Se início for menor que fim, percorre de início até fim
            if (inicio < fim)
            {
                for (int i = inicio + 1; i < fim; i++)
                {
                    Console.WriteLine(i);
                }
            }
            // Se início for maior que fim, percorre de fim até início
            else if (inicio > fim)
            {
                for (int i = fim + 1; i < inicio; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Os valores são iguais, não há números entre eles.");
            }



            //*********************************************
            Console.Write($"Digite um número: ");

            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numeros de 0 a 100 divisiveis por: {x}");
            for (int i = 0; i <= 100; i++)
            {
                if (i % x == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /*
             * Este programa solicita ao usuário a quantidade de alunos,
             * lê suas notas e calcula a média para cada um.
             * Se a média for 6.0 ou superior, o aluno será aprovado.
             * Caso contrário, será reprovado.
             */

            Console.WriteLine("Digite a quantidade de alunos: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine($"Digite as notas do aluno {i + 1}:");
                Console.Write("Digite Nota 1: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite Nota 2: ");
                double n2 = double.Parse(Console.ReadLine());

                double media = (n1 + n2) / 2;
                Console.WriteLine($"Média do aluno {i + 1}: {media}");

                if (media >= 6.0)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }


            //versao professor
            Console.WriteLine("Digite a quantidade de alunos: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                double n1, n2, media;
                Console.WriteLine("Aluno " + (i + 1));
                Console.WriteLine("Digite Nota 1: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite Nota 2: ");
                n2 = double.Parse(Console.ReadLine());
                media = (n1 + n2) / 2;
                Console.WriteLine("Média do aluno: " + media);
                if (media >= 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

                Console.WriteLine("====================================");
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar -> Aguarda o usuário pressionar uma tecla antes de continuar a execução do programa. Isso é útil para dar uma pausa na tela e permitir que o usuário veja alguma mensagem antes do programa fechar ou limpar a tela.
                Console.Clear(); // Limpa a tela do console para organizar a visualização -> Apaga todo o conteúdo exibido no console, deixando a tela limpa. Isso pode ser usado para melhorar a visualização ou organizar a saída do programa.

            }
        }
    }
}
