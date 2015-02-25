using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public class CadastroEditora
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da Editora: ");
            string nome =  Console.ReadLine();

            nome = String.IsNullOrEmpty(nome) ? null : nome;

            Console.WriteLine("Digite o email da Editora: ");
            string email = Console.ReadLine();
            email = String.IsNullOrEmpty(email) ? null : email;

            EditoraRepositorio e = new EditoraRepositorio();

            e.Incluir(new Editora() { Nome = nome, Email = email });
        }
    }
}
