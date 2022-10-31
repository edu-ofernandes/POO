namespace composicao_banco.models
{
    public class ContaCorrente
    {
        private double saldo {get; set;}
        private bool chequeEspecial {get; set;}
        public ContaCorrente() {
            Console.WriteLine("");
        }
        
        public void addSaldo(double valor) {
            this.saldo += valor;
        }
        ~ContaCorrente(){
            Console.WriteLine("destrutor contaCorrente");
        }
    }
}