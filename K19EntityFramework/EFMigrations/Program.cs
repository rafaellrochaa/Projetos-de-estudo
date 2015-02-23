using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new K20Context())
            {
                //Editora e = new Editora { Nome = "K19", Email = "contato@k19.com.br" };

                var ListaEditora = from Editora in db.Editoras select Editora.Nome;

                foreach (var editora in ListaEditora)
                {
                    Console.WriteLine(editora);
                }
                Console.ReadKey();
                //db.Editoras.Add(e);
                //db.SaveChanges();
            }
        }
    }
}
