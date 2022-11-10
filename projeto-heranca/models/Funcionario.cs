namespace projeto_heranca.models
{
    public class Funcionario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }
    }
}