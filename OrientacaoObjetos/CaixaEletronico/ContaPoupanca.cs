using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel 
    {
        public override void Deposita(double valor)
        {
            this.Saldo += (valor + 0.10);
        }
        
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        
    }
}
