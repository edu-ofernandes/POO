namespace projeto_departamento_abstract.Models
{
    public class Dependente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public Dependente(int codigo, string nome, int idade) 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.idade = idade;
        }
    }
}