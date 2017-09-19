﻿using Caelum.CaixaEletronico.Modelo.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Adiciona (Conta conta)
        {
            SaldoTotal += conta.Saldo;
        }
    }
}
