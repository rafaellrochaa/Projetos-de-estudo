using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class AlteraAluno
    {
        static void Main (string []args)
        {
            using (var db = new K19Context())
            {
                Aluno a = db.Alunos.Find(1);
                a.Nome += " -ALTERADO";
                db.SaveChanges();
            }
        }
    }
}
