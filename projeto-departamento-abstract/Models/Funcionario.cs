namespace projeto_departamento_abstract.Models
{
    public abstract class Funcionario
    {
        protected string Nome { get; set; }
        protected double Salario { get; set; }
        protected int Codigo { get; set; }

        public abstract double CalcularSalario(int diasUteis);

        public virtual void MostrarDados() {
            Console.WriteLine("Código: " + this.Codigo);
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salario: " + this.Salario);
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}