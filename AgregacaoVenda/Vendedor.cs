namespace AgregacaoVenda
{
    public class Vendedor
    {
        public Vendedor()
        {
            this.TaxaVendedor = 0.02;
        }
        public string? Nome {get; set;}
        private double Comissao {get; set;}
        public double TaxaVendedor {get; private set;}

        public void mostrarAtributo()
        {
            Console.WriteLine( 
                "Informações do vendedor -------------------------\n" +
                "Nome vendedor: " + this.Nome +
                "\tTotal de comissão: R$ " + this.Comissao
            );
        }

        public void aplicarComissao(double valorVenda)
        {
            this.Comissao = this.Comissao + (valorVenda * this.TaxaVendedor);
        }
    }
}