using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBanco
{
    public class ContaBanco
    {
        //Apenas "get" pois o usuário não vai "setar" o numero da conta.
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo 
        {
            //O saldo vai sofrer alterações a cada transação feita na lista de transações.
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes)
                {
                    saldo += item.Valor;
                }
                return saldo;
            }
        }
        public static int numeroConta = 123450;

        private List<Transacao> todasTransacoes = new List<Transacao>();
        
        //Método Construtor para gerar um novo Objeto deste tipo(classe)
        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;

            //A partir de agora o valor do Saldo não será mais o especificado na construção do objeto,
            //começará com 0(zero) e as transações se encarregarão disso.
            /*this.Saldo = valor;*/

            //Auto-gera um novo numero de conta para cada novo Objeto
            numeroConta++;

            //Converterá numeroConta de int para string, uma vez que a 
            //propriedade Numero é do tipo string
            this.Numero = numeroConta.ToString();
        }

        //Métodos ou funções da Conta
        public void Depositar()
        {
            
        }
        public void Sacar()
        {
            
        }


    }
}