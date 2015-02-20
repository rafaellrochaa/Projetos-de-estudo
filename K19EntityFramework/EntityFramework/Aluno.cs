using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    [Table("Alunos")]
    public class Aluno
    {
        public int ID { get; set; }

        [Column("nome_aluno"), Required]
        [MaxLength(30), MinLength(6)]
        public string Nome { get; set; }
        //Não mapeado para o banco de dados
        [NotMapped]
        public int Idade { get { return 20 + 1; } }

        public Endereco Endereco { get; set; }
    }
}
