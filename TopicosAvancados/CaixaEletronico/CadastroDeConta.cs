using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private Form1 aplicacaoPrincipal;
       
        public CadastroDeConta (Form1 aplicacaoPrincipao)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta c = null;

            if(ComboTipoConta.Text == "Poupanca")
            {
                c = new ContaPoupanca();
            }
            else
            {
                c = new ContaCorrente();
            }

            c.Numero = Convert.ToInt32(numeroDaConta.Text);
            c.Titular = new Cliente(titularConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(c);
        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {

        }

        private void ComboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboTipoConta.Items.Add("Poupanca");
            ComboTipoConta.Items.Add("Corrente");
        }
    }
}
