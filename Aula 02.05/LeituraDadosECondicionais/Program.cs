namespace LeituraDadosECondicionaisEOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             A entrada de dados em C# é feita com
            Console.ReadLine();

            porém, ele retorna string, ent é preciso fazer a
            conversão com tipo.Parse();


             */
            int idade;
            Console.Write("Idade - Digite um número: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 17) //if(idade >= 18) //Se a condicional retornar verdadeiro, ou seja, se ela for verdadeira
            {
                //executo este bloco de instruções
                Console.WriteLine("Maior de idade!");
            }
            else
            {
                Console.WriteLine("Menor de idade!");
            }


            int n;
            Console.Write("\nVer se é positivo, negativo ou 0 - Digite um número: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Número positivo");
            }
            else if (n == 0)
            {
                Console.WriteLine("O número é zero");

            }
            else
            {
                Console.WriteLine("Número negativo");
            }


            /*Ver se um numero é divisivel por 2
            O resto deve dar 0*/
            Console.Write("\nVer se é divisivel por 2 - Digite um número: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("É divisivel por 2");
            }
            else
            {
                Console.WriteLine("Não é divisivel por 2");
            }

            ///*Ver se um numero é divisivel por 2,4 e 8*/
                Console.Write("\nVer se dividide por 2,4 e/ou 8 - Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n % 8 == 0)
                {
                    Console.WriteLine("É divisível por 8, 4 e 2");
                }
                else if (n % 4 == 0)
                {
                    Console.WriteLine("É divisível por 4 e 2");
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("É divisível por 2");
                }
                else
                {
                    Console.WriteLine("Não é divisível por 2, 4 ou 8");
                }


                if (n % 8 == 0)
                {
                    Console.WriteLine("É divisível por 8, 4 e 2");
                }

                if (n % 4 == 0)
                {
                    Console.WriteLine("É divisível por 4 e 2");
                }

                if (n % 2 == 0)
                {
                    Console.WriteLine("É divisível por 2");
                }


                Console.Write("\nVer se dividide por 2,3 e 4 - Digite um número: ");
                n = int.Parse(Console.ReadLine());
            if ((n % 2 == 0) && (n % 3 == 0) && (n % 4 == 0))
                {
                    Console.WriteLine("Divisível por 2, 3 e 4 ao mesmo tempo.");
                }
                else
                {
                    Console.WriteLine("Não é divisível por 2, 3 e 4 ao mesmo tempo.");
                }

            Console.WriteLine("\nVer se  o número igual ou diferente");
                int n1, n2;
                Console.Write("Digite um número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro número: ");
                n2 = int.Parse(Console.ReadLine());
                // testar se o número é divisível por 2, 3 e 4

                if (n1 != n2)
                {
                    Console.WriteLine("São diferentes");
                }
                else
                {
                    Console.WriteLine("São iguais!");
                }



                Console.Write("\nMaior número");
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine($"O maior número é {num1}");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine($"O maior número é {num2}");
                }
                else
                {
                    Console.WriteLine("Os números são iguais!");
                }


                //1 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

                int numero1, numero2, numero3;
                Console.WriteLine("\nMaior número de 3 numeros digitados");
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro número: ");
                numero3 = int.Parse(Console.ReadLine());

                if (numero1 > numero2 && numero1 > numero3)
                {
                    Console.WriteLine($"O maior número é {numero1}");
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    Console.WriteLine($"O maior número é {numero2}");
                }
                else if (numero3 > numero1 && numero3 > numero2)
                {
                    Console.WriteLine($"O maior número é {numero3}");
                }
                else if (numero1 == numero2 && numero2 == numero3)
                {
                    Console.WriteLine("Os três números são iguais!");
                }
                else
                {
                    Console.WriteLine("Os três números são iguais!");
                }


                //Agora mostre em  ordem crescente
                Console.WriteLine("Números em ordem crescente:");
                if (numero1 <= numero2 && numero1 <= numero3)
                {
                    if (numero2 <= numero3) Console.WriteLine($"{numero1}, {numero2}, {numero3}");
                    else Console.WriteLine($"{numero1}, {numero3}, {numero2}");
                }
                else if (numero2 <= numero1 && numero2 <= numero3)
                {
                    if (numero1 <= numero3) Console.WriteLine($"{numero2}, {numero1}, {numero3}");
                    else Console.WriteLine($"{numero2}, {numero3}, {numero1}");
                }
                else
                {
                    if (numero1 <= numero2) Console.WriteLine($"{numero3}, {numero1}, {numero2}");
                    else Console.WriteLine($"{numero3}, {numero2}, {numero1}");
                }


            //2 - Faça a leitura de duas notas de um aluno. Calcule a
            //média e apresente a mensagem "Aprovado" se a média for maior igual que 6,
            //senão, apresente que ele foi "Reprovado".
            Console.WriteLine("\nMédia das notas");
                float nota1, nota2, media;
                Console.WriteLine("Digite a primeira nota: ");
                nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota: ");
                nota2 = float.Parse(Console.ReadLine());

                media = (nota1 + nota2) / 2;
                if (media >= 6)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
        }
    }