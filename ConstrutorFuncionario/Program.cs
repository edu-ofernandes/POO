using ConstrutorFuncionario;

Funcionario funcionario1  = new Funcionario("Funcionario 1", 1, 4500.00);
Funcionario funcionario2  = new Funcionario("Funcionario 2", 2, 2500.00);
Funcionario funcionario3  = new Funcionario("Funcionario 3", 3, 2000.00);


funcionario1.mostrarAtributos();

funcionario2.mostrarAtributos();

funcionario3.mostrarAtributos();

Console.WriteLine("Quantidades de instâncias de Funcionário -> " + Funcionario.Qtd);




