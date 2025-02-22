using System;

class Aluno
{

    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    public Aluno(string nome, double nota1, double nota2, double nota3)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }

    public double CalcularMedia()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

   
    public string VerificarAprovacao()
    {
        return CalcularMedia() >= 7.0 ? "Aprovado" : "Reprovado";
    }
  
    public void ExibirInformacoes()
    {
        Console.WriteLine("Aluno: " + Nome);
        Console.WriteLine("Média: " + CalcularMedia().ToString("F2"));
        Console.WriteLine("Status: " + VerificarAprovacao());
        Console.ReadKey();
    }
}
class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno("João", 8.5, 7.0, 6.5);
        aluno.ExibirInformacoes();
        Console.WriteLine("Pressione qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
