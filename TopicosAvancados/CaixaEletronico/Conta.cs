using Caelum.CaixaEletronico.Modelo.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico.Modelo.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set;}
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Deposita (double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public abstract void Saca(double valor);
    }
}
