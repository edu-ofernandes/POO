using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        public int Numero {get; set;}
        public string Titular  {get; set;}
        public double Saldo {get; set;}

        public void transferirDinheiro(int valor, Conta objConta) {
            Saldo = Saldo + valor;
            objConta.Saldo = valor;
        }
    }
}