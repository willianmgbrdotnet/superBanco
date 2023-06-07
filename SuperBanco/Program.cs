using System;

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

        }
        
    }    
}