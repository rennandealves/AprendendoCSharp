﻿//using _05_ByteBank; Como está compartilhando namespace, não é necessário declarar esse código

namespace _07_ByteBank
{
    class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public static int TotaldeContasCriadas { get; private set; }

        public static int ObterTotaldeContasCriadas()
        {
            return TotaldeContasCriadas;
        }

        public int _agencia;
        
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int Numero { get; set; }


        private double _saldo = 100;
                     
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotaldeContasCriadas++;
        }

              
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }
}

