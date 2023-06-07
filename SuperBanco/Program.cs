﻿using System;

namespace SuperBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criado um novo Objeto do tipo ContaBanco, sendo obrigado a 
            //setar o nome e o valor no momento da criação da conta. 
            ContaBanco contaB = new ContaBanco("Diogo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo} dinheiros"); 

            contaB.Depositar(200, DateTime.Now, "Dividendos");
            Console.WriteLine($"A conta está com {contaB.Saldo}");

            contaB.Sacar(500, DateTime.Now, "Happy Hour");
            Console.WriteLine($"A conta está com {contaB.Saldo}");

        }
        
    }    
}