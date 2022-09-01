using ArrayProduto;

Produto[] produtos  = new Produto[5];

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

Console.WriteLine("Informe o descricao, preço e código!!");

foreach (Produto produto in produtos) {
    produto.show();
}
