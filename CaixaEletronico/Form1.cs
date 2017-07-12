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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numeroDaConta = 1;
            double saldo = 250;
            double valorDoSaque = 300;
            double valorAposSaque = saldo - valorDoSaque;
            bool podeSacar = (valorDoSaque <= saldo) && (valorDoSaque > 0);

            if (podeSacar)
            {
                saldo = saldo - valorDoSaque;
                MessageBox.Show("Saque realizado com sucesso! Seu saldo é: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade1 = 13;
            int idade2 = 56;
            int idade3 = 47;
            double media = (idade1 + idade2 + idade3) / 3;

            MessageBox.Show("Média de idades: " + media);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 240;
            int c = 9;

            double a1;
            double a2;
            double delta;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("A1 = " + a1, "A2 = " + a2);
        }
    }
}
