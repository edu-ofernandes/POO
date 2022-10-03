using System;
using System.Collections.Generic;
using System.Linq;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {   
        private int Codigo {get; set;}
        private string Nome {get; set;}
        private float Salario {get; set;}
        public static int Qtd {get; private set;}

        
        public Funcionario()
        {
            Qtd = Qtd + 1;
        }
    
        static Funcionario() 
        {
            Qtd = 100;
        }

        public float novoSalarioReajustado(int taxa)
        {
            if (taxa == 0) throw new Exception("houve um erro com valor da taxa");

            return this.Salario + (taxa / 100 * this.Salario);
        }

        public static int mostrarInstancias()
        {
            return Qtd;
        }
    }
}