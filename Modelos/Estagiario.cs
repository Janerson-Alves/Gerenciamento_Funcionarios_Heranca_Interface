using GerenciamentoFuncionarios.Interfaces;

namespace GerenciamentoFuncionarios.Modelos;

public class Estagiario : Funcionario, IAvaliacaoFuncionarios
{
    public Estagiario(string nome, double salario) : base(nome, salario)
    {
    }

    public string Avaliacao { get; set; }

    public override double CalcularBonus()
    {
        if (Avaliacao == "Bom")
            return Salario * 0.07;
        else if (Avaliacao == "Otimo")
            return Salario * 0.10;
        else
            return Salario * 0.03;
    }

    public void AvaliarFuncionario(string avaliacao)
    {
        Avaliacao = avaliacao;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Salário: R${Salario:F2} | Bonus: R${CalcularBonus():F2} | Valor Total: R${Salario + CalcularBonus()} | Tipo: Estagiário" +
            $" Avaliação: {Avaliacao}";
    }



}
