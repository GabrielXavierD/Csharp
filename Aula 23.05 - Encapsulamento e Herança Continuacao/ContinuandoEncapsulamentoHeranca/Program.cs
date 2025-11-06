namespace ContinuandoEncapsulamentoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto
            {
                Codigo = 102030 // por mais que não tenha construtor, consigo atribuir na inicialização
            };

            //p.Nome = "Coca cola";  ->Erro ao atribuir, pois "Nome" é somente leitura no código da classe Produto
            p.Preco = 5.50;
            Console.WriteLine("Produto1");
            Console.WriteLine("Nome do produto: " + p.Nome);
            // Console.WriteLine("Preço do produto:" + p.Preco);
            //p.Quantidade = 10;
            Console.WriteLine("Quantidade de itens: " + p.Quantidade);
            //p.Codigo = 102030;
            Console.WriteLine("Codigo do produto: " + p.Codigo);

            Console.WriteLine("");
            Console.WriteLine("Produto2");
            Produto2 p1 = new Produto2();
            p1.Nome = "Produto 1";
            p1.Preco = 10.0;
            p1.Imposto = 0.2;

            Console.WriteLine("Nome do produto: " + p1.Nome);
            Console.WriteLine("Preço do produto: " + p1.Preco);
            Console.WriteLine("Imposto: " + p1.Imposto);
            Console.WriteLine("Preço final do produto: " + p1.PrecoFinal);

            Console.WriteLine("");
            Console.WriteLine("ContaBancaria");



            /*
             *•Crie uma classe ContaBancaria com os seguintes atributos: NumeroConta, Saldo e Titular. Criar propriedades para acesso (get e set) aos dados.
                •Analise as necessidades de encapsulamento.
                •Crie os métodos construtor, public bool Depositar(double valor), public bool Sacar(double valor) e public void ExibirSaldo()
             */



            Console.WriteLine("");
            Console.WriteLine("Carro");

            Carro c = new Carro(1986);
            c.Marca = "VW";
            c.Modelo = "Voyage";
            //c.Ano = 1987; // não pode, só pode ser atribuído no construtor

            Console.WriteLine("Marca: " + c.Marca);
            Console.WriteLine("Modelo: " + c.Modelo);
            Console.WriteLine("Ano: " + c.Ano);
            Console.WriteLine("Ano: " + c.Ano);



            /*
             internal class ContaBancaria
 {
     private int _numeroConta;
     private double _saldo;
     private string _titular;

     public ContaBancaria(int numeroConta, string titular)
     {
         NumeroConta = numeroConta;
         Saldo = 0;
         Titular = titular;
     }

     public int NumeroConta { get => _numeroConta; private set => _numeroConta = value; }
     public double Saldo { get => _saldo; private set => _saldo = value; }
     public string Titular { get => _titular; private set => _titular = value; }

     public bool Depositar(double valor)
     {
         if(valor > 0)
         {
             Saldo += valor;
             return true;
         }
         else
         {
             //Console.WriteLine("Valor inválido para depósito!");
             return false;
         }
     }

            public bool Sacar(double valor)
     {
         if (valor>0 && Saldo >= valor)
         {
             Saldo -= valor;
             //Console.WriteLine("Saque efetuado no valor de "+valor);
             return true;
         }
         else
         {
             //Console.WriteLine("Valor inválido para saque ou saldo insuficiente!");
             return false;
         }
     }

     public void ExibirSaldo()
     {
         Console.WriteLine("Saldo da conta: "+Saldo);
     }
 }


             */
        }
    }

}
