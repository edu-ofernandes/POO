namespace projeto_heranca.models
{
    public class Mensalista : Funcionario
    {
        public double qtdHoras { get; set; }

        public Mensalista(int codigo, string nome, double salario, double qtdHoras): base(codigo, nome, salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            this.qtdHoras = qtdHoras;
        }
    }
}