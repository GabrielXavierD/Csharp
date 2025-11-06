internal class Pessoa
{
    private string _nome;
    private int _idade;
    private string _cpf;

    public Pessoa()
    {

    }

    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }

    public Pessoa(int idade, string cpf)
    {
        _idade = idade;
        _cpf = cpf;
    }

    public Pessoa(string nome, int idade, string cpf)
    {
        _nome = nome;
        _idade = idade;
        _cpf = cpf;
    }

    public override string ToString()
    {
        return $"Nome: {_nome}, Idade: {_idade}, CPF: {_cpf}";
    }

}