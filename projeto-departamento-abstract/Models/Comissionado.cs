namespace projeto_departamento_abstract.Models
{
    public class Comissionado : Funcionario
    {

        public double Porcentagem { get; set; }

        public Comissionado(int codigo, string nome, double salario, double porcentagem) : base(codigo, nome, salario)
        {
            this.Porcentagem = porcentagem;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return this.Salario / 30 * diasUteis * this.Porcentagem + this.Salario;
        }
        public override void MostrarDados() {
            base.MostrarDados();
            Console.WriteLine("Porcentagem: " + this.Porcentagem);
        }
    }
}