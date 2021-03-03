using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo)
                return false;

            saldo -= valor;
            return true;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor > saldo)
                return false;

            saldo -= valor;
            contaDestino.saldo += valor;
            return true;

        }

        

        //Subescrevendo o método ToString da Classe.
        public override string ToString()
        {
            return $"Titular: {titular}\nAgência: {agencia}\nNúmero: {numero}\nSaldo: R$ {saldo}\n";
        }
    }
}






