using projeto_departamento_abstract.Models;

// Funcionario funcionario = new Funcionario();
Dependente dependente1 = new Dependente(100, "Dependete 1", 30);
Dependente dependente2 = new Dependente(101, "Dependete 2", 20);
Dependente dependente3 = new Dependente(102, "Dependete 3", 22);
Dependente dependente4 = new Dependente(103, "Dependete 4", 50);


Assalariado assalariado = new Assalariado(100, "Eduardo", 5.000);
assalariado.addDependete(dependente1);
assalariado.addDependete(dependente4);
assalariado.getTotalDependetes();


Comissionado comissionado = new Comissionado(101, "Eduardo 2", 2000, 0.20);
comissionado.addDependete(dependente2);
comissionado.addDependete(dependente3);


Console.WriteLine(comissionado.CalcularSalario(10));
comissionado.MostrarDados();

Departamento departamentoTI = new Departamento(200,"TI");
Departamento departamentoRH = new Departamento(200,"RH");

departamentoRH.adicionarFuncionario(assalariado);
departamentoTI.adicionarFuncionario(comissionado);

departamentoRH.calcularDependetes();
departamentoTI.calcularDependetes();