using Caelum.CaixaEletronico.Modelo.Contas;
using Caelum.CaixaEletronico.Modelo.Usuarios;
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
       
        public CadastroDeConta (Form1 aplicacaoPrincipal) : this()
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
        }

        public CadastroDeConta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Conta c;

            if(comboTipoConta.Text.Equals("Poupanca"))
            {
                c = new ContaPoupanca();
            }
            else
            {
                c = new ContaCorrente();
            }

            c.Numero = Convert.ToInt32(numeroDaConta.Text);
            c.Titular = new Cliente();
            c.Titular.Nome = titularConta.Text;
            this.aplicacaoPrincipal.AdicionaConta(c);


        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {
            this.comboTipoConta.Items.Add("Poupanca");
            this.comboTipoConta.Items.Add("Corrente");
        }

        private void ComboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
