using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;
            string nacionalidade = "brasileira";
            bool brasileira = (idade >= 16) && (nacionalidade == "brasileira");

            if (brasileira)
            {
                MessageBox.Show("Pode votar!");
            }
            else
            {
                MessageBox.Show("Não pode votar");
            }
        }
    }
}
