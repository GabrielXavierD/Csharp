namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal maritaca = new Animal();
            maritaca.Nome = "Maritaca";
            maritaca.Idade = 2;
            maritaca.Especie = "Ave";
            maritaca.EmitirSom();
            maritaca.Movimentar();
            Console.WriteLine($"A {maritaca.Especie} {maritaca.Nome} tem {maritaca.Idade} anos.\n");

            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.Idade = 3;
            cachorro.Especie = "Canino";
            cachorro.EmitirSom();
            cachorro.Movimentar();
            cachorro.BuscarOsso();
            cachorro.Raca = "Labrador";
            Console.WriteLine($"O {cachorro.Raca} {cachorro.Especie} {cachorro.Nome} tem {cachorro.Idade} anos.\n");

            Pessoa pessoa1 = new Pessoa("João", 19, "12312312312");
            var s = pessoa1.ToString();
            Console.WriteLine(s);

            Pessoa pessoa2 = new Pessoa("João", 19);
            var s1 = pessoa2.ToString();
            Console.WriteLine(s1);

            /*
             *•1 - Crie duas classes, Pessoa e Estudante, em que Estudante herda de Pessoa. A classe Pessoa deve ter propriedades como Nome e Idade, e a classe Estudante deve adicionar uma propriedade Matricula. Crie instâncias de ambas as classes e exiba suas informações.
             *
             */
            Console.WriteLine("\nATIVIDADE - Exemplo de Herança entre classes Pessoa e Estudante:");
            Pessoa pessoa3 = new Pessoa("Maria", 20, "98765432100");
            Estudante estudante1 = new Estudante("Ana", 22, "12345678900", "2023.1234");
            var s2 = pessoa3.ToString();
            var s3 = estudante1.ToString();
            Console.WriteLine(s2 + "\n" +s3);

            /*
             * •2 - Crie três classes, Animal, Mamifero e Cachorro, em que Mamifero herda de Animal e Cachorro herda de Mamifero. Adicione propriedades relevantes a cada classe, como Nome, Especie, NumeroPatas, etc. Crie instâncias de todas as classes e exiba informações específicas de um cachorro.
             */
            Console.WriteLine("\nATIVIDADE - Exemplo de Herança entre classes Animal, Mamífero e Cachorro:");
            Animal animal = new Animal();
            animal.Nome = "Pinguim";
            animal.Idade = 4;
            animal.Especie = "Ave";
            animal.EmitirSom("Som de pinguim");
            animal.Movimentar();
            Console.WriteLine($"A {animal.Especie} {animal.Nome} tem {animal.Idade} anos.\n");

            Mamifero mamifero = new Mamifero();
            mamifero.Nome = "Fly";
            mamifero.Idade = 10;
            mamifero.Especie = "Elefante Africano";
            mamifero.NumeroPatas = 4;
            mamifero.ProduzLeite = true;
            mamifero.EmitirSom("Barulho de elefante");
            mamifero.Movimentar();
            mamifero.verificarSeProduzLeite();
            Console.WriteLine($"O {mamifero.Especie} {mamifero.Nome} tem {mamifero.Idade} anos e possui {mamifero.NumeroPatas} patas.\n");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Luna";
            cachorro2.Idade = 5;
            cachorro2.Especie = "Canino";
            cachorro2.NumeroPatas = 4;
            cachorro2.Raca = "Golden Retriever";
            cachorro2.ProduzLeite = true;
            cachorro2.EmitirSom("Au Au");
            cachorro2.Movimentar();
            cachorro2.BuscarOsso();
            cachorro2.verificarSeProduzLeite();
            Console.WriteLine($"O {cachorro2.Raca} {cachorro2.Especie} {cachorro2.Nome} tem {cachorro2.Idade} anos, possui {cachorro2.NumeroPatas} patas.\n");



        }
    }
}
