namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura seletiva - Switch Case
            // Verificando um número
            Console.WriteLine("Digite um número (1 ou 2):");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Você digitou o número 1.");
                    break;
                case 2:
                    Console.WriteLine("Você digitou o número 2.");
                    break;
                default:
                    Console.WriteLine("Número inválido!");
                    break;
            }

            // Verificando uma letra
            Console.WriteLine("Digite uma letra (g ou m):");
            char letra = char.Parse(Console.ReadLine()[0]); // Converte para maiúsculo

            switch (letra)
            {
                case 'g':
                    Console.WriteLine("Você digitou a letra 'g'.");
                    break;
                case 'm':
                    Console.WriteLine("Você digitou a letra 'm'.");
                    break;
                default:
                    Console.WriteLine("Letra inválida!");
                    break;
            }


            //EXERCICIOS
            /*Exercícios Switch Case
1 - Crie um programa em C# que solicite ao usuário um número de 1 a 7 representando os dias da semana. O programa deve exibir qual é o dia correspondente e a atividade planejada para aquele dia.

Use switch-case para mostrar a atividade programada:

1 - Domingo: Descanso
2 - Segunda: Reuniões e planejamento
3 - Terça: Desenvolvimento
4 - Quarta: Revisão de código
5 - Quinta: Testes
6 - Sexta: Deploy da aplicação
7 - Sábado: Estudos
Se o número digitado for fora do intervalo de 1 a 7, exiba: "Dia inválido."


2 - Crie um programa em C# que exiba o seguinte menu para o usuário:

Selecione uma operação:
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
0 - Sair
O programa deve solicitar dois números ao usuário e executar a operação escolhida usando switch-case.

Se for digitado 0, o programa deve encerrar.

Caso a opção seja inválida, exibir mensagem apropriada.

Ao final da operação, o resultado deve ser exibido.*/

        }
    }
}
