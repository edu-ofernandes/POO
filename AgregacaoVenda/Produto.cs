namespace AgregacaoVenda
{
    public class Produto
    {
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            Codigo = Codigo + 1;
        }
        static Produto()
        {
            Codigo = 500;
        }
        public static int Codigo {get; private set;}        
        private string Nome {get; set;}
        private double preco;

        public double Preco
        {
            get {return preco;}
            set {preco = value;}
        }
        public void mostrarAtributos()
        {
            Console.WriteLine( 
                "Código:" + Codigo +
                "\tNome: " + this.Nome +
                "\tPreço: " + this.Preco
            );
        }


        
    }
}