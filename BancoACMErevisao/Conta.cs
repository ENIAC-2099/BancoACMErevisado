using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACMErevisao
{
    abstract class Conta
    {
        String contaID;
        String nomeCorrentista;
        double saldoAtual;

        protected Conta(string contaID, string nomeCorrentista)
        {
            this.contaID = contaID;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string ContaID { get => contaID; }
        public string NomeCorrentista { get => nomeCorrentista; }
        public double SaldoAtual { get => saldoAtual; }

        public virtual void SacarValor(double quantia, double tarifaSaque)
        {
            double valorDebitado = quantia + quantia * tarifaSaque;
            if((SaldoAtual - valorDebitado) >= 0)
            {
                ReduzirSaldo(valorDebitado);
            }
            else
            {
                Console.WriteLine("Saque não realizada. Saldo Insuficiente");
                Console.ReadLine();
            }
        }

        public virtual void TransferirPraOutraConta(double quantia,
            Conta contaDestino, double tarifaTransferencia)
        {
            double valorDebitado = quantia + quantia*tarifaTransferencia;
            if((SaldoAtual - valorDebitado) >= 0)
            {
                ReduzirSaldo(valorDebitado);
            }
            else
            {
                Console.WriteLine("Transferencia não realizada. Saldo Insuficente");
                Console.ReadLine();
            }
        }

        protected void ReduzirSaldo(double quantia)
        {
            saldoAtual -= quantia;
        }

        protected void AumentarSaldo(double quantia)
        {
            saldoAtual += quantia;
        }

        public double ConsultarSaldo()
        {
            return saldoAtual;
        }

        public void DepositarValor(double quantia)
        {
            saldoAtual += quantia;
            Console.WriteLine($"Valor depositado - {quantia.ToString("C")}");
        } 

        
    }
}
