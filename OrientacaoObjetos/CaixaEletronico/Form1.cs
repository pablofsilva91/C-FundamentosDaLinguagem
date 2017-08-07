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
    public partial class Form1 : Form
    {
        private Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.conta.Titular = new Cliente();
            this.conta.Titular.Nome = "Victor";
            this.conta.Deposita(250);
            this.conta.Numero = 1;

            this.MostraConta();

            



        }
        
        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposita(valorDeposito);

            this.MostraConta();


        }

        private void MostraConta()
        {
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoTitular.Text = this.conta.Titular.Nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoValorDoSaque = textoValor.Text;
            double valorDoSaque = Convert.ToDouble(textoValorDoSaque);
            this.conta.Saca(valorDoSaque);

            this.MostraConta();
        }
    }
}
