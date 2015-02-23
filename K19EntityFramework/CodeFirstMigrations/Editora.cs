using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    [Table("Editoras")]
    public class Editora
    {
        public int ID { get; set; }
        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage="O campo email é obrigatório")]
        public string Email { get; set; }
        public string Telefone { get; set; }

        [ForeignKey("id_Editora")]
        public virtual IList<Livro> Livros { get; set; }
    }

}
