using System;

namespace BancoACMErevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBob = new ContaCorrente("12345-6", "Bob Nelson");
            ContaPoupanca contaTestolfo = new ContaPoupanca("71717-1", "Testolfo Rocha");
            ContaPoupanca contaLisa = new ContaPoupanca("65432-1", "Lisa Leite");

            contaBob.DepositarValor(5000);
            contaLisa.DepositarValor(2000);
            contaTestolfo.DepositarValor(1500);

            Console.WriteLine($"Saldo da conta do {contaBob.NomeCorrentista} " +
                $"é { contaBob.SaldoAtual.ToString("C")}");
            Console.WriteLine($"Saldo da conta do {contaLisa.NomeCorrentista} " +
                $"é { contaLisa.SaldoAtual.ToString("C")}");
            Console.WriteLine($"Saldo da conta do {contaTestolfo.NomeCorrentista} " +
                $"é { contaTestolfo.SaldoAtual.ToString("C")}");
            Console.ReadLine();

            contaBob.TransferirPraOutraConta(600, contaTestolfo);
            Console.WriteLine($"{contaBob.NomeCorrentista} realizou uma transferencia para {contaTestolfo.NomeCorrentista}");
            Console.ReadLine();

            contaLisa.SacarValor(250);
            Console.WriteLine($"{contaLisa.NomeCorrentista} realizou um saque.");
            Console.ReadLine();

            contaLisa.TransferirPraOutraConta(400, contaTestolfo);
            Console.WriteLine($"{contaLisa.NomeCorrentista} realizou uma transferencia para {contaTestolfo.NomeCorrentista}");
            Console.ReadLine();

            contaTestolfo.TransferirPraOutraConta(1000, contaBob);
            Console.WriteLine($"{contaTestolfo.NomeCorrentista} realizou uma transferencia para {contaBob.NomeCorrentista}");
            Console.ReadLine();

            contaBob.SacarValor(900);
            Console.WriteLine($"{contaBob.NomeCorrentista} realizou um saque.");
            Console.ReadLine();

            contaBob.TransferirPraOutraConta(1500, contaLisa);
            Console.WriteLine($"{contaBob.NomeCorrentista} realizou uma transferencia para {contaLisa.NomeCorrentista}");
            Console.ReadLine();

            contaTestolfo.TransferirPraOutraConta(1200, contaLisa);
            Console.WriteLine($"{contaTestolfo.NomeCorrentista} realizou uma transferencia para {contaLisa.NomeCorrentista}");
            Console.ReadLine();

            contaBob.SacarValor(2000);
            Console.WriteLine($"{contaBob.NomeCorrentista} realizou um saque.");
            Console.ReadLine();

            contaLisa.DepositarValor(100);
            Console.WriteLine($"{contaLisa.NomeCorrentista} realizou um deposito.");
            Console.ReadLine();

            contaTestolfo.TransferirPraOutraConta(700, contaBob);
            Console.WriteLine($"{contaTestolfo.NomeCorrentista} realizou uma transferencia para {contaBob.NomeCorrentista}");
            Console.ReadLine();



        }
    }
}
