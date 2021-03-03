using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        #region Atributos
        public int agencia { get; set; }
        public int numero { get; set; }
        private double _saldo;
        public Cliente Titular { get; set; } = new Cliente();
        public static int TotalContas { get; private set; }
        #endregion

        #region Construtor
        public ContaCorrente(int p_agencia, int p_numero)
        {
            agencia = p_agencia;
            numero = p_numero;
            TotalContas++;
        }
        #endregion

        #region Propriedades

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;

                _saldo = value;
            }
        }



        //Exemplos
        public void SetSaldoEx(double valor)
        {
            if (valor <= 0)
                return;

            _saldo = valor;
        }

        public double GetSaldoEx()
        {
            return _saldo;
        }
        #endregion

        #region Métodos

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > _saldo)
                return false;

            _saldo -= valor;
            return true;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor > _saldo)
                return false;

            _saldo -= valor;
            contaDestino._saldo += valor;
            return true;

        }

        #endregion

        #region Métodos Override
        //Subescrevendo o método ToString da Classe.
        public override string ToString()
        {
            return $"Titular: {Titular.nome}\nAgência: {agencia}\nNúmero: {numero}\nSaldo: R$ {_saldo}\n";
        }
        #endregion
    }
}






