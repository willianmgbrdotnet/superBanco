using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBanco
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo { get; set; }

        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;
            this.Saldo = valor;
            
        }
    }
}