using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public class Conta
    {
        public int numero;
        
        public double saldo;
        
        public int agencia;

        public Cliente cliente;

        public double calculoRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i =0; i <12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }

        public void saca(double valor)
        {
            if (valor <= saldo && valor > 0)
            {
                this.saldo -= valor;
                MessageBox.Show("Saque realizado com sucesso. Saldo atual: " +saldo);
                
            }
            else
            {
                MessageBox.Show("nao foi possível sacar");
            }
        }

        public void deposita(double valor)
        {
            if (valor >= 0)
            {
                this.saldo += valor;
                MessageBox.Show("Depósito realizado com sucesso. Saldo atual: " +saldo);

            }
            else
            {
                MessageBox.Show("valor inválido");
            }
        }

        public void transfere (Conta destino, double valor)
        {

            if(this.saldo >= valor)
            {
                this.saca(valor);
                destino.deposita(valor);

                MessageBox.Show("Transferencia realizada com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a operação");
            }
            
        }

    }
}
