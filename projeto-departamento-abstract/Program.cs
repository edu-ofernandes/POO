using projeto_departamento_abstract.Models;

// Funcionario funcionario = new Funcionario();
Assalariado assalariado = new Assalariado(100, "Eduardo", 5.000);
Comissionado comissionado = new Comissionado(101, "Eduardo 2", 2.000, 0.20);
comissionado.MostrarDados();

Departamento departamentoTI = new Departamento(200,"TI");
Departamento departamentoRH = new Departamento(200,"RH");

departamentoRH.adicionarFuncionario(assalariado);
departamentoTI.adicionarFuncionario(comissionado);
