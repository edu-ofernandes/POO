namespace AgregacaoVenda
{
    public class Venda
    {
        public Venda(Comprador comprador, Vendedor vendedor, List<Produto> produtos)
        {
            this.Comprador = comprador;
            this.Vendedor = vendedor;
            
            if (produtos.Count > 0) 
            {
                foreach (Produto produto in produtos)
                {
                    this.produtos.Add(produto);
                    this.TotalVenda = this.TotalVenda + produto.Preco;
                }
            }
        }
        private List<Produto> produtos = new List<Produto>();
        public Comprador Comprador {get; private set;}
        public Vendedor Vendedor {get; private set;}
        public double TotalVenda {get; private set;}
        public void mostrarAtributos()
        {
            Console.WriteLine( 
                "Informações da venda -------------------------\n" +
                "Nome comprador:" + this.Comprador.Nome +
                "\tNome vendedor: " + this.Vendedor.Nome +
                "\tTotal de itens: " + this.produtos.Count +
                "\tTotal venda: R$ " + this.TotalVenda
            );
        }
    }
}