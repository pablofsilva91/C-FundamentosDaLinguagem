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
        
        private Conta[] contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            contas = new Conta[2];

            Conta contaDoVictor = new Conta();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Deposita(250);
            contaDoVictor.Numero = 1;
            contas[0] = contaDoVictor;

            Conta contaDoPablo = new Conta();
            contaDoPablo.Titular = new Cliente();
            contaDoPablo.Titular.Nome = "PAblo";
            contaDoPablo.Deposita(250);
            contaDoPablo.Numero = 11;
            contas[1] = contaDoPablo;

            /*
            contas[0].Titular = new Cliente();
            contas[0].Titular.Nome = "Victor";
            contas[0].Deposita(250);
            contas[0].Numero = 1;
            */

            foreach (Conta conta in this.contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
                destinoDaTransferencia.Items.Add(conta.Titular.Nome);
            }

           // this.MostraConta();

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
            //int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.BuscaContaSelecionada();

            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            contaSelecionada.Deposita(valorDeposito);
            
           
            MostraConta(contaSelecionada);
        }

        
        private void MostraConta(Conta conta)
        {

            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = conta.Titular.Nome;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.BuscaContaSelecionada();

            string textoValorDoSaque = textoValor.Text;
            double valorDoSaque = Convert.ToDouble(textoValorDoSaque);
            contaSelecionada.Saca(valorDoSaque);

            MostraConta(contaSelecionada);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            Conta conta = new Conta();
            ContaPoupanca poupanca = new ContaPoupanca();

            conta.Deposita(100);
            poupanca.Deposita(50);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(conta);
            t.Adiciona(poupanca);

            MessageBox.Show("totalizador : " + t.SaldoTotal);
            
            /*
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            Banco banco = new Banco();

            banco.adiciona(c1);
           
            MessageBox.Show(" numero da conta: " + c1.Numero);

            banco.adiciona(c2);

            MessageBox.Show(" numero da conta: " + c2.Numero);

            */

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];


            //textoTitular.Text = contaSelecionada.Titular.Nome;
            //textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            //textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

            this.MostraConta(contaSelecionada);
        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private Conta BuscaContaDestino()
        {
            int indiceSelecionado = destinoDaTransferencia.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void destinoDaTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = destinoDaTransferencia.SelectedIndex;
            Conta contaDestino = contas[indiceSelecionado];

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            string textoValorDoSaque = textoValor.Text;
            double valorDoSaque = Convert.ToDouble(textoValorDoSaque);
            contaSelecionada.Saca(valorDoSaque);

            Conta contaDestino = this.BuscaContaDestino();

            string textoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoValorDoDeposito);
            contaDestino.Deposita(valorDeposito);

            this.MostraConta(contaSelecionada);
        }

        public void AdicionaConta (Conta c)
        {
            this.contas[this.numeroDeContas] = c;
            this.numeroDeContas++;
            comboContas.Items.Add(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroDeConta cadastro = new CadastroDeConta(this);
            cadastro.ShowDialog();
        }
    }
}
