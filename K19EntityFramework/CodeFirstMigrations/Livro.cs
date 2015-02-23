using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    [Table("Livros")]
    public class Livro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int id_Editora { get; set; }

        public Editora Editora { get; set; }
    }
}
