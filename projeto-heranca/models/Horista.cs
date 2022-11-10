namespace projeto_heranca.models
{
    public class Horista : Funcionario
    {
        public double qtdHorasSemana  { get; set; }

        public Horista(int codigo, string nome, double salario, double qtdHorasSemana): base(codigo, nome, salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            this.qtdHorasSemana = qtdHorasSemana;
        }
    }
}