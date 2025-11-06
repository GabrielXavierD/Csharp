namespace abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aqui, não podemos instanciar a classe Animal diretamente, pois é abstrata.
            //Animal animal = new Animal();

            /*VERSAO 1 - SEM O CONSTRUTOR NA CLASSE ANIMAL
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.Sexo = "Macho";
            cachorro.Idade = 5;
            cachorro.EmitirSom();
            cachorro.Mover();
            cachorro.Respirar();
            cachorro.Brincar();
            Console.WriteLine($"Nome: {cachorro.Nome}, Sexo: {cachorro.Sexo}, Idade: {cachorro.Idade} anos");

            Peixe peixe = new Peixe();
            peixe.Nome = "Nemo";
            peixe.Sexo = "Macho";
            peixe.Idade = 2;
            peixe.EmitirSom();
            peixe.Mover();
            peixe.Respirar();
            peixe.Nadar();
            peixe.Comer();
            Console.WriteLine($"Nome: {peixe.Nome}, Sexo: {peixe.Sexo}, Idade: {peixe.Idade} anos");

            // Instanciando um gato, que também herda de Animal
            Gato gato = new Gato();
            gato.Nome = "Mia";
            gato.Sexo = "Fêmea";
            gato.Idade = 3;
            gato.Vidas = 7;
            gato.Ronronar();
            gato.EmitirSom();
            gato.Mover();
            gato.Respirar();
            gato.Dormir();
            gato.Brincar();
            Console.WriteLine($"Nome: {gato.Nome}, Sexo: {gato.Sexo}, Idade: {gato.Idade} anos");
            */
            // VERSAO 2 - COM O CONSTRUTOR NA CLASSE ANIMAL
            Cachorro cachorro = new Cachorro("Rex", "Macho", 5);
            cachorro.EmitirSom();
            cachorro.Mover();
            cachorro.Respirar();
            cachorro.Brincar();
            Console.WriteLine("Cachorro: " + cachorro);

            Peixe peixe = new Peixe("Nemo", "Macho", 2);
            peixe.EmitirSom();
            peixe.Mover();
            peixe.Respirar();
            peixe.Nadar();
            peixe.Comer();
            Console.WriteLine("Peixe: " + peixe);

            // Instanciando um gato, que também herda de Animal
            Gato gato = new Gato("Mia", "Fêmea", 3, "7 vidas");
            gato.Ronronar();
            gato.EmitirSom();
            gato.Mover();
            gato.Respirar();
            gato.Dormir();
            gato.Brincar();
            Console.WriteLine("Gato: " + gato);


        }
    }
}
