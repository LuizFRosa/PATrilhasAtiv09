using System;

public class Banco
{
    
    public double AbrirConta(double saldoInicial)
    {
        return saldoInicial; 
    }

    public double FecharConta()
    {
        return 0;  
    }

    public double Deposito(double saldo, double valorDeposito)
    {
        return saldo + valorDeposito; 
    }
    
    public double VerSaldo(double saldo)
    {
        return saldo; 
    }

    public double Saque(double saldo, double valorSaque)
    {
        if (valorSaque <= saldo)
        {
            return saldo - valorSaque;  
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
            return saldo;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Banco banco = new Banco();
        double saldo = 0;
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Realizar Saque");
            Console.WriteLine("3 - Depositar saldo");
            Console.WriteLine("4 - Visualizar saldo atual");
            Console.WriteLine("5 - Fechar conta");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite o valor inicial para a conta: ");
                    double valorInicial = Convert.ToDouble(Console.ReadLine());
                    saldo = banco.AbrirConta(valorInicial);
                    Console.WriteLine("Conta criada com sucesso! Saldo inicial: " + saldo);
                    break;

                case "2":
                    Console.Write("Digite o valor para saque: ");
                    double saque = Convert.ToDouble(Console.ReadLine());
                    saldo = banco.Saque(saldo, saque);
                    Console.WriteLine("Saque realizado. Novo saldo: " + saldo);
                    break;

                case "3":
                    Console.Write("Digite o valor para depósito: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    saldo = banco.Deposito(saldo, deposito);
                    Console.WriteLine("Depósito realizado. Novo saldo: " + saldo);
                    break;

                case "4":
                    Console.WriteLine("Saldo atual: " + banco.VerSaldo(saldo));
                    break;

                case "5":
                    saldo = banco.FecharConta();  // Aqui o saldoo fica igual a 0
                    Console.WriteLine("Conta fechada com sucesso. O saldo agora é: " + saldo);
                    continuar = false;  
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
