using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class RemoveAluno
    {
        static void Main(string []args)
        {
            using (var db = new K19Context())
            {
                Aluno alunoExcluido = db.Alunos.Find(1);
                db.Alunos.Remove(alunoExcluido);
                db.SaveChanges();
            }
        }
    }
}
