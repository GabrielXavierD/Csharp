using System;
using System.IO;

class Program
{
    static void Main()
    {
        //OFICINA C# - Capitulo 1 - Olá C#

        Console.WriteLine();
        Console.WriteLine("STRINGS");

        // ======== STRING ========

        // Declarar sem inicializar.
        string message1;

        // Inicializar como nulo.
        string message2 = null;

        // Inicializar como uma string vazia.
        string message3 = System.String.Empty;     // Terá o mesmo conteúdo que abaixo.
        string mensagem4 = "";

        // Com declaração implícita -> compilador define o tipo.
        var message4 = "Uma mensagem aleatória";

        /*Comparando Strings
           Podemos usar o método Equals(var1, var2) para comparar
           ou simplesmente usar o operador == para comparar variaveis.

          Em C#, strings são tipos de referência, mas quando usa:

             == (operador de igualdade)
             .Equals() (método de comparação)

          Está comparando os valores (conteúdo) das strings, não suas referências na memória.
        */

        string first = "Hello.";
        string second = first;
        first = null;

        Console.WriteLine(first == second);               // False
        Console.WriteLine(string.Equals(first, second));  // False

        /*
         Por que isso acontece?
           Strings são imutáveis: Quando você altera uma string (first = null),
           uma nova referência é criada, mas second mantém o valor original.

           == e .Equals() comparam conteúdo:

           Se uma string for null e a outra não, o resultado é False.
           Se ambas forem null, o resultado é True.
        */


        Console.WriteLine();
        Console.WriteLine("VARIÁVEIS E TIPOS");

        // ======== VARIÁVEIS E TIPOS ========

        // Declaração explícita
        int idade = 19;

        // Declaração implícita (o tipo é inferido)
        var nome = "Lucas";

        // Tipos numéricos
        int inteiro = 10;
        double realComPontoFlutuante = 5.75;
        float realMenor = 3.14f;
        decimal dinheiro = 99.99m;
        long numeroGrande = 1000000000000;

        // Booleano
        bool aprovado = true;

        // Data e hora
        DateTime agora = DateTime.Now;
        TimeSpan duracao = TimeSpan.FromHours(2);

        // Arrays
        /*Formas de declarar array (fazem a mesma coisa):
         char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

         char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            ->A forma curta (sem new char[]) só pode ser usada na declaração
            ->Ou seja, fazer (isso abaixo, da erro):
                    char[] vowels;
                    vowels = { 'a', 'e', 'i', 'o', 'u' }; // ❌ Erro de compilação

                ->Pra funcionar precisa colocar:
                    vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; // ✅ Correto
 */
        int[] numeros = { 1, 2, 3, 4 };


        Console.WriteLine();
        Console.WriteLine("OPERADORES");

        // ======== OPERADORES ========

        // Aritméticos
        int soma = 5 + 3;
        int sub = 10 - 2;
        int mult = 4 * 3;
        int div = 12 / 4;
        int resto = 10 % 3;

        // Comparação
        bool igual = (5 == 5);        // true
        bool diferente = (3 != 4);    // true

        // Lógicos
        bool logicoE = true && false; // false
        bool logicoOu = true || false; // true
        bool logicoNao = !true;       // false

        // Ternário
        string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";


        Console.WriteLine();
        Console.WriteLine("CONTROLE DE FLUXO");

        // ======== CONTROLE DE FLUXO ========

        // Condicional if-else
        if (idade >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }

        // switch
        int opcao = 2;
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Opção 1");
                break;
            case 2:
                Console.WriteLine("Opção 2");
                break;
            default:
                Console.WriteLine("Outra opção");
                break;
        }

        // Loops
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Contador for: " + i);
        }

        int contador = 0;
        while (contador < 3)
        {
            Console.WriteLine("Contador while: " + contador);
            contador++;
        }

        do
        {
            Console.WriteLine("Executa pelo menos uma vez (do-while)");
        } while (false);

        foreach (var num in numeros)
        {
            Console.WriteLine("Número do array: " + num);
        }


        Console.WriteLine();
        Console.WriteLine("CLASSES E OBJETOS");

        // ======== CLASSES E OBJETOS ========
        Pessoa p1 = new Pessoa("João", 25);
        p1.Apresentar();


        Console.WriteLine();
        Console.WriteLine("MANIPULAÇÃO DE ARQUIVOS");

        // ======== MANIPULAÇÃO DE ARQUIVOS ========

        string caminho = "exemplo.txt";

        // Escrevendo em arquivo (texto)
        using (StreamWriter escritor = new StreamWriter(caminho))
        {
            escritor.WriteLine("Olá, arquivo!");
        }

        // Lendo de arquivo (texto)
        using (StreamReader leitor = new StreamReader(caminho))
        {
            string conteudo = leitor.ReadToEnd();
            Console.WriteLine("Conteúdo do arquivo: " + conteudo);
        }


        Console.WriteLine();
        Console.WriteLine("TRATAMENTO DE EXCEÇÕES");

        // ======== TRATAMENTO DE EXCEÇÕES ========
        try
        {
            int a = 10;
            int b = 0;
            int resultadoDivisao = a / b;
        }
        catch (DivideByZeroException erro)
        {
            Console.WriteLine("Erro: divisão por zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finalizando operação.");
        }


        Console.WriteLine();
        Console.WriteLine("VALOR vs REFERÊNCIA");

        // ======== DIFERENÇA: VALOR x REFERÊNCIA ========
        int valor1 = 5;
        int valor2 = valor1; // cópia do valor

        valor1 = 10;
        Console.WriteLine("valor2 continua 5? " + (valor2 == 5)); // true

        Pessoa p2 = new Pessoa("Maria", 30);
        Pessoa p3 = p2; // p3 referencia o mesmo objeto que p2

        p2.Nome = "Ana";
        Console.WriteLine("Nome da p3 também mudou? " + p3.Nome); // Ana


        Console.WriteLine();
        Console.WriteLine("BOAS PRÁTICAS");

        // ======== BOAS PRÁTICAS ========
        var idadeUsuario = 20; // var com tipo óbvio (int)
        string nomeCompleto = "Carlos da Silva"; // nome descritivo
        // Liberar recursos com 'using' já demonstrado acima
    }
}

// Classe de exemplo para objetos
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método da classe
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
