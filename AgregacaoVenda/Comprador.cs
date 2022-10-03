namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;

        public double Verba 
        {
            get { return verba;}
            set { verba = value; }
        }
        
        private string? nome;

        public string Nome 
        {
            get {return nome.ToUpper(); }
            set { nome = value; }
        }

        public void mostrarAtributo()
        {
             Console.WriteLine( 
                "Informações do comprador -------------------------\n" +
                "Nome comprador: " + this.Nome +
                "\tTotal de verba restante: R$ " + this.verba
            );
        }
    }
}