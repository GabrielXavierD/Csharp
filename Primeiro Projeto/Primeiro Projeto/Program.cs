namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*No C# ele não tem um console interno, ele abre um console externo.
              Escreve uma linha no Console
            
            -É fortemente tipado
             */
            int n1, n2;
            n1 = 10;
            n2 = 20;
            Console.WriteLine("N1 = " + n1);
            Console.WriteLine("N2 = " + n2);
            Console.WriteLine("Hello, World!");

            int soma;
            soma = n1 + n2;
            Console.WriteLine("O resultado da soma eh: " + soma);

            var data = new DateTime();
            Console.WriteLine(data);
            Console.WriteLine("Dia: " + data.Day);
            Console.WriteLine("Mes: " + data.Month);
            Console.WriteLine("Ano: " + data.Year);
            Console.WriteLine("Hora: " + data.Hour);
            Console.WriteLine("Minute: " + data.Minute);
            Console.WriteLine("Segundos: " + data.Second);
           
            data = DateTime.Now; //pega a data (dia, mes, ano etc...) e hora atual
            Console.WriteLine("\nData de agora: " + data);
            Console.WriteLine("Dia: " + data.Day);
            Console.WriteLine("Mes: " + data.Month);
            Console.WriteLine("Ano: " + data.Year);
            Console.WriteLine("Hora: " + data.Hour);
            Console.WriteLine("Minute: " + data.Minute);
            Console.WriteLine("Segundos: " + data.Second);


            /*TIPOS PRIMITIVOS
            int = 25 -> numero intero
            float = flutuante = 43.25
            double = 43.2525  -> e o dobro da precisao. Ex.: se em float há 2 casas, em double seria 4 casas dps da virgula
           
             
            - inverte sinal
            * multiplicação
            / divisão
            % resto de divisão
            + adição
            - subtração
            () ordem de prioridade de execução da conta
                (5*5)+(3-2), por exemplo
             */

            double nota1, nota2, nota3, media;
            nota1 = 6.44;
            nota2 = 7.33;
            nota3 = 5.17;
            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Média = " + media);

            Console.WriteLine("---------------------------");
            media = nota1 + nota2 + nota3 / 3;
            Console.WriteLine("Média = " + media);

        }
    }
}
