using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACMErevisao
{
    internal class ContaCorrente:Conta
    {
        const double tarifaSaque = 0.37 / 100;
        const double tarifaTransferencia = 0.10 / 100;

        public ContaCorrente(string contaID, string nomeCorrentista):base( contaID, nomeCorrentista)
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
