namespace projeto_departamento_abstract.Models
{
    public abstract class Funcionario
    {
        protected string Nome { get; set; }
        protected double Salario { get; set; }
        protected int Codigo { get; set; }
        public List<Dependente> dependetes { get; set; }

        public void getTotalDependetes() 
        {
            System.Console.WriteLine("Total de dependetes do funcionário " + this.Nome + ": " + this.dependetes.Count);
        }
        public int getTotalDependetesDepartamento() 
        {
            return this.dependetes.Count;
        }

        public void listDependete()
        {
            this.dependetes.ForEach((Dependente dependente) => {
                System.Console.WriteLine("Codigo: " + dependente.codigo);
                System.Console.WriteLine("Nome: " + dependente.nome);
                System.Console.WriteLine("Idade: " + dependente.idade);
            });
        }

        public void removeDependete(int codigoDependete)
        {
            this.dependetes.ForEach((Dependente dependente) => {
                if (dependente.codigo == codigoDependete) {
                    this.dependetes.Remove(dependente);
                }
            });
        }
        public void addDependete(Dependente dependete)
        {
            this.dependetes.Add(dependete);
        }
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
            this.dependetes = new List<Dependente>();
        }
    }
}