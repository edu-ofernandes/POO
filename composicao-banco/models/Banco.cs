namespace composicao_banco.models
{
    public class Banco
    {
        private List<Poupanca> poupanca;
        private List<ContaCorrente> contaCorrente;
        public Banco(List<ContaCorrente> contaCorrente, List<Poupanca> poupanca) {
            this.contaCorrente = contaCorrente;
            this.poupanca = poupanca;
        }
        ~Banco() {
            Console.WriteLine("destrutor banco.");
            this.poupanca = null;
            this.contaCorrente = null;
        }
    }
}