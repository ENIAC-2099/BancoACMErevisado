using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACMErevisao
{
    internal class ContaPoupanca:Conta
    {
        const double tarifaSaque = 0.20 / 100;
        const double tarifaTransferencia = 0.15 / 100;

        public ContaPoupanca(string contaID, string nomeCorrentista):base(contaID, nomeCorrentista)
        {
            
        }

        public void SacarValor(double quantia)
        {
            base.SacarValor(quantia, tarifaSaque);
        }

        public void TransferirPraOutraConta(double quantia, Conta contadestinatario)
        {
            base.TransferirPraOutraConta(quantia, contadestinatario, tarifaTransferencia);
        }
    }
}
