using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public class CadastroEditora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da Editora: ");
            string nome =  Console.ReadLine();

            nome = String.IsNullOrEmpty(nome) ? null : nome;

            Console.WriteLine("Digite o email da Editora: ");
            string email = Console.ReadLine();
            email = String.IsNullOrEmpty(email) ? null : email;

            Editora e = new Editora() { Email = email, Nome = nome };

            k21EditoraRepositorio db = new k21EditoraRepositorio(new K21Context());
            db.Adicionar(e);
        }
    }
}
