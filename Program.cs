using GerenciamentoFuncionarios.Modelos;

Estagiario estagiario = new Estagiario("João", 2000);
estagiario.AvaliarFuncionario("Otimo");
Console.WriteLine(estagiario);

Desenvolvedor desenvolvedor = new Desenvolvedor("Maria", 6000);
desenvolvedor.AvaliarFuncionario("Bom");
Console.WriteLine(desenvolvedor);

Gerente gerente = new Gerente("José", 10000);
gerente.AvaliarFuncionario("Ruim");
Console.WriteLine(gerente);