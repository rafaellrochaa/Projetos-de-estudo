using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class Turma
    {
        public int ID { get; set; }
        public int Vagas { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
