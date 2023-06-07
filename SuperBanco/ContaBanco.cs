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

            //Auto-gera um novo numero de conta para cada novo Objeto
            numeroConta++;
            //Converterá numeroConta de int para string, uma vez que a 
            //propriedade Numero é do tipo string
            this.Numero = numeroConta.ToString();

            Depositar(valor, DateTime.Now, "Saldo inicial");
        }

        //Métodos ou funções da Conta
        public void Depositar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos depósito de valor 0 ou negativo");
            }
            var trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);
        }
        public void Sacar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos saque de valor 0 ou negativo");
            }
            if(Saldo - valor < 0)
            {
                throw new InvalidOperationException("Saldo insuficiente. Operação não permitida."); 
            }
            //A diferença do Depositar é o valor negativo
            var trans = new Transacao(-valor, data, obs);
            todasTransacoes.Add(trans);
        }


    }
}