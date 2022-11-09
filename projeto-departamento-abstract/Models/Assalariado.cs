namespace projeto_departamento_abstract.Models
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salario): base(codigo, nome, salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }

        public override double CalcularSalario(int diasUteis)
        {
            return this.Salario / 30 * diasUteis;
        }
    }
}