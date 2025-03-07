namespace GerenciamentoFuncionarios.Modelos;

public class Gerente : Funcionario
{
    public Gerente(string nome, double salario) : base(nome, salario)
    {
    }

    public string Avaliacao { get; set; }

    public Funcionario Funcionario { get; set; }

    public override double CalcularBonus()
    {
        if (Avaliacao == "Bom")
            return Salario * 0.15;
        else if (Avaliacao == "Otimo")
            return Salario * 0.20;
        else
            return Salario * 0.10;
    }

    public void AvaliarFuncionario(string avaliacao)
    {
        Avaliacao = avaliacao;
    }


    public override string ToString()
    {
        return $"Nome: {Nome} | Salário: R${Salario:F2} | Bonus: R${CalcularBonus():F2} | Valor Total: R${Salario + CalcularBonus():F2} | Tipo: Gerente" +
            $" | Avaliação: {Avaliacao}";
    }

}
