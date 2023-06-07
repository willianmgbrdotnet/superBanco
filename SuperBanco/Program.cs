using System;

namespace SuperBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco contaB = new ContaBanco("Diogo", 10000);
            System.Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo} dinheiros");

        }
        
    }    
}