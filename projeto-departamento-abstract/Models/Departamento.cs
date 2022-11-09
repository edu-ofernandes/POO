namespace projeto_departamento_abstract.Models
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> funcionarios { get; set; }

        public Departamento(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.funcionarios = new List<Funcionario>();
        }

        public void adicionarFuncionario(Funcionario funcionario)
        {
            this.funcionarios.Add(funcionario);
        }
    }
}