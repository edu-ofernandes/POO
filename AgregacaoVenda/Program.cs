using AgregacaoVenda;


// VENDA 1 -----------------------------------------------------------------------------------------------------------

Console.WriteLine("VENDA 1 -----------------------------------------------------------------------------------------------------------");

Comprador comprador1 = new Comprador();
comprador1.Nome = "Comprador 1";
comprador1.Verba = 1000.00;

Vendedor vendedor1 = new Vendedor();
vendedor1.Nome = "Vendedor 1";

List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto("Mouse logitech", 59.00));
produtos.Add(new Produto("Teclado logitech", 159.00));
produtos.Add(new Produto("Mouse pad", 29.00));

Venda venda1 = new Venda(comprador1, vendedor1, produtos);

// Subtrair o valor da venda, do total do comprador1
comprador1.Verba = comprador1.Verba - venda1.TotalVenda;

// Aplicar a comissão do vendedor1 de acordo com total da venda
vendedor1.aplicarComissao(venda1.TotalVenda);

comprador1.mostrarAtributo();
vendedor1.mostrarAtributo();
venda1.mostrarAtributos();



// VENDA 2 -----------------------------------------------------------------------------------------------------------

Console.WriteLine("VENDA 2 -----------------------------------------------------------------------------------------------------------");

Comprador comprador2 = new Comprador();
comprador2.Nome = "Comprador 1";
comprador2.Verba = 100000.00;

Vendedor vendedor2 = new Vendedor();
vendedor2.Nome = "Vendedor 1";

List<Produto> produtos2 = new List<Produto>();


produtos2.Add(new Produto("Fone de ouvido moondrop", 79.00));
produtos2.Add(new Produto("Notebook Gamer", 7999.00));

Venda venda2 = new Venda(comprador2, vendedor2, produtos2);

// Subtrair o valor da venda, do total do comprador2
comprador2.Verba = comprador2.Verba - venda2.TotalVenda;

// Aplicar a comissão do vendedor2 de acordo com total da venda
vendedor2.aplicarComissao(venda2.TotalVenda);

comprador2.mostrarAtributo();
vendedor2.mostrarAtributo();
venda2.mostrarAtributos();
