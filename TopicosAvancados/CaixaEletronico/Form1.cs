using Caelum.CaixaEletronico.Modelo;
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

            contas = new Conta[20];

            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Deposita(250);
            contaDoVictor.Numero = 1;
            contas[0] = contaDoVictor;

            Conta contaDoPablo = new ContaPoupanca();
            contaDoPablo.Titular = new Cliente();
            contaDoPablo.Titular.Nome = "Pablo";
            contaDoPablo.Deposita(250);
            contaDoPablo.Numero = 11;
            contas[1] = contaDoPablo;

            Conta contaDoPaulo = new ContaPoupanca();
            contaDoPaulo.Titular = new Cliente();
            contaDoPaulo.Titular.Nome = "Paulo";
            contaDoPaulo.Deposita(250);
            contaDoPaulo.Numero = 11;
            contas[2] = contaDoPaulo;

            this.numeroDeContas = 3;

            foreach (Conta conta in this.contas)
            {
                if(conta != null)
                {
                    comboContas.Items.Add(conta.Titular.Nome);
                    destinoDaTransferencia.Items.Add(conta.Titular.Nome);
                }
                
            }

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
            Conta contaSelecionada = this.BuscaContaSelecionada();

            string textoValorDoSaque = textoValor.Text;
            double valorDoSaque = Convert.ToDouble(textoValorDoSaque);
            contaSelecionada.Saca(valorDoSaque);

            MostraConta(contaSelecionada);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            ContaPoupanca poupanca = new ContaPoupanca();

            poupanca.Deposita(50);

            TotalizadorDeContas t = new TotalizadorDeContas();
            //t.Adiciona(conta);
           // t.Adiciona(poupanca);

            MessageBox.Show("totalizador : " + t.SaldoTotal);
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

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
            if (this.numeroDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.numeroDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.numeroDeContas] = c;
            this.numeroDeContas++;
            comboContas.Items.Add(c.Titular.Nome);
            
        }

        public void RemoveContas (Conta c)
        {
            comboContas.Items.Remove(c);
            int i;
            for (i = 0; i < this.numeroDeContas; i++)
            {
                if (this.contas[i] == c)
                {
                    break;
                }
            }
            while (i + 1 <= this.numeroDeContas)
            {
                this.contas[i] = this.contas[i+1];
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroDeConta cadastro = new CadastroDeConta(this);
            cadastro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta conta = BuscaContaSelecionada();
            RemoveContas(conta);
        }
    }
}
