using System;

public class Calculadora
{
    public double Soma(double a, double b)
    {
        return a + b;
    }

    public double Subtracao(double a, double b)
    {
        return a - b;
    }

    public double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    public double Divisao(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero.");
            return double.NaN; // Retorna "Not a Number" em caso de erro
        }
        return a / b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());  // Lê o número e converte para double
        
        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());  // Lê o número e converte para double
     
        double resultadoSoma = calc.Soma(num1, num2);
        double resultadoSubtracao = calc.Subtracao(num1, num2);
        double resultadoMultiplicacao = calc.Multiplicacao(num1, num2);
        double resultadoDivisao = calc.Divisao(num1, num2);

        Console.WriteLine("\nResultado da Soma: " + resultadoSoma);
        Console.WriteLine("Resultado da Subtração: " + resultadoSubtracao);
        Console.WriteLine("Resultado da Multiplicação: " + resultadoMultiplicacao);
        Console.WriteLine("Resultado da Divisão: " + resultadoDivisao);
        
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
