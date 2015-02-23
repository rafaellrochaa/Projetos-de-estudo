using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CustomizandoCodeFirstMigrations
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
    }
}
