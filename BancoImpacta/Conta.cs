using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoImpacta
{
    internal class Conta
    {
        #region Atributos

        public int NConta;
        public string Titular;
        public decimal Saldo;
        public bool ContaVIP = false;   // Permite o saldo ficar negativo após o saque ou transferência
        private decimal chequeEspecial = 1000.0m;    // Limite negativo máximo

        #endregion


        #region Construtores
        public Conta()
        {

        }

        // Hoje em dia, o Garbage Collector é feito de forma automática ao terminar de utilizar o método ou classe
        //~Conta()    // Destrutor - Está relacionado ao Garbage Collector
        //{
        //    Console.WriteLine("Objeto Finalizado!");
        //}

        public Conta(int nconta)
        {
            NConta = nconta;
        }

        public Conta(int nconta, string titular)
        {
            NConta = nconta;
            Titular = titular;
        }

        #endregion


        #region Métodos
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual do titular {Titular} (conta {NConta}) é R$ {Saldo:0.00}");
        }

        public void Sacar(decimal valor)
        {
            if (ContaVIP == true)
            {
                if ((Saldo - valor) < (-chequeEspecial))
                {
                    Console.WriteLine("O saque desejado é maior que o limite do cheque especial. Operação não Realizada.");
                }
                else
                {
                    Saldo -= valor;
                }
            }
            else    // conta não VIP
            {
                if ((Saldo - valor) < 0.0m)
                {
                    Console.WriteLine("O saque desejado é maior que o saldo da conta. Operação não Realizada.");
                }
                else
                {
                    Saldo -= valor;
                }
            }

        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Transferir(Conta contaReceber, decimal valor)
        {
            if (ContaVIP == true)
            {
                if ((Saldo - valor) < (-chequeEspecial))
                {
                    Console.WriteLine("A transferência desejada é maior que o limite do cheque especial. Operação não Realizada.");
                }
                else
                {
                    Saldo -= valor;
                    contaReceber.Saldo += valor;
                }
            }
            else
            {
                if ((Saldo - valor) < 0.0m)
                {
                    Console.WriteLine("A transfêrencia solicitada é maior que o saldo da conta. Operação não Realizada.");
                }
                else
                {
                    Saldo -= valor;
                    contaReceber.Saldo += valor;
                }
            }
        }

        #endregion

    }
}
