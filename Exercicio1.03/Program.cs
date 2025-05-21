namespace Exercicio1._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Imutabilidade de Strings em C#

            O que é Imutabilidade?
            Imutabilidade significa que um objeto não pode ser alterado após sua criação.
            No caso de strings em C#, quando você "modifica" uma string, na verdade,
            está criando uma nova string com as alterações, enquanto a original permanece intacta.

            Função sem retorno é void
            Método que tenta modificar a string:
                -FormatString (não retorna nada):
                    -Replace() cria uma nova string com "Marte" no lugar de "Mundo"
                    -Porém, essa nova string não é armazenada nem retornada
                    -Resultado: A string original greetings permanece "Olá, mundo!"
             */

            static void SubstituirString(string parametroString)
            {
                parametroString.Replace("World", "Mars"); // Cria nova string, mas não a usa
            }

            var greetings = "Hello World!";
            SubstituirString(greetings);
            Console.WriteLine(greetings);



            /*
            Função com retorno é static
            Método que retorna a nova string modificada:
                FormatReturningString (que retorna a nova string):
                    Replace() cria uma nova string com "Marte" no lugar de "Terra"
                    Essa nova string é retornada e impressa
                    Resultado: "Bom dia, Marte!" é exibido
            */
            static string FormatReturningString(string stringToFormat)

            {
                return stringToFormat.Replace("Earth", "Mars");// Retorna a nova string
            }

            var anotherGreetings = "Good morning Earth!";
            Console.WriteLine(FormatReturningString(anotherGreetings));
        }
    }
}
