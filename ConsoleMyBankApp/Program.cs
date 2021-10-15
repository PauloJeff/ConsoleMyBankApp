using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Paulo Jefferson Mendes Oliveira", "000.000.000-00", "Desenvolvedor");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("Conta Corrente Criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigado por criar sua conta!", conta.getSaldo());

            double valorDeposito = 200;
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteSilvia = new Cliente("Silvia Mendes Oliveira", "000.000.000-00", "Administradora");

            ContaCorrente contaSilvia = new ContaCorrente(clienteSilvia, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaSilvia);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaSilvia.getSaldo());
        }
    }
}
