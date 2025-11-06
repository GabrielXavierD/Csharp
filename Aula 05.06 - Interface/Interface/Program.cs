using System.Threading.Channels;

namespace Interface
{
    internal class Program
    {
        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            // Instanciando um carro
            Carro carro = new Carro();
            carro.Ligar();
            carro.Acelerar();

            /*•Exercicio - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()".
            •Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo".

            •Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que
            o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.
             */
            // Instanciando um retângulo e um círculo
            Retangulo retangulo = new Retangulo(5, 10);
            Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro do Retângulo: {retangulo.CalcularPerimetro()}");
            Circulo circulo = new Circulo(7);
            Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro do Círculo: {circulo.CalcularPerimetro()}");



            /*** ARRAY ***/

            // Criando um array de inteiros
            int[] vetor = new int[5]; //array int de 5 posições
            // Atribuindo valores ao array
            vetor[0] = 10;
            vetor[1] = 20;
            vetor[2] = 30;
            vetor[3] = 40;
            vetor[4] = 50;
            // Exibindo os valores do array
            Console.WriteLine("Valores do array:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            /*** LIST ***/
            // Criando uma lista de inteiros
            List<int> lista = new List<int>();
            // Adicionando valores à lista
            lista.Add(10);
            lista.Add(20);
            Console.WriteLine("Valores da lista:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //se usar () se usa add pra adicionar
            //se usar {} se adiciona diretamente as instancias atribuindo em cada atributo da Classe

            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 30 },
                new Pessoa { Nome = "Maria", Idade = 20 },
                new Pessoa { Nome = "José", Idade = 19 },
            }; //atribuindo essas pessoas no construtor de pessoa, em vez de usar (), uso {} pra colocar diretamente varias coisas
            // Adicionando mais valores à pessoas
            pessoas.Add(new Pessoa { Nome = "Ana", Idade = 25 }); //pode fazer em uma variavel separada tb e atribuir aq

            Pessoa p1 = new Pessoa { Nome = "João", Idade = 30 };
            pessoas.Add(p1);
            Pessoa p2 = new Pessoa { Nome = "Ana", Idade = 28 };
            pessoas.Add(p2);
            Pessoa p3 = new Pessoa { Nome = "Carlos", Idade = 40 };
            pessoas.Add(p3);
            Pessoa p4 = new Pessoa { Nome = "Luiza", Idade = 22 };
            pessoas.Add(p4);
            ExibirLista();



            //outra forma de inserir é usando insert
            pessoas.Insert(0, new Pessoa { Nome = "Pedro", Idade = 35 }); //insere na posição 0 e substitui o q ja tem
            pessoas.Insert(2,
                new Pessoa { Nome = "Fernanda", Idade = 27 }); //insere na posição 2 e desloca os outros pra baixo
            pessoas.Insert(5, new Pessoa { Nome = "Marcos", Idade = 65 });
            ExibirLista();

            //para remover especifico
            pessoas.Remove(p1); //remove a pessoa p1

            //para remover por indice
            pessoas.RemoveAt(0); //remove a pessoa na posição 0
            ExibirLista();
            // Exibindo os valores da lista

            // Exibindo as pessoas
            Console.WriteLine("Pessoas na lista:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            }

            Console.WriteLine("Usando Count:");
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}: Nome: {pessoas[i].Nome}, Idade: {pessoas[i].Idade}");
            }

            ExibirLista();
        }

        static void ExibirLista()
        {
            Console.WriteLine("Exbindo lista usando o foreach da classe List");
            //pessoas.ForEach(p => Console.WriteLine("Nome: "+p.Nome+" Idade "+p.Idade));
            pessoas.ForEach(delegate(Pessoa p) { Console.WriteLine("Nome: " + p.Nome + " Idade " + p.Idade); });
        }

        static void ExibirListaOrdenada()
        {
            Console.WriteLine("Exibindo lista ordenada por nome: ");
            // Ordenando a lista por nome
            pessoas.Sort (p1, p2) => p1.Nome.CompareTo(p2.Nome));
            //usa quick sort -> pesquisa binaria
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + p.Nome + " Idade " + p.Idade);
            }
        }

        static void ExibirListaOrdenadaNome()
        {
            Console.WriteLine("Exibindo lista ordenada: ");
            pessoas.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("Nome: " + p.Nome + " Idade " + p.Idade);
            }
        }

        static void ExibirListaOrdenadaIdade()
        {
            Console.WriteLine("Exibindo lista ordenada por idade: ");
            pessoas.Sort((p1, p2) => p1.Idade.CompareTo(p2.Idade));
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("Nome: " + p.Nome + " Idade " + p.Idade);
            }
        }

        //criando metodo pra converter lista pra array
        static Pessoa[] ConverterListaParaArray(List<Pessoa> pessoas)
        {
            // Usando o método ToArray() da classe List
            return pessoas.ToArray();
        }

        //filtrando lista maisJovem
        static List<Pessoa> FiltrarPessoasMaisJovens(List<Pessoa> pessoas, int idadeLimite)
        {
            // Usando o método Where() da classe List
            return pessoas.Where(p => p.Idade < idadeLimite).ToList();
        }

        //e agora usando findall pra pessoas jovens
        static List<Pessoa> EncontrarPessoasJovens(List<Pessoa> pessoas, int idadeLimite)
        {
            // Usando o método FindAll() da classe List
            return pessoas.FindAll(p => p.Idade < 25);

        }

        static void ListaMaisJovem()
        {
            List<Pessoa> pessoasJovens = pessoas.FindAll(p => p.Idade < 25);

            Console.WriteLine("Exibindo idades menores que 25: ");
            pessoasJovens.ForEach(delegate(Pessoa p) { Console.WriteLine("Nome: " + p.Nome + " Idade " + p.Idade); });
        }
    }
}
