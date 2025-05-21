namespace leituraDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algo");
            string nome;
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: " + nome);

            //Console.WriteLine(); -> método para mostrar na tela
            //Console.ReadLine(); -> Lê pelo teclado
            int n;
            Console.Write("\nInt - Digite um número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Inteiro digitado: {n}");

            double n2;
            Console.Write("\nDouble - Digite um número double: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Double digitado: {n2}");

            char c;
            Console.Write("\nDigite um caracter: ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine($"O caracter digitado é: {c}");


            /*
            Peça ao usuário para digitar dois números float.
            Apresente a soma, subtração, multiplicação e divisão dos números.*/

            Console.WriteLine("\nFloat - soma, subtração, multiplicação e divisão");
            float numero1, numero2;
            Console.Write("Digite um número: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {numero1 + numero2}");
            Console.WriteLine($"Subtração: {numero1 - numero2}");
            Console.WriteLine($"Multiplicação: {numero1 * numero2}");
            Console.WriteLine($"Divisão: {numero1 / numero2}");



            /*calcule a média de 3 numeros float */
            float numUm, numDois, numTres;
            Console.Write("\nFloat - Média de 3 números\n");
            Console.Write("Digite um número: ");
            numUm = float.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            numDois = float.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            numTres = float.Parse(Console.ReadLine());
            Console.WriteLine($"Média: {(numUm+numDois+numTres)/3}");



            /*leia dois numeros inteiros e apresente a divisão e o resto da divisão */
            Console.Write("\nInt - Resto e Divisão\n");
            int num1, num2;
            Console.Write("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divisão: {num1 / num2}");
            Console.WriteLine($"Resto da divisão: {num1 % num2}");



            /*Pergunte ao usuário o valor total de uma compra e o desconto, mostre o resultado*/
            Console.Write("\nFloat - Desconto aplicado em compra\n");
            float precoCompra, compraComDesconto, desconto;


            Console.Write("Digite o preço total da compra: ");
            precoCompra = float.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de desconto: ");
            desconto = float.Parse(Console.ReadLine())/100;

            compraComDesconto = precoCompra * desconto;
            Console.WriteLine($"O preço final da compra (com o desconto aplicado) é: {precoCompra - compraComDesconto}");

        }
    }
    }
