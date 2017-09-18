using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int Numero { get; set;}
        public double Saldo {get; protected set;}

        public Cliente Titular { get; set; }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public virtual void Deposita (double valor)
        {
            this.Saldo += valor;
        }
    }
}
