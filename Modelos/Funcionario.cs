namespace GerenciamentoFuncionarios.Modelos;

public class Funcionario
{
    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public string Nome { get; set; }
    public double Salario { get; set; }

    public virtual double CalcularBonus()
    {
        return 0;
    }
}


