namespace composicao_notafiscal.models
{
    public class ItemNotaFiscal
    {
        public int qtd {get; set;}
        public ItemNotaFiscal(int qtd)
        {
            this.qtd = qtd;
        }

        ~ItemNotaFiscal() {
            Console.WriteLine("Destrutor ItemNotaFiscal");
        }
    }
}