using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 200, 300, 400, 500, 700 };
        int soma = 0;

        foreach (int num in numeros)
        {
        	soma += num;
        }
        double media = (double)soma / numeros.Length;
        
        Console.WriteLine("A média destes numeros são: " + media);
        Console.WriteLine("Pressione qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
