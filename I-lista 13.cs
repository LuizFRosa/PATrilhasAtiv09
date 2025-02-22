using System;
using System.Collections.Generic;

    public class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(string nome, string telefone)
        {
            contatos.Add(new Contato(nome, telefone));
        }

        public void RemoverContato(string nome)
        {
            contatos.RemoveAll(c => c.Nome == nome);
        }

        public void BuscarContato(string nome)
        {
            foreach (var contato in contatos)
            {
                if (contato.Nome.Contains(nome))
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
                }
            }
        }
    }

    public class Contato
    {
        public string Nome { get; }
        public string Telefone { get; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }

    class Program
    {
        static void Main()
        {
            Agenda agenda = new Agenda();
            agenda.AdicionarContato("Gabriel", "1111-2222");
            agenda.AdicionarContato("Larissa", "3333-4444");
            agenda.AdicionarContato("Eduardo", "5555-6666");
            agenda.AdicionarContato("Camila", "7777-8888");
            agenda.AdicionarContato("Felipe", "9999-0000");
            agenda.AdicionarContato("Isabela", "1212-3434");
            agenda.AdicionarContato("Rafael", "5656-7878");
            agenda.AdicionarContato("Vanessa", "9090-1212");
            agenda.AdicionarContato("Thiago", "3434-5656");
            agenda.AdicionarContato("Patrícia", "7878-9090");
            agenda.AdicionarContato("Anderson", "2323-4545");
            agenda.AdicionarContato("Natália", "6767-8989");

            Console.Write("Digite o nome para buscar: ");
            agenda.BuscarContato(Console.ReadLine());

        }
   
