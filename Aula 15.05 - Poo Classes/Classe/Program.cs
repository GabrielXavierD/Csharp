using System.Xml.Serialization;

namespace Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {/**
            Console.WriteLine("Hello, World!");
            Pessoa p1 = new Pessoa(); intanciando a classe -> objeto
            p1.nome = "Gabriel";
            p1.idade = 19;



             Atv = crie as classes Professor (c/ atb. nome) e Laboratorio (c/ atb. local) ambos com atb. publicos
             e exiba no console

            Professor prof = new Professor();
            Laboratorio lab = new Laboratorio();

            prof.nome = "Armenio";
            lab.local = "101";
            Console.WriteLine($"O nome do profesor é {prof.nome} e o local da aula é {lab.local}.");


            Complete a Classe Pessoa com atb. genero

            Pessoa p2 = new Pessoa();
            Console.Write("Digite o nome da pessoa: ");
            p2.nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o genero da pessoa: ");
            p2.genero = Console.ReadLine();

            Console.WriteLine($"O nome da pessoa é {p2.nome}, sua idade é {p2.idade} e seu genero é {p2.genero}.");


            Crie uma classe carro
            Carro c1 = new Carro();
            Console.WriteLine("Digite a marca do carro 1: ");
            c1.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro 1: ");
            c1.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do carro 1: ");
            c1.anoFabricacao = int.Parse(Console.ReadLine());
            Carro c2 = new Carro();
            Console.WriteLine("Digite a marca do carro 2: ");
            c2.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro 2: ");
            c2.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do carro 2: ");
            c2.anoFabricacao = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Carro 1");
            Console.WriteLine("Marca: " + c1.marca);
            Console.WriteLine("Modelo: " + c1.modelo);
            Console.WriteLine("Ano fabricação: " + c1.anoFabricacao);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Carro 2");
            Console.WriteLine("Marca: " + c2.marca);
            Console.WriteLine("Modelo: " + c2.modelo);
            Console.WriteLine("Ano fabricação: " + c2.anoFabricacao);



            Aula 16.05

             Crie uma classe Livro com os atributos título, autor e ano de publicação. Faça a instanciação de 3 objetos e imprima as
            informações do livro na tela.

            Livro livro = new Livro();
            livro.autor = "Gabriel";
            livro.titulo = "Gabriel Xavier Domingues";
            livro.ano = 2025;

            Livro livro2 = new Livro();
            livro2.titulo = "O Morro dos Ventos Uivantes";
            livro2.autor = "Emily Brontë";
            livro2.ano = 1847;

            Livro livro3 = new Livro();
            livro3.titulo = "A Revolução dos Bichos";
            livro3.autor = "George Orwell";
            livro3.ano = 1945;

            Console.WriteLine($"{livro.autor} é o autor do livro '{livro.titulo}', lançado em {livro.ano}.\n" +
                              $"{livro2.autor} é o autor do livro '{livro2.titulo}', lançado em {livro2.ano}.\n" +
                              $"{livro3.autor} é o autor do livro '{livro3.titulo}', lançado em {livro3.ano}.");


            Lampada l1 = new Lampada();
            l1.ligar();
            if (l1.estaLigada())
            {
                Console.WriteLine("A lampada esta ligada");
            }
            else
            {
                Console.WriteLine("A lampada esta desligada");
            }

            Console.WriteLine("Status da lampada: "+l1.estaLigada());
            l1.desligar();
            Console.WriteLine("Status da lampada: "+l1.estaLigada());
            if (l1.estaLigada())
            {
                Console.WriteLine("A lampada esta ligada");
            }
            else
            {
                Console.WriteLine("A lampada esta desligada");
            }

            Metodo estatico
            MostrarMensagem();


            Lampada l2 = new Lampada(true, 100);


            */

            /* •Crie uma classe Livro que represente os dados básicos de um livro, além destes, criar um atributo do tipo boolean chamado emprestado.
•Crie métodos emprestar e devolver que altera o atributo emprestado
•Crie um método construtor que receba todos os valores por parâmetros, exceto o atributo emprestado que obrigatoriamente deve ser inicializado como false
•Faça a leitura pelo teclado dos atributos para instanciar dois livros
             */

            Console.WriteLine("Digite o título do primeiro livro:");
            string titulo1 = Console.ReadLine();
            Console.WriteLine("Digite o autor do primeiro livro:");
            string autor1 = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação do primeiro livro:");
            int ano1 = int.Parse(Console.ReadLine());

            Livro livro1 = new Livro(titulo1, autor1, ano1);

            Console.WriteLine("\nDigite o título do segundo livro:");
            string titulo2 = Console.ReadLine();
            Console.WriteLine("Digite o autor do segundo livro:");
            string autor2 = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação do segundo livro:");
            int ano2 = int.Parse(Console.ReadLine());

            Livro livro3 = new Livro(titulo2, autor2, ano2);

            // Exibindo informações diretamente no Console
            Console.WriteLine($"\nLivro 1 - título: {livro1.titulo}, autor: {livro1.autor}, ano: {livro1.ano}, emprestado: {livro1.emprestado}");
            Console.WriteLine($"Livro 2 - título: {livro3.titulo}, autor: {livro3.autor}, ano: {livro3.ano}, emprestado: {livro3.emprestado}");

            /*
             * •Crie uma classe chamada Personagem. Defina seus atributos, mas dentre eles deve conter: Nome, posição e itens coletados, no mínimo.
•Crie construtor e faça a leitura dos atributos pelo teclado.
•Crie um método chamado “atacar” que recebe por parâmetro uma variável do tipo double que indica o dano do ataque numa escala de 0 a 10. O método deve apresentar uma mensagem na tela com o dano.
•Crie um método chamado “movimentar” que deve receber por parâmetro uma variável do tipo int que indica a direção que o personagem vai se mover (1 – frente, 2 – trás, 3 – direita e 4 – esquerda). O método deve apresentar uma mensagem na tela mostrando a direção que o personagem vai se mover.
             */
        }
    }
}
