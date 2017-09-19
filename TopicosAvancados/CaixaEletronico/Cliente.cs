using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico.Modelo.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string cpf;
        public string endereco;
        public int idade;
        private bool EEmancipado;

        public Cliente (string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {

        }
    }
}
