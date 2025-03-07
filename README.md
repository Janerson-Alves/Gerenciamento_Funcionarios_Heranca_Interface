# Gerenciamento de Funcionários (Herança e Interface)

## Exercício

Crie um sistema para gerenciar funcionários de uma empresa:

- **Funcionario** (classe base) com nome, salário e método `CalcularBonus()`.
- **Desenvolvedor**, **Gerente** e **Estagiario** (classes derivadas) com regras diferentes para bônus.
- Uma interface `IAvaliavel` com um método `AvaliarDesempenho()`.
- Implementar a interface nas classes e definir critérios de avaliação.

**Regras de Bonificação:**

- **Estagiário**:
  - **Ruim**: 3% de bônus.
  - **Bom**: 7% de bônus.
  - **Ótimo**: 10% de bônus.

- **Gerente**:
  - **Ruim**: 10% de bônus.
  - **Bom**: 15% de bônus.
  - **Ótimo**: 20% de bônus.

- **Desenvolvedor**:
  - **Ruim**: 7% de bônus.
  - **Bom**: 10% de bônus.
  - **Ótimo**: 15% de bônus.

## Descrição do Sistema

Este sistema foi desenvolvido utilizando **herança** e **interfaces** para gerenciar os funcionários de uma empresa. O sistema consiste nas seguintes classes:

### 1. Funcionario (Classe Base)

A classe `Funcionario` serve como base para todos os tipos de funcionários na empresa. Ela contém as propriedades `Nome` e `Salario` e um método `CalcularBonus()`, que será sobrescrito nas classes derivadas. O método `CalcularBonus()` da classe base retorna um valor padrão, mas nas classes derivadas ele será alterado para implementar regras específicas para cada tipo de funcionário.

### 2. Desenvolvedor, Gerente e Estagiário (Classes Derivadas)

As classes `Desenvolvedor`, `Gerente` e `Estagiario` herdam da classe `Funcionario`. Cada uma dessas classes sobrescreve o método `CalcularBonus()` para implementar regras diferentes de cálculo de bônus com base na avaliação de desempenho do funcionário.

- **Desenvolvedor**:
  - O bônus é calculado de acordo com o desempenho do desenvolvedor.
    - **Ruim**: 7% do salário.
    - **Bom**: 10% do salário.
    - **Ótimo**: 15% do salário.

- **Gerente**:
  - O bônus é calculado de acordo com o desempenho do gerente.
    - **Ruim**: 10% do salário.
    - **Bom**: 15% do salário.
    - **Ótimo**: 20% do salário.

- **Estagiário**:
  - O bônus é calculado de acordo com o desempenho do estagiário.
    - **Ruim**: 3% do salário.
    - **Bom**: 7% do salário.
    - **Ótimo**: 10% do salário.

### 3. Interface IAvaliavel

A interface `IAvaliavel` define um método chamado `AvaliarDesempenho()`, que deve ser implementado por todas as classes de funcionários. Esse método será responsável por classificar o desempenho do funcionário como "Ruim", "Bom" ou "Ótimo". O desempenho avaliado influencia diretamente o valor do bônus do funcionário.

### Fluxo de Execução

1. A avaliação do desempenho de cada funcionário é realizada através do método `AvaliarDesempenho()`.
2. Com base na avaliação ("Ruim", "Bom" ou "Ótimo"), o método `CalcularBonus()` calcula o valor do bônus de acordo com as regras específicas de cada tipo de funcionário.
3. O valor do bônus é calculado como um percentual sobre o salário do funcionário, de acordo com a avaliação de desempenho.

### Exemplo de Cálculo de Bônus

- **Estagiário**:
  - Desempenho "Bom", salário de R$ 2000:
    - Bônus = 7% de R$ 2000 = R$ 140.

- **Gerente**:
  - Desempenho "Ótimo", salário de R$ 10000:
    - Bônus = 20% de R$ 10000 = R$ 2000.

- **Desenvolvedor**:
  - Desempenho "Ruim", salário de R$ 6000:
    - Bônus = 7% de R$ 6000 = R$ 420.

### Exemplo de Saída

A saída do programa será exibida no formato abaixo:

Nome: João | Salário: R$2000,00 | Bonus: R$200,00 | Valor Total: R$2200 | Tipo: Estagiário | Avaliação: Otimo

Nome: Maria | Salário: R$6000,00 | Bonus: R$600,00 | Valor Total: R$6600,00 | Tipo: Desenvolvedor | Avaliação: Bom

Nome: José | Salário: R$10000,00 | Bonus: R$1000,00 | Valor Total: R$11000,00 | Tipo: Gerente | Avaliação: Ruim


### Como foi feito

### Herança

- A classe `Funcionario` foi criada como classe base, fornecendo as propriedades comuns entre os funcionários, como `Nome` e `Salario`, além de um método genérico `CalcularBonus()`, que é sobrescrito nas classes derivadas.
- As classes `Desenvolvedor`, `Gerente` e `Estagiario` herdam de `Funcionario` e sobrescrevem o método `CalcularBonus()` para aplicar as regras específicas de cada tipo de funcionário.

### Interface

- A interface `IAvaliavel` define o método `AvaliarDesempenho()`, que permite que cada classe derivada implemente sua própria lógica de avaliação de desempenho.
- Esse método retorna a classificação do desempenho, que é utilizada para calcular o bônus do funcionário, conforme as regras definidas para cada categoria.

Este sistema proporciona flexibilidade e clareza, permitindo a fácil adição de novos tipos de funcionários ou critérios de avaliação, sem a necessidade de grandes alterações no código.



