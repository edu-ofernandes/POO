using ArrayProduto;

Produto[] produtos  = new Produto[2];

for (int i = 0; i < produtos.Length; i++) {
    produtos[i] = new Produto();
    // Produto produto = produtos[i];

    Console.WriteLine("Informe o descricao, preço e código!!");

    Console.WriteLine("Informe a descrição");
    produtos[i].descricao = Console.ReadLine();

    Console.WriteLine("Informe o código");
    produtos[i].codigo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o valor");
    produtos[i].preco = Convert.ToDouble(Console.ReadLine());

    // produtos[i].add(produtos[i]);    
}

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Mostrando valores antes do desconto");

foreach (Produto produto in produtos) {
    produto.show();
}

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Mostrando valores depois do desconto");

for (int i = 0; i < produtos.Length; i++) {
    Console.WriteLine("====================================================");
    Console.WriteLine("Informa o valor de desconto para o produto: " + produtos[i].descricao + " em inteiro ex: 10% === 10");

    double percent = Convert.ToInt32(Console.ReadLine());

    produtos[i].addPercentage(percent / 100);
}

foreach (Produto produto in produtos) {
    produto.show();
}