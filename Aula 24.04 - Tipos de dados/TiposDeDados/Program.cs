namespace TiposDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formas de exibir informações");
            Console.WriteLine("Quebra de linha com \\n \n");
            Console.Write("Sem quebra de linha");
            Console.WriteLine("Esse texto vai na linha de cima, pois a linha de cima ñ foi quebrada.");


            //-----------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            // Este programa demonstra diferentes tipos de dados no C#.
            Console.WriteLine("Tipos de dados!");

            char caractere;            // Um caractere único, como 'A' ou '#'.
            int valor1;        // Um número inteiro, sem ponto decimal.
            float valor2;      // Um número de ponto flutuante com precisão menor.
            double valor3;     // Um número de ponto flutuante com precisão maior.
            bool ligado;            // Um valor booleano que pode ser verdadeiro ou falso.
            string palavra;    // Um texto ou conjunto de caracteres.

            caractere = 'R';
            Console.WriteLine("Caractere: " + caractere);  // Exibe o caractere armazenado.

            valor1 = 4;
            Console.WriteLine("Inteiro: " + valor1);  // Exibe o número inteiro armazenado.

            valor2 = 4.345678909012f;
            Console.WriteLine("Float: " + valor2);  // Exibe o número com precisão de float.

            valor3 = 4.34567890901278914;
            Console.WriteLine("Double: " + valor3);  // Exibe o número com precisão de double.

            ligado = true;
            Console.WriteLine("Booleano: " + ligado);  // Exibe o valor booleano armazenado.

            ligado = false;
            Console.WriteLine("Booleano: " + ligado);  // Exibe o valor booleano armazenado.

            palavra = "palavras ou letras, emojis etc...";
            Console.WriteLine($"String: {palavra}"); //Interpolação (template de string do JS vesão C#)



            //-----------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("------------------------------------");


            // OPERADORES C#.
            Console.Write("Operadores em C#!");

            // Operadores Aritméticos
            int a = 10, b = 3;
            Console.WriteLine("\n\nAritméticos:");
            Console.WriteLine("Soma (a + b): " + (a + b));    // Soma
            Console.WriteLine("Subtração (a - b): " + (a - b)); // Subtração
            Console.WriteLine("Multiplicação (a * b): " + (a * b)); // Multiplicação
            Console.WriteLine("Divisão (a / b): " + (a / b));    // Divisão (inteira)
            Console.WriteLine("Resto (a % b): " + (a % b));    // Resto da divisão (módulo)


            double nota1, nota2, nota3, media;

            nota1 = 7.44;
            Console.WriteLine("Nota 1: " + nota1);
            nota2 = 8.33;
            Console.WriteLine("Nota 2: " + nota2);
            nota3 = 5.44;
            Console.WriteLine("Nota 3: " + nota3);

            media = nota1 + nota2 + nota3 / 3;

            /*
            Para arredondar a quantidade de casas, se usa o metodo
            .ToString(quantia de casas) -> ele converte o valor pra STRING
            e ajusta a quantidade de casas de acordo com o Nx passado como argumento
            N0,N1,N2,N3 etc... -> o número depois de N representa a quantidade de casas

             */
            Console.WriteLine("Calculo da média ERRADA: " + media.ToString("N2"));

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Calculo da média CORRETAMENTE: " + media.ToString("N1"));



            //-----------------------------------------------------------------------------
            Console.WriteLine();

            // Operadores Unários
            int d = 10;
            Console.WriteLine("\nUnários:");

            Console.WriteLine("d++ (incremento pós-fixado): " + (d++)); // Incremento após a operação
            Console.WriteLine("++d (incremento prefixado): " + (++d)); // Incremento antes da operação
            Console.WriteLine("d-- (decremento pós-fixado): " + (d--)); // Decremento após a operação
            Console.WriteLine("--d (decremento prefixado): " + (--d)); // Decremento antes da operação

            // Incremento usando d = d + 1
            d = d + 1;
            Console.WriteLine("Incremento explícito (d = d + 1): " + d);

            // Incremento usando d += 1
            d += 1; // Equivalente a d = d + 1
            Console.WriteLine("Incremento simplificado (d += 1): " + d);

            // Decremento explícito
            d = d - 1;
            Console.WriteLine("Decremento explícito (d = d - 1): " + d);

            // Decremento simplificado
            d -= 1; // Equivalente a d = d - 1
            Console.WriteLine("Decremento simplificado (d -= 1): " + d);



            //-----------------------------------------------------------------------------
            Console.WriteLine();


            // Operadores Relacionais
            Console.WriteLine("\nRelacionais:");
            Console.WriteLine("a > b: " + (a > b));  // Maior que
            Console.WriteLine("a < b: " + (a < b));  // Menor que
            Console.WriteLine("a == b: " + (a == b)); // Igual a
            Console.WriteLine("a != b: " + (a != b)); // Diferente de


            //-----------------------------------------------------------------------------
            Console.WriteLine();

            // Operadores Lógicos
            bool x = true, y = false;
            Console.WriteLine("\nLógicos:");
            Console.WriteLine("x && y (AND): " + (x && y));  // AND lógico
            Console.WriteLine("x || y (OR): " + (x || y));  // OR lógico
            Console.WriteLine("!x (NOT): " + (!x));         // NOT lógico

            string nome1;
            string nome2;
            nome1 = "Ricardo";
            nome2 = "Ricardo";

            if (nome1.Equals(nome2))
            {
                Console.WriteLine("Nomes iguais!");
            }

            // Tem como comparar a memória então
            if (Object.ReferenceEquals(nome1, nome2))
            {
                Console.WriteLine("Nomes iguais!");
            }

            if (!nome1.Equals(nome2)) //nome1 não é igual a nome2
            {
            }

            Console.WriteLine("Metodos para STRING");
            string nomeMaiusculo;
            nomeMaiusculo = nome1.ToUpper();
            Console.WriteLine("Nome maiusculo: " + nomeMaiusculo);

            string nomeMinusculo = nomeMaiusculo.ToLower();
            Console.WriteLine("Nome minusculo: " + nomeMinusculo);

            if (nome1.Equals(nomeMaiusculo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nomes iguais!");
            }
            else
            {
                Console.WriteLine("Nomes diferentes!");
            }

            /*Esse trecho utiliza o método Equals com StringComparison.OrdinalIgnoreCase
            para comparar strings ignorando diferenças entre maiúsculas e minúsculas.*/


            //-----------------------------------------------------------------------------
            Console.WriteLine();

            // Operadores de Atribuição
            int c = 5;
            Console.WriteLine("\nAtribuição:");
            c += 3;  // Equivalente a c = c + 3
            Console.WriteLine("c += 3: " + c);
            c *= 2;  // Equivalente a c = c * 2
            Console.WriteLine("c *= 2: " + c);


            string frase1;
            frase1 = "Nessa frase: estou escrevendo uma frase de impacto!";
            Console.WriteLine($"Frase maiúscula: {frase1.ToUpper()}");
            Console.WriteLine($"Frase maiúscula: {frase1.Replace("frase", "oração")}"); //replace susbtitui todas as ocorrencias

            //verificar se String começa com algo especifico
            if (frase1.StartsWith("Nessa"))
            {
                Console.WriteLine("Começa com 'Nessa'");
            }


            //verificar se String começa com algo especifico
            if (frase1.EndsWith("!"))
            {
                Console.WriteLine("termina com '!'");
            }

            //verificar se contem algo em algum lugar da String
            if(frase1.Contains("frase")) Console.WriteLine("Contém 'frase'");

            int n;
            Console.WriteLine("Digite um numero n: ");
            n = int.Parse(Console.ReadLine()); //ReadLine retorna String -> precisamos converter

            Console.WriteLine($"O inteiro digital é: {n}");

        }
    }
}
