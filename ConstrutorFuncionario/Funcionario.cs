namespace ConstrutorFuncionario
{
    public class Funcionario
    {   
        public static int Codigo {get; private set;}
        public int codigo {get; private set;}
        private string Nome {get; set;}
        private double Salario {get; set;}
        public static int Qtd {get; private set;}

        
        public Funcionario(string nome, int codigo, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
            Qtd++;
            Codigo = Codigo + codigo;
            this.codigo = Codigo;
        }
    
        static Funcionario() 
        {
            Qtd = 0;
            Codigo = 100;
        }

        public double novoSalarioReajustado(int taxa)
        {
            if (taxa == 0) throw new Exception("houve um erro com valor da taxa");

            return this.Salario + (taxa / 100 * this.Salario);
        }

        public void mostrarAtributos()
        {
            Console.WriteLine(
                "Código: " + this.codigo + 
                "\tNome: " + this.Nome +
                "\tSalário: " + this.Salario 
            );
        }
    }
}