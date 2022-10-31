namespace composicao_banco.models
{
    public class Poupanca
    {
        private double saldo {get; set;}
        public Poupanca() {
            Console.WriteLine("iniciado poupança.");
        }

       ~Poupanca() {
        Console.WriteLine("destrutor poupança.");
       } 
    }
}