using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> palavras = new List<string> { "Naruto", "Ichigo", "Son Goku", "Rimuru Tempest", "Anos Voldigoad", "Madoka Kaname" };

        string maiorString = palavras[0];

        foreach (string palavra in palavras)
        {
            if (palavra.Length > maiorString.Length)
            {
                maiorString = palavra;
            }
        }
        Console.WriteLine("O Mais forte entre eles é: " + maiorString);

        Console.WriteLine("Pressione qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
