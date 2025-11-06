class Personagem
{
    public String nome;
    public int x;
    public int y;
    public int itensColetados;

    public Personagem(String nome, int x, int y, int itensColetados)
    {
        this.nome = nome;
        this.x = x;
        this.y = y;
        this.itensColetados = itensColetados;
    }

    public void Atacar(double dano)
    {
        Console.WriteLine("O personagem " + nome + " atacou com um dano de " + dano);
    }

    public void Movimentar(int direcao)
    {
        switch (direcao)
        {
            case 1:
                Console.WriteLine("O personagem " + nome + " se moveu para frente.");
                x++;
                break;
            case 2:
                Console.WriteLine("O personagem " + nome + " se moveu para trás.");
                x--;
                break;
            case 3:
                Console.WriteLine("O personagem " + nome + " se moveu para a direita.");
                y++;
                break;
            case 4:
                Console.WriteLine("O personagem " + nome + " se moveu para a esquerda.");
                y--;
                break;
            default:
                Console.WriteLine("Direção inválida.");
                break;
        }
    }
}