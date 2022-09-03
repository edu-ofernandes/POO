using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string? descricao;
        public double preco;

        public void show() {
            Console.WriteLine(this.codigo);
            Console.WriteLine(this.descricao);
            Console.WriteLine(this.preco);
        }

        public void addPercentage(double percent) {
            this.preco = this.preco - (this.preco * percent);
        }
    }
}