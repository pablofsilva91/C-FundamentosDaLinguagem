using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosDivisiveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 23;

            if((num % 3) == 0){
                MessageBox.Show("Número é divisível por 3");
            }
            else if (num % 4 == 0){
                MessageBox.Show("Número é divisível por 4");
            }
            else
            {
                MessageBox.Show("Número não é divisível");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if ((i % 3 == 0) || (i % 4 == 0))
                {
                    MessageBox.Show(" Múltiplo de 3 ou 4: " +i);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 != 0)
                {
                    soma += i;
                }
            }
            MessageBox.Show("Soma: " + soma);
        }
    }
}
