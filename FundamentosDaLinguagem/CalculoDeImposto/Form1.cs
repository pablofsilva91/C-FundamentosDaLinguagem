using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 145600.0;
            double imposto;

            if (valorDaNotaFiscal < 1000.0)
            {
                imposto = (valorDaNotaFiscal * 2) / 100;
               
            }
            else if ((valorDaNotaFiscal >= 1000.0) && (valorDaNotaFiscal < 3000.0))
            { 
                 imposto = (valorDaNotaFiscal * 2.5) / 100;
               
            }
            else if ((valorDaNotaFiscal >= 3000.0) && (valorDaNotaFiscal < 7000.0))
            {
                imposto = (valorDaNotaFiscal * 2.8) / 100;
               
            }
            else
            {
                imposto = (valorDaNotaFiscal * 3) / 100;
                
            }

            MessageBox.Show("Imposto:" + imposto);



        }
        }
    }
